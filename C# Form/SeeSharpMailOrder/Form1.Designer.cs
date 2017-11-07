namespace SeeSharpMailOrder
{
    partial class frmMailOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailOrder));
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.chkNewCustomer = new System.Windows.Forms.CheckBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSummary = new System.Windows.Forms.Button();
            this.radShippingGround = new System.Windows.Forms.RadioButton();
            this.radShippingExpress = new System.Windows.Forms.RadioButton();
            this.radPaymentMoneyOrder = new System.Windows.Forms.RadioButton();
            this.radPaymentCod = new System.Windows.Forms.RadioButton();
            this.radPaymentCharge = new System.Windows.Forms.RadioButton();
            this.rtbShipperWebsite = new System.Windows.Forms.RichTextBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtShippingHandling = new System.Windows.Forms.TextBox();
            this.lblShippingHandling = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtTotalAmountDue = new System.Windows.Forms.TextBox();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.picMailbox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPayment = new System.Windows.Forms.Label();
            this.grpCustomer.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.grpShipping.SuspendLayout();
            this.grpPaymentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMailbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpCustomer.BackgroundImage")));
            this.grpCustomer.Controls.Add(this.chkNewCustomer);
            this.grpCustomer.Controls.Add(this.mskZip);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.txtState);
            this.grpCustomer.Controls.Add(this.lblState);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.lblCity);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.lblStreet);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Location = new System.Drawing.Point(30, 30);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(480, 129);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // chkNewCustomer
            // 
            this.chkNewCustomer.AutoSize = true;
            this.chkNewCustomer.Checked = true;
            this.chkNewCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewCustomer.Location = new System.Drawing.Point(393, 29);
            this.chkNewCustomer.Name = "chkNewCustomer";
            this.chkNewCustomer.Size = new System.Drawing.Size(70, 30);
            this.chkNewCustomer.TabIndex = 10;
            this.chkNewCustomer.Text = "Ne&w\r\nCustomer";
            this.toolTip1.SetToolTip(this.chkNewCustomer, "Check for New Customer entry");
            this.chkNewCustomer.UseVisualStyleBackColor = true;
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(393, 90);
            this.mskZip.Mask = "00000-9999";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(63, 20);
            this.mskZip.TabIndex = 9;
            this.toolTip1.SetToolTip(this.mskZip, "Zip code plus 4");
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(362, 93);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "&Zip:";
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(299, 90);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(51, 20);
            this.txtState.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtState, "State, 2-letter abbreviation");
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(258, 93);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Stat&e:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(60, 90);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(186, 20);
            this.txtCity.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCity, "City of customer");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 93);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "C&ity:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(60, 58);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(290, 20);
            this.txtStreet.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtStreet, "Street address of customer");
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(16, 61);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "S&treet:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Enter full name");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpOrder.BackgroundImage")));
            this.grpOrder.Controls.Add(this.numQuantity);
            this.grpOrder.Controls.Add(this.txtPrice);
            this.grpOrder.Controls.Add(this.lblPrice);
            this.grpOrder.Controls.Add(this.lblQuantity);
            this.grpOrder.Controls.Add(this.txtDescription);
            this.grpOrder.Controls.Add(this.lblDescription);
            this.grpOrder.Location = new System.Drawing.Point(30, 184);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(330, 120);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(85, 59);
            this.numQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(76, 20);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPrice, "Item price");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 93);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "P&rice";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 61);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "&Quantity:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 20);
            this.txtDescription.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDescription, "Item description");
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "&Description:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(38, 638);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(91, 23);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "&Add Order";
            this.toolTip1.SetToolTip(this.btnAddOrder, "Add new order");
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(254, 638);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.btnClear, "Reset form for next customer");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(362, 638);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the form");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSummary.Enabled = false;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Location = new System.Drawing.Point(146, 638);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(91, 23);
            this.btnSummary.TabIndex = 9;
            this.btnSummary.Text = "&Summary";
            this.toolTip1.SetToolTip(this.btnSummary, "Display summary information");
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // radShippingGround
            // 
            this.radShippingGround.AutoSize = true;
            this.radShippingGround.Location = new System.Drawing.Point(20, 65);
            this.radShippingGround.Name = "radShippingGround";
            this.radShippingGround.Size = new System.Drawing.Size(60, 17);
            this.radShippingGround.TabIndex = 1;
            this.radShippingGround.Text = "&Ground";
            this.toolTip1.SetToolTip(this.radShippingGround, "Ground shipping");
            this.radShippingGround.UseVisualStyleBackColor = true;
            // 
            // radShippingExpress
            // 
            this.radShippingExpress.AutoSize = true;
            this.radShippingExpress.Checked = true;
            this.radShippingExpress.Location = new System.Drawing.Point(20, 29);
            this.radShippingExpress.Name = "radShippingExpress";
            this.radShippingExpress.Size = new System.Drawing.Size(62, 17);
            this.radShippingExpress.TabIndex = 0;
            this.radShippingExpress.TabStop = true;
            this.radShippingExpress.Text = "&Express";
            this.toolTip1.SetToolTip(this.radShippingExpress, "Express shipping");
            this.radShippingExpress.UseVisualStyleBackColor = true;
            // 
            // radPaymentMoneyOrder
            // 
            this.radPaymentMoneyOrder.AutoSize = true;
            this.radPaymentMoneyOrder.Location = new System.Drawing.Point(20, 101);
            this.radPaymentMoneyOrder.Name = "radPaymentMoneyOrder";
            this.radPaymentMoneyOrder.Size = new System.Drawing.Size(86, 17);
            this.radPaymentMoneyOrder.TabIndex = 2;
            this.radPaymentMoneyOrder.Text = "&Money Order";
            this.toolTip1.SetToolTip(this.radPaymentMoneyOrder, "Pay via Money Order");
            this.radPaymentMoneyOrder.UseVisualStyleBackColor = true;
            // 
            // radPaymentCod
            // 
            this.radPaymentCod.AutoSize = true;
            this.radPaymentCod.Location = new System.Drawing.Point(20, 65);
            this.radPaymentCod.Name = "radPaymentCod";
            this.radPaymentCod.Size = new System.Drawing.Size(48, 17);
            this.radPaymentCod.TabIndex = 1;
            this.radPaymentCod.Text = "C&OD";
            this.toolTip1.SetToolTip(this.radPaymentCod, "Pay cash on delivery");
            this.radPaymentCod.UseVisualStyleBackColor = true;
            // 
            // radPaymentCharge
            // 
            this.radPaymentCharge.AutoSize = true;
            this.radPaymentCharge.Location = new System.Drawing.Point(20, 29);
            this.radPaymentCharge.Name = "radPaymentCharge";
            this.radPaymentCharge.Size = new System.Drawing.Size(59, 17);
            this.radPaymentCharge.TabIndex = 0;
            this.radPaymentCharge.Text = "C&harge";
            this.toolTip1.SetToolTip(this.radPaymentCharge, "Pay via credit card");
            this.radPaymentCharge.UseVisualStyleBackColor = true;
            this.radPaymentCharge.CheckedChanged += new System.EventHandler(this.radPaymentCharge_CheckedChanged);
            // 
            // rtbShipperWebsite
            // 
            this.rtbShipperWebsite.Location = new System.Drawing.Point(379, 442);
            this.rtbShipperWebsite.Multiline = false;
            this.rtbShipperWebsite.Name = "rtbShipperWebsite";
            this.rtbShipperWebsite.ReadOnly = true;
            this.rtbShipperWebsite.Size = new System.Drawing.Size(129, 20);
            this.rtbShipperWebsite.TabIndex = 12;
            this.rtbShipperWebsite.Text = "www.ups.com";
            this.toolTip1.SetToolTip(this.rtbShipperWebsite, "Click to open shipper website");
            this.rtbShipperWebsite.WordWrap = false;
            this.rtbShipperWebsite.Click += new System.EventHandler(this.rtbShipperWebsite_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.Color.Transparent;
            this.grpSummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpSummary.BackgroundImage")));
            this.grpSummary.Controls.Add(this.lblTaxRate);
            this.grpSummary.Controls.Add(this.lblDiscount);
            this.grpSummary.Controls.Add(this.txtAmountDue);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.txtShippingHandling);
            this.grpSummary.Controls.Add(this.lblShippingHandling);
            this.grpSummary.Controls.Add(this.txtSalesTax);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.txtTotalAmountDue);
            this.grpSummary.Controls.Add(this.lblTotalAmountDue);
            this.grpSummary.Location = new System.Drawing.Point(30, 330);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(330, 164);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(83, 60);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(51, 13);
            this.lblTaxRate.TabIndex = 16;
            this.lblTaxRate.Text = "Tax Rate";
            this.lblTaxRate.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(83, 25);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.Visible = false;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Enabled = false;
            this.txtAmountDue.Location = new System.Drawing.Point(192, 22);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(123, 20);
            this.txtAmountDue.TabIndex = 14;
            this.txtAmountDue.TabStop = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(16, 25);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(64, 13);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.Text = "Amount due";
            // 
            // txtShippingHandling
            // 
            this.txtShippingHandling.Enabled = false;
            this.txtShippingHandling.Location = new System.Drawing.Point(192, 92);
            this.txtShippingHandling.Name = "txtShippingHandling";
            this.txtShippingHandling.ReadOnly = true;
            this.txtShippingHandling.Size = new System.Drawing.Size(123, 20);
            this.txtShippingHandling.TabIndex = 12;
            this.txtShippingHandling.TabStop = false;
            // 
            // lblShippingHandling
            // 
            this.lblShippingHandling.AutoSize = true;
            this.lblShippingHandling.Location = new System.Drawing.Point(16, 95);
            this.lblShippingHandling.Name = "lblShippingHandling";
            this.lblShippingHandling.Size = new System.Drawing.Size(114, 13);
            this.lblShippingHandling.TabIndex = 11;
            this.lblShippingHandling.Text = "Shipping and Handling";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Enabled = false;
            this.txtSalesTax.Location = new System.Drawing.Point(192, 57);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(123, 20);
            this.txtSalesTax.TabIndex = 10;
            this.txtSalesTax.TabStop = false;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(16, 60);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(54, 13);
            this.lblSalesTax.TabIndex = 9;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // txtTotalAmountDue
            // 
            this.txtTotalAmountDue.Enabled = false;
            this.txtTotalAmountDue.Location = new System.Drawing.Point(192, 127);
            this.txtTotalAmountDue.Name = "txtTotalAmountDue";
            this.txtTotalAmountDue.ReadOnly = true;
            this.txtTotalAmountDue.Size = new System.Drawing.Size(123, 20);
            this.txtTotalAmountDue.TabIndex = 8;
            this.txtTotalAmountDue.TabStop = false;
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Location = new System.Drawing.Point(16, 130);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(93, 13);
            this.lblTotalAmountDue.TabIndex = 7;
            this.lblTotalAmountDue.Text = "Total Amount Due";
            // 
            // grpShipping
            // 
            this.grpShipping.BackColor = System.Drawing.Color.Transparent;
            this.grpShipping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpShipping.BackgroundImage")));
            this.grpShipping.Controls.Add(this.radShippingGround);
            this.grpShipping.Controls.Add(this.radShippingExpress);
            this.grpShipping.Location = new System.Drawing.Point(379, 184);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Size = new System.Drawing.Size(129, 94);
            this.grpShipping.TabIndex = 2;
            this.grpShipping.TabStop = false;
            this.grpShipping.Text = "Shipping";
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.grpPaymentType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPaymentType.BackgroundImage")));
            this.grpPaymentType.Controls.Add(this.radPaymentMoneyOrder);
            this.grpPaymentType.Controls.Add(this.radPaymentCod);
            this.grpPaymentType.Controls.Add(this.radPaymentCharge);
            this.grpPaymentType.Location = new System.Drawing.Point(379, 299);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Size = new System.Drawing.Size(129, 131);
            this.grpPaymentType.TabIndex = 3;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "Payment Type";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(423, 474);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(85, 20);
            this.txtDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(376, 477);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // picMailbox
            // 
            this.picMailbox.Image = ((System.Drawing.Image)(resources.GetObject("picMailbox.Image")));
            this.picMailbox.Location = new System.Drawing.Point(475, 621);
            this.picMailbox.Name = "picMailbox";
            this.picMailbox.Size = new System.Drawing.Size(66, 53);
            this.picMailbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMailbox.TabIndex = 13;
            this.picMailbox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(30, 514);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(200, 80);
            this.lblPayment.TabIndex = 14;
            // 
            // frmMailOrder
            // 
            this.AcceptButton = this.btnAddOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(544, 688);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.picMailbox);
            this.Controls.Add(this.rtbShipperWebsite);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpPaymentType);
            this.Controls.Add(this.grpShipping);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMailOrder";
            this.Text = "See Sharp Mail Order";
            this.Load += new System.EventHandler(this.frmMailOrder_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMailbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkNewCustomer;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtShippingHandling;
        private System.Windows.Forms.Label lblShippingHandling;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtTotalAmountDue;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.RadioButton radShippingGround;
        private System.Windows.Forms.RadioButton radShippingExpress;
        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.RadioButton radPaymentMoneyOrder;
        private System.Windows.Forms.RadioButton radPaymentCod;
        private System.Windows.Forms.RadioButton radPaymentCharge;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbShipperWebsite;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.PictureBox picMailbox;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPayment;
    }
}

