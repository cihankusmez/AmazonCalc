namespace AmazonCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GridExchangeRate = new System.Windows.Forms.DataGridView();
            this.CurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForexBuying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForexSelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveExchangeRates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelShipping = new System.Windows.Forms.Label();
            this.labelProductCost = new System.Windows.Forms.Label();
            this.labelAmazonCommission = new System.Windows.Forms.Label();
            this.labelEtsyBenefit = new System.Windows.Forms.Label();
            this.cbGrandTotalCurrency = new System.Windows.Forms.ComboBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbShippingCurrency = new System.Windows.Forms.ComboBox();
            this.cbProductCostCurrency = new System.Windows.Forms.ComboBox();
            this.txtEtsyRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmazonRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelEtsyCommission = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAmazonBenefit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // GridExchangeRate
            // 
            this.GridExchangeRate.AllowUserToAddRows = false;
            this.GridExchangeRate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GridExchangeRate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridExchangeRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExchangeRate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridExchangeRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExchangeRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyCode,
            this.ForexBuying,
            this.ForexSelling});
            this.GridExchangeRate.Location = new System.Drawing.Point(9, 12);
            this.GridExchangeRate.MultiSelect = false;
            this.GridExchangeRate.Name = "GridExchangeRate";
            this.GridExchangeRate.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExchangeRate.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridExchangeRate.RowHeadersVisible = false;
            this.GridExchangeRate.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GridExchangeRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridExchangeRate.Size = new System.Drawing.Size(502, 538);
            this.GridExchangeRate.TabIndex = 30;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.DataPropertyName = "CurrencyCode";
            this.CurrencyCode.HeaderText = "Döviz";
            this.CurrencyCode.Name = "CurrencyCode";
            this.CurrencyCode.ReadOnly = true;
            // 
            // ForexBuying
            // 
            this.ForexBuying.DataPropertyName = "ForexBuying";
            this.ForexBuying.HeaderText = "Döviz Alış";
            this.ForexBuying.Name = "ForexBuying";
            this.ForexBuying.ReadOnly = true;
            // 
            // ForexSelling
            // 
            this.ForexSelling.DataPropertyName = "ForexSelling";
            this.ForexSelling.HeaderText = "Döviz Satış";
            this.ForexSelling.Name = "ForexSelling";
            this.ForexSelling.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(9, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 81);
            this.btnClose.TabIndex = 33;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Çıkış";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveExchangeRates
            // 
            this.btnSaveExchangeRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveExchangeRates.Location = new System.Drawing.Point(122, 556);
            this.btnSaveExchangeRates.Name = "btnSaveExchangeRates";
            this.btnSaveExchangeRates.Size = new System.Drawing.Size(389, 81);
            this.btnSaveExchangeRates.TabIndex = 31;
            this.btnSaveExchangeRates.Text = "TCMB Kurları Al / Güncelle";
            this.btnSaveExchangeRates.UseVisualStyleBackColor = true;
            this.btnSaveExchangeRates.Click += new System.EventHandler(this.btnSaveExchangeRates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(541, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "GrandTotal";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrandTotal.Location = new System.Drawing.Point(666, 23);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(145, 31);
            this.txtGrandTotal.TabIndex = 1;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.txtGrandTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(541, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "GrandTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(564, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Shipping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(524, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Product Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(805, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Amazon Commission";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(891, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 62;
            this.label13.Text = "Etsy Benefit";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGrandTotal.Location = new System.Drawing.Point(693, 193);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(106, 25);
            this.labelGrandTotal.TabIndex = 63;
            this.labelGrandTotal.Text = "0.00";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelShipping
            // 
            this.labelShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShipping.Location = new System.Drawing.Point(693, 232);
            this.labelShipping.Name = "labelShipping";
            this.labelShipping.Size = new System.Drawing.Size(106, 25);
            this.labelShipping.TabIndex = 64;
            this.labelShipping.Text = "0.00";
            this.labelShipping.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProductCost
            // 
            this.labelProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProductCost.Location = new System.Drawing.Point(693, 273);
            this.labelProductCost.Name = "labelProductCost";
            this.labelProductCost.Size = new System.Drawing.Size(106, 25);
            this.labelProductCost.TabIndex = 65;
            this.labelProductCost.Text = "0.00";
            this.labelProductCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAmazonCommission
            // 
            this.labelAmazonCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmazonCommission.Location = new System.Drawing.Point(1040, 250);
            this.labelAmazonCommission.Name = "labelAmazonCommission";
            this.labelAmazonCommission.Size = new System.Drawing.Size(106, 25);
            this.labelAmazonCommission.TabIndex = 66;
            this.labelAmazonCommission.Text = "0.00";
            this.labelAmazonCommission.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEtsyBenefit
            // 
            this.labelEtsyBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEtsyBenefit.Location = new System.Drawing.Point(1040, 209);
            this.labelEtsyBenefit.Name = "labelEtsyBenefit";
            this.labelEtsyBenefit.Size = new System.Drawing.Size(106, 25);
            this.labelEtsyBenefit.TabIndex = 67;
            this.labelEtsyBenefit.Text = "0.00";
            this.labelEtsyBenefit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbGrandTotalCurrency
            // 
            this.cbGrandTotalCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrandTotalCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGrandTotalCurrency.FormattingEnabled = true;
            this.cbGrandTotalCurrency.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "EUR",
            "TRY"});
            this.cbGrandTotalCurrency.Location = new System.Drawing.Point(817, 23);
            this.cbGrandTotalCurrency.Name = "cbGrandTotalCurrency";
            this.cbGrandTotalCurrency.Size = new System.Drawing.Size(78, 33);
            this.cbGrandTotalCurrency.TabIndex = 7;
            // 
            // txtShipping
            // 
            this.txtShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShipping.Location = new System.Drawing.Point(666, 60);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(145, 31);
            this.txtShipping.TabIndex = 2;
            this.txtShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShipping.TextChanged += new System.EventHandler(this.txtShipping_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(564, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Shipping";
            // 
            // txtProductCost
            // 
            this.txtProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductCost.Location = new System.Drawing.Point(666, 97);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(145, 31);
            this.txtProductCost.TabIndex = 3;
            this.txtProductCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductCost.TextChanged += new System.EventHandler(this.txtProductCost_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(524, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Product Cost";
            // 
            // cbShippingCurrency
            // 
            this.cbShippingCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShippingCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbShippingCurrency.FormattingEnabled = true;
            this.cbShippingCurrency.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "EUR",
            "TRY"});
            this.cbShippingCurrency.Location = new System.Drawing.Point(817, 60);
            this.cbShippingCurrency.Name = "cbShippingCurrency";
            this.cbShippingCurrency.Size = new System.Drawing.Size(78, 33);
            this.cbShippingCurrency.TabIndex = 8;
            // 
            // cbProductCostCurrency
            // 
            this.cbProductCostCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCostCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProductCostCurrency.FormattingEnabled = true;
            this.cbProductCostCurrency.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "EUR",
            "TRY"});
            this.cbProductCostCurrency.Location = new System.Drawing.Point(817, 97);
            this.cbProductCostCurrency.Name = "cbProductCostCurrency";
            this.cbProductCostCurrency.Size = new System.Drawing.Size(78, 33);
            this.cbProductCostCurrency.TabIndex = 9;
            // 
            // txtEtsyRate
            // 
            this.txtEtsyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEtsyRate.Location = new System.Drawing.Point(1045, 20);
            this.txtEtsyRate.Name = "txtEtsyRate";
            this.txtEtsyRate.Size = new System.Drawing.Size(91, 31);
            this.txtEtsyRate.TabIndex = 4;
            this.txtEtsyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEtsyRate.TextChanged += new System.EventHandler(this.txtEtsyRate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(934, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Etsy Rate";
            // 
            // txtAmazonRate
            // 
            this.txtAmazonRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmazonRate.Location = new System.Drawing.Point(1045, 62);
            this.txtAmazonRate.Name = "txtAmazonRate";
            this.txtAmazonRate.Size = new System.Drawing.Size(91, 31);
            this.txtAmazonRate.TabIndex = 5;
            this.txtAmazonRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmazonRate.TextChanged += new System.EventHandler(this.txtAmazonRate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(903, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Amazon Rate";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnit.Location = new System.Drawing.Point(1045, 100);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(91, 31);
            this.txtUnit.TabIndex = 6;
            this.txtUnit.Text = "1";
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(989, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 25);
            this.label14.TabIndex = 80;
            this.label14.Text = "Unit";
            // 
            // labelEtsyCommission
            // 
            this.labelEtsyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEtsyCommission.Location = new System.Drawing.Point(1040, 170);
            this.labelEtsyCommission.Name = "labelEtsyCommission";
            this.labelEtsyCommission.Size = new System.Drawing.Size(106, 25);
            this.labelEtsyCommission.TabIndex = 82;
            this.labelEtsyCommission.Text = "0.00";
            this.labelEtsyCommission.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(841, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "Etsy Commission";
            // 
            // labelAmazonBenefit
            // 
            this.labelAmazonBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmazonBenefit.Location = new System.Drawing.Point(1040, 287);
            this.labelAmazonBenefit.Name = "labelAmazonBenefit";
            this.labelAmazonBenefit.Size = new System.Drawing.Size(106, 25);
            this.labelAmazonBenefit.TabIndex = 84;
            this.labelAmazonBenefit.Text = "0.00";
            this.labelAmazonBenefit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(855, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 25);
            this.label12.TabIndex = 83;
            this.label12.Text = "Amazon Benefit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 649);
            this.Controls.Add(this.labelAmazonBenefit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelEtsyCommission);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtAmazonRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEtsyRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProductCostCurrency);
            this.Controls.Add(this.cbShippingCurrency);
            this.Controls.Add(this.txtProductCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrandTotalCurrency);
            this.Controls.Add(this.labelEtsyBenefit);
            this.Controls.Add(this.labelAmazonCommission);
            this.Controls.Add(this.labelProductCost);
            this.Controls.Add(this.labelShipping);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridExchangeRate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveExchangeRates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commission Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridExchangeRate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveExchangeRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForexBuying;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForexSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelShipping;
        private System.Windows.Forms.Label labelProductCost;
        private System.Windows.Forms.Label labelAmazonCommission;
        private System.Windows.Forms.Label labelEtsyBenefit;
        private System.Windows.Forms.ComboBox cbGrandTotalCurrency;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbShippingCurrency;
        private System.Windows.Forms.ComboBox cbProductCostCurrency;
        private System.Windows.Forms.TextBox txtEtsyRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmazonRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelEtsyCommission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAmazonBenefit;
        private System.Windows.Forms.Label label12;
    }
}

