namespace WindowsFormsApp1
{
    partial class AddEditPackageForm
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
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            this.prodSuppListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delectProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodSuppListLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.packageGroupBox = new System.Windows.Forms.GroupBox();
            this.pkgDescripErrorMessage = new System.Windows.Forms.Label();
            this.pkgCommissionErrorMessage = new System.Windows.Forms.Label();
            this.pkgBasePriceErrorMessage = new System.Windows.Forms.Label();
            this.pkgEndDateErrorMessage = new System.Windows.Forms.Label();
            this.pkgStartDateErrorMessage = new System.Windows.Forms.Label();
            this.pkgErrorMessage = new System.Windows.Forms.Label();
            this.prodSuppGroupBox = new System.Windows.Forms.GroupBox();
            this.prodSuppListErrorMessage = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.packageGroupBox.SuspendLayout();
            this.prodSuppGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(26, 145);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(76, 13);
            pkgBasePriceLabel.TabIndex = 21;
            pkgBasePriceLabel.Text = "Base Price ($):";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(24, 37);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(84, 13);
            pkgNameLabel.TabIndex = 23;
            pkgNameLabel.Text = "Package Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(24, 75);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(58, 13);
            pkgStartDateLabel.TabIndex = 25;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(26, 112);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(55, 13);
            pkgEndDateLabel.TabIndex = 27;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(24, 175);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(122, 13);
            pkgAgencyCommissionLabel.TabIndex = 29;
            pkgAgencyCommissionLabel.Text = "Agency Commission ($): ";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(24, 213);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(63, 13);
            pkgDescLabel.TabIndex = 31;
            pkgDescLabel.Text = "Description:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(19, 46);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(66, 13);
            prodNameLabel.TabIndex = 32;
            prodNameLabel.Text = "Product List:";
            // 
            // supNameLabel
            // 
            supNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(185, 46);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(67, 13);
            supNameLabel.TabIndex = 33;
            supNameLabel.Text = "Supplier List:";
            // 
            // prodSuppListBox
            // 
            this.prodSuppListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodSuppListBox.ContextMenuStrip = this.contextMenuStrip;
            this.prodSuppListBox.FormattingEnabled = true;
            this.prodSuppListBox.Location = new System.Drawing.Point(19, 154);
            this.prodSuppListBox.Name = "prodSuppListBox";
            this.prodSuppListBox.ScrollAlwaysVisible = true;
            this.prodSuppListBox.Size = new System.Drawing.Size(402, 69);
            this.prodSuppListBox.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delectProductToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(232, 26);
            // 
            // delectProductToolStripMenuItem
            // 
            this.delectProductToolStripMenuItem.Name = "delectProductToolStripMenuItem";
            this.delectProductToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.delectProductToolStripMenuItem.Text = "Delect Products and Suppliers";
            this.delectProductToolStripMenuItem.Click += new System.EventHandler(this.delectProductToolStripMenuItem_Click);
            // 
            // prodSuppListLabel
            // 
            this.prodSuppListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodSuppListLabel.AutoSize = true;
            this.prodSuppListLabel.Location = new System.Drawing.Point(19, 125);
            this.prodSuppListLabel.Name = "prodSuppListLabel";
            this.prodSuppListLabel.Size = new System.Drawing.Size(327, 13);
            this.prodSuppListLabel.TabIndex = 1;
            this.prodSuppListLabel.Text = "List of Products and Suppliers - Right click to delete unwanted items";
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.Location = new System.Drawing.Point(350, 51);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(79, 42);
            this.addProductButton.TabIndex = 16;
            this.addProductButton.Text = "Add product\r\nand supplier";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(430, 624);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(45, 624);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(WindowsFormsApp1.Package);
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(160, 142);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(269, 20);
            this.pkgBasePriceTextBox.TabIndex = 4;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(160, 34);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(269, 20);
            this.pkgNameTextBox.TabIndex = 1;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(160, 70);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(269, 20);
            this.pkgStartDateDateTimePicker.TabIndex = 2;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(160, 106);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(269, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 3;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(160, 176);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(269, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(160, 212);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pkgDescTextBox.Size = new System.Drawing.Size(269, 20);
            this.pkgDescTextBox.TabIndex = 6;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApp1.Product);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(22, 72);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(107, 21);
            this.prodNameComboBox.TabIndex = 7;
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(WindowsFormsApp1.Supplier);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierId", true));
            this.supNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(149, 72);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(174, 21);
            this.supNameComboBox.TabIndex = 8;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataSource = typeof(WindowsFormsApp1.Supplier);
            // 
            // productsSuppliersBindingSource
            // 
            this.productsSuppliersBindingSource.DataMember = "Products_Suppliers";
            this.productsSuppliersBindingSource.DataSource = this.supplierBindingSource1;
            // 
            // supplierBindingSource2
            // 
            this.supplierBindingSource2.DataSource = typeof(WindowsFormsApp1.Supplier);
            // 
            // productsSupplierBindingSource
            // 
            this.productsSupplierBindingSource.DataSource = typeof(WindowsFormsApp1.Products_Supplier);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(WindowsFormsApp1.Product);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(153, 624);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(67, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // packageGroupBox
            // 
            this.packageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageGroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.packageGroupBox.Controls.Add(this.pkgDescripErrorMessage);
            this.packageGroupBox.Controls.Add(this.pkgCommissionErrorMessage);
            this.packageGroupBox.Controls.Add(this.pkgBasePriceErrorMessage);
            this.packageGroupBox.Controls.Add(this.pkgEndDateErrorMessage);
            this.packageGroupBox.Controls.Add(this.pkgStartDateErrorMessage);
            this.packageGroupBox.Controls.Add(this.pkgErrorMessage);
            this.packageGroupBox.Controls.Add(pkgDescLabel);
            this.packageGroupBox.Controls.Add(this.pkgDescTextBox);
            this.packageGroupBox.Controls.Add(pkgAgencyCommissionLabel);
            this.packageGroupBox.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.packageGroupBox.Controls.Add(pkgEndDateLabel);
            this.packageGroupBox.Controls.Add(this.pkgEndDateDateTimePicker);
            this.packageGroupBox.Controls.Add(pkgStartDateLabel);
            this.packageGroupBox.Controls.Add(this.pkgStartDateDateTimePicker);
            this.packageGroupBox.Controls.Add(pkgNameLabel);
            this.packageGroupBox.Controls.Add(this.pkgNameTextBox);
            this.packageGroupBox.Controls.Add(pkgBasePriceLabel);
            this.packageGroupBox.Controls.Add(this.pkgBasePriceTextBox);
            this.packageGroupBox.Location = new System.Drawing.Point(42, 74);
            this.packageGroupBox.Name = "packageGroupBox";
            this.packageGroupBox.Size = new System.Drawing.Size(455, 249);
            this.packageGroupBox.TabIndex = 36;
            this.packageGroupBox.TabStop = false;
            this.packageGroupBox.Text = "Package Details";
            // 
            // pkgDescripErrorMessage
            // 
            this.pkgDescripErrorMessage.AutoSize = true;
            this.pkgDescripErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgDescripErrorMessage.Location = new System.Drawing.Point(160, 196);
            this.pkgDescripErrorMessage.Name = "pkgDescripErrorMessage";
            this.pkgDescripErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgDescripErrorMessage.TabIndex = 33;
            // 
            // pkgCommissionErrorMessage
            // 
            this.pkgCommissionErrorMessage.AutoSize = true;
            this.pkgCommissionErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgCommissionErrorMessage.Location = new System.Drawing.Point(160, 162);
            this.pkgCommissionErrorMessage.Name = "pkgCommissionErrorMessage";
            this.pkgCommissionErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgCommissionErrorMessage.TabIndex = 33;
            // 
            // pkgBasePriceErrorMessage
            // 
            this.pkgBasePriceErrorMessage.AutoSize = true;
            this.pkgBasePriceErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgBasePriceErrorMessage.Location = new System.Drawing.Point(160, 129);
            this.pkgBasePriceErrorMessage.Name = "pkgBasePriceErrorMessage";
            this.pkgBasePriceErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgBasePriceErrorMessage.TabIndex = 33;
            // 
            // pkgEndDateErrorMessage
            // 
            this.pkgEndDateErrorMessage.AutoSize = true;
            this.pkgEndDateErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgEndDateErrorMessage.Location = new System.Drawing.Point(160, 92);
            this.pkgEndDateErrorMessage.Name = "pkgEndDateErrorMessage";
            this.pkgEndDateErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgEndDateErrorMessage.TabIndex = 33;
            // 
            // pkgStartDateErrorMessage
            // 
            this.pkgStartDateErrorMessage.AutoSize = true;
            this.pkgStartDateErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgStartDateErrorMessage.Location = new System.Drawing.Point(160, 57);
            this.pkgStartDateErrorMessage.Name = "pkgStartDateErrorMessage";
            this.pkgStartDateErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgStartDateErrorMessage.TabIndex = 33;
            // 
            // pkgErrorMessage
            // 
            this.pkgErrorMessage.AutoSize = true;
            this.pkgErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.pkgErrorMessage.Location = new System.Drawing.Point(159, 18);
            this.pkgErrorMessage.Name = "pkgErrorMessage";
            this.pkgErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.pkgErrorMessage.TabIndex = 33;
            // 
            // prodSuppGroupBox
            // 
            this.prodSuppGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodSuppGroupBox.BackColor = System.Drawing.Color.Thistle;
            this.prodSuppGroupBox.Controls.Add(this.prodSuppListErrorMessage);
            this.prodSuppGroupBox.Controls.Add(this.addProductButton);
            this.prodSuppGroupBox.Controls.Add(supNameLabel);
            this.prodSuppGroupBox.Controls.Add(this.supNameComboBox);
            this.prodSuppGroupBox.Controls.Add(this.prodNameComboBox);
            this.prodSuppGroupBox.Controls.Add(prodNameLabel);
            this.prodSuppGroupBox.Controls.Add(this.prodSuppListLabel);
            this.prodSuppGroupBox.Controls.Add(this.prodSuppListBox);
            this.prodSuppGroupBox.Location = new System.Drawing.Point(45, 345);
            this.prodSuppGroupBox.Name = "prodSuppGroupBox";
            this.prodSuppGroupBox.Size = new System.Drawing.Size(455, 251);
            this.prodSuppGroupBox.TabIndex = 37;
            this.prodSuppGroupBox.TabStop = false;
            this.prodSuppGroupBox.Text = "Products and Suppliers Details";
            // 
            // prodSuppListErrorMessage
            // 
            this.prodSuppListErrorMessage.AutoSize = true;
            this.prodSuppListErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.prodSuppListErrorMessage.Location = new System.Drawing.Point(19, 232);
            this.prodSuppListErrorMessage.Name = "prodSuppListErrorMessage";
            this.prodSuppListErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.prodSuppListErrorMessage.TabIndex = 35;
            // 
            // styleLabel
            // 
            this.styleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.styleLabel.BackColor = System.Drawing.Color.LightCyan;
            this.styleLabel.Location = new System.Drawing.Point(25, 9);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(498, 672);
            this.styleLabel.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Add and Modify New Packages";
            // 
            // AddEditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.packageGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.prodSuppGroupBox);
            this.Controls.Add(this.styleLabel);
            this.Name = "AddEditPackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditPackageForm";
            this.Load += new System.EventHandler(this.AddEditPackageForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.packageGroupBox.ResumeLayout(false);
            this.packageGroupBox.PerformLayout();
            this.prodSuppGroupBox.ResumeLayout(false);
            this.prodSuppGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox prodSuppListBox;
        private System.Windows.Forms.Label prodSuppListLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delectProductToolStripMenuItem;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.BindingSource productsSuppliersBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.BindingSource supplierBindingSource2;
        private System.Windows.Forms.BindingSource productsSupplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox packageGroupBox;
        private System.Windows.Forms.GroupBox prodSuppGroupBox;
        private System.Windows.Forms.Label pkgDescripErrorMessage;
        private System.Windows.Forms.Label pkgCommissionErrorMessage;
        private System.Windows.Forms.Label pkgBasePriceErrorMessage;
        private System.Windows.Forms.Label pkgEndDateErrorMessage;
        private System.Windows.Forms.Label pkgStartDateErrorMessage;
        private System.Windows.Forms.Label pkgErrorMessage;
        private System.Windows.Forms.Label prodSuppListErrorMessage;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label label2;
    }
}