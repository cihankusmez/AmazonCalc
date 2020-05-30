using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AmazonCalc
{
    public partial class Form1 : Form
    {
        public static string TodayUrl = "http://www.tcmb.gov.tr/kurlar/today.xml";
        public NameValueCollection AppSettings;

        public List<Tcmb> ExchangeRates;

        public Form1()
        {
            InitializeComponent();
            GridExchangeRate.AutoGenerateColumns = false;

            GridExchangeRate.Columns["ForexBuying"].DefaultCellStyle.Format = "N4";
            GridExchangeRate.Columns["ForexBuying"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            GridExchangeRate.Columns["ForexSelling"].DefaultCellStyle.Format = "N4";
            GridExchangeRate.Columns["ForexSelling"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            AppSettings = Helper.GetAppSettings();

            cbGrandTotalCurrency.Text = "GBP";
            cbProductCostCurrency.Text = "TRY";
            cbShippingCurrency.Text = "TRY";

            txtEtsyRate.Text = AppSettings["EtsyRate"];
            txtAmazonRate.Text = AppSettings["AmazonRate"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectExchangeRates();

            txtGrandTotal.KeyPress += Helper.DecimalOnly;
            txtEtsyRate.KeyPress += Helper.IntegerOnly;
            txtAmazonRate.KeyPress += Helper.IntegerOnly;
            txtUnit.KeyPress += Helper.IntegerOnly;
        }

        public void SelectExchangeRates()
        {
            try
            {
                ExchangeRates = GetExchangeRatesFromTcmb(DateTime.Now);

                GridExchangeRate.Refresh();
                GridExchangeRate.DataSource = ExchangeRates;
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static List<Tcmb> GetExchangeRatesFromTcmb(DateTime currencyDate)
        {
            var tcmb = new List<Tcmb>();

            var tcmbUrl = TcmbUrl(currencyDate);

            var xmlTcmb = new XmlDocument();

            xmlTcmb.Load(tcmbUrl);

            var root = xmlTcmb.DocumentElement;
            if (root != null)
            {
                var nodeList = root.GetElementsByTagName("Currency");

                // Toplam XML de 19 kayıt var ama sonuncusu bize lazım değil o nedenle -1 yapıyoruz.
                for (var i = 0; i < nodeList.Count - 1; i++)
                {
                    var nodes = nodeList[i].ChildNodes;

                    var currencyNode = nodeList[i].Attributes;
                    if (currencyNode != null)
                        tcmb.Add(new Tcmb
                        {
                            CurrencyCode = currencyNode["CurrencyCode"].Value,
                            Unit = nodes[0].FirstChild == null ? 0 : Convert.ToInt32(nodes[0].FirstChild.Value),
                            Name = nodes[1].FirstChild.Value,
                            CurrencyName = nodes[2].FirstChild.Value,
                            ForexBuying = nodes[3].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[3].FirstChild.Value.Replace(".", ",")),
                            ForexSelling = nodes[4].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[4].FirstChild.Value.Replace(".", ",")),
                            BanknoteBuying = nodes[5].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[5].FirstChild.Value.Replace(".", ",")),
                            BanknoteSelling = nodes[6].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[6].FirstChild.Value.Replace(".", ",")),
                            CrossRateUsd = nodes[7].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[7].FirstChild.Value.Replace(".", ",")),
                            CrossRateOther = nodes[8].FirstChild == null
                                ? 0
                                : Convert.ToDecimal(nodes[8].FirstChild?.Value.Replace(".", ","))
                        });
                }
            }

            return tcmb.OrderBy(x => x.CurrencyCode).ToList();
        }

        public static string TcmbUrl(DateTime currencyDate)
        {
            var tryAgain = true;
            var tcmbUrl = string.Empty;

            var i = 0;
            while (tryAgain && i <= 10)
            {
                i++;
                try
                {
                    if (currencyDate.Date == DateTime.Today)
                        return TodayUrl;

                    var currencyFolder = currencyDate.ToString("yyyyMM");
                    var xmlPath = currencyDate.ToString("ddMMyyyy");
                    tcmbUrl = "http://www.tcmb.gov.tr/kurlar/" + currencyFolder + "/" + xmlPath + ".xml";

                    var request = WebRequest.Create(tcmbUrl);
                    using (var response = request.GetResponse())
                    {
                        using (var responseStream = response.GetResponseStream())
                        {
                            // Process the stream
                            //return tcmbUrl;
                        }
                    }

                    tryAgain = false;
                }
                catch (WebException ex)
                {
                    tryAgain = true;
                    if (ex.Status == WebExceptionStatus.ProtocolError &&
                        ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if (resp.StatusCode == HttpStatusCode.NotFound)
                            currencyDate = currencyDate.AddDays(-1);
                    }
                }
            }

            return tcmbUrl;
        }

        private void btnSaveExchangeRates_Click(object sender, EventArgs e)
        {
            SelectExchangeRates();
        }

        private void Calculate()
        {
            if (string.IsNullOrEmpty(txtGrandTotal.Text) || string.IsNullOrEmpty(txtShipping.Text) || string.IsNullOrEmpty(txtProductCost.Text)
                || string.IsNullOrEmpty(txtEtsyRate.Text) || string.IsNullOrEmpty(txtAmazonRate.Text) || string.IsNullOrEmpty(txtUnit.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(AppSettings["EtsyListingFee"]))
            {
                MessageBox.Show("Etsy Listing Fee Is Not Set");
                return;
            }

            var grandtotal = Convert.ToDecimal(txtGrandTotal.Text.Replace(".", ","));
            var shipping = Convert.ToDecimal(txtShipping.Text.Replace(".", ","));
            var productCost = Convert.ToDecimal(txtProductCost.Text.Replace(".", ","));
            var unit = Convert.ToInt32(txtProductCost.Text);
            var etsyListingFee = Helper.RoundedValue(Convert.ToDecimal(AppSettings["EtsyListingFee"].Replace(".", ",")));

            var grandtotalInTry = ConvertToTry(grandtotal, cbGrandTotalCurrency);
            var shippingInTry = ConvertToTry(shipping, cbShippingCurrency);
            var productCostInTry = ConvertToTry(productCost, cbProductCostCurrency);

            var amazonRate = Convert.ToDecimal(txtAmazonRate.Text) / 100;
            var amazonCommission = grandtotalInTry * amazonRate;

            var etsyRate = Convert.ToDecimal(txtEtsyRate.Text) / 100;
            var etsyCommission = (grandtotalInTry * etsyRate) + (unit * etsyListingFee);

            labelGrandTotal.Text = grandtotalInTry.ToString("C2");
            labelShipping.Text = shippingInTry.ToString("C2");
            labelProductCost.Text = productCostInTry.ToString("C2");
            labelAmazonCommission.Text = Helper.RoundedValue(amazonCommission).ToString("C2");
            labelEtsyCommission.Text = Helper.RoundedValue(etsyCommission).ToString("C2");
            labelEtsyBenefit.Text = Helper.RoundedValue(grandtotalInTry - (shippingInTry + productCostInTry + etsyCommission)).ToString("C2");
            labelAmazonBenefit.Text = Helper.RoundedValue(grandtotalInTry - (shippingInTry + productCostInTry + amazonCommission)).ToString("C2");
        }

        private decimal ConvertToTry(decimal amount, ComboBox cb)
        {
            var selectedCurrency = cb.SelectedItem.ToString();

            if (selectedCurrency == "TRY")
            {
                return amount;
            }
            
            var selectedExchangeRate =
                (decimal) ExchangeRates.FirstOrDefault(x => x.CurrencyCode == selectedCurrency)?.ForexSelling;


            return Helper.RoundedValue(amount * selectedExchangeRate);
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtShipping_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtProductCost_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtEtsyRate_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtAmazonRate_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
