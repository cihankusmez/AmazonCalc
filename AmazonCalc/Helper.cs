using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace AmazonCalc
{
    class Helper
    {
        

        public static decimal RoundedValue(decimal decimalValue)
        {
            return Math.Round(decimalValue, 2, MidpointRounding.AwayFromZero);
        }
        public static NameValueCollection GetAppSettings()
        {
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                throw new Exception("Ayar Dosyası Okuma Hatası");
            }

            return appSettings;
        }

        public static void UpdateSettings(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        //Sadece Nümerik Sayılar
        public static void DecimalOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                e.Handled = false;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;

            if (!char.IsControl(e.KeyChar))
            {
                var textBox = (TextBox)sender;

                if (textBox.SelectionLength == textBox.Text.Length)
                    textBox.Text = string.Empty;

                if (textBox.Text.IndexOf(',') > -1 &&
                    textBox.Text.Substring(textBox.Text.IndexOf(',')).Length >= 3)
                    e.Handled = true;

                //Max Value : 123456789 || 123456.78
                if (textBox.Text.Length >= 9)
                    e.Handled = true;

                //İlk Karakterin Nokta veya Sıfır Olmasını Engelliyoruz
                if ((e.KeyChar == ',' || e.KeyChar == '0') && textBox.Text.Length == 0)
                {
                    textBox.Text = "0,";
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                    e.Handled = true;
                }
            }
        }

        public static void IntegerOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
