namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.deletePackageButton = new System.Windows.Forms.Button();
            this.modifyPackageButton = new System.Windows.Forms.Button();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.prodSuppMaintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPackageButton
            // 
            this.addPackageButton.BackColor = System.Drawing.Color.LightCyan;
            this.addPackageButton.Location = new System.Drawing.Point(73, 362);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(125, 23);
            this.addPackageButton.TabIndex = 1;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = false;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // deletePackageButton
            // 
            this.deletePackageButton.BackColor = System.Drawing.Color.LightCyan;
            this.deletePackageButton.Location = new System.Drawing.Point(218, 362);
            this.deletePackageButton.Name = "deletePackageButton";
            this.deletePackageButton.Size = new System.Drawing.Size(125, 23);
            this.deletePackageButton.TabIndex = 2;
            this.deletePackageButton.Text = "Delete Package";
            this.deletePackageButton.UseVisualStyleBackColor = false;
            this.deletePackageButton.Click += new System.EventHandler(this.deletePackageButton_Click);
            // 
            // modifyPackageButton
            // 
            this.modifyPackageButton.BackColor = System.Drawing.Color.LightCyan;
            this.modifyPackageButton.Location = new System.Drawing.Point(365, 362);
            this.modifyPackageButton.Name = "modifyPackageButton";
            this.modifyPackageButton.Size = new System.Drawing.Size(125, 23);
            this.modifyPackageButton.TabIndex = 3;
            this.modifyPackageButton.Text = "Modify Package";
            this.modifyPackageButton.UseVisualStyleBackColor = false;
            this.modifyPackageButton.Click += new System.EventHandler(this.modifyPackageButton_Click);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(WindowsFormsApp1.Package);
            // 
            // packageDataGridView
            // 
            this.packageDataGridView.AutoGenerateColumns = false;
            this.packageDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.packageDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.packageDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packageDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.packageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.packageDataGridView.DataSource = this.packageBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packageDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.packageDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.packageDataGridView.Location = new System.Drawing.Point(73, 119);
            this.packageDataGridView.Name = "packageDataGridView";
            this.packageDataGridView.Size = new System.Drawing.Size(993, 195);
            this.packageDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightCyan;
            this.exitButton.Location = new System.Drawing.Point(991, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.BackColor = System.Drawing.Color.LightCyan;
            this.mainFormLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabel.Location = new System.Drawing.Point(323, 58);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(500, 45);
            this.mainFormLabel.TabIndex = 6;
            this.mainFormLabel.Text = "Travel Package Management System";
            this.mainFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodSuppMaintButton
            // 
            this.prodSuppMaintButton.BackColor = System.Drawing.Color.LightCyan;
            this.prodSuppMaintButton.Location = new System.Drawing.Point(631, 347);
            this.prodSuppMaintButton.Name = "prodSuppMaintButton";
            this.prodSuppMaintButton.Size = new System.Drawing.Size(192, 53);
            this.prodSuppMaintButton.TabIndex = 3;
            this.prodSuppMaintButton.Text = "Products and Suppliers Maintenance";
            this.prodSuppMaintButton.UseVisualStyleBackColor = false;
            this.prodSuppMaintButton.Click += new System.EventHandler(this.prodSuppMaintButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.travel2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 446);
            this.Controls.Add(this.mainFormLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.packageDataGridView);
            this.Controls.Add(this.prodSuppMaintButton);
            this.Controls.Add(this.modifyPackageButton);
            this.Controls.Add(this.deletePackageButton);
            this.Controls.Add(this.addPackageButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button deletePackageButton;
        private System.Windows.Forms.Button modifyPackageButton;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.DataGridView packageDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button prodSuppMaintButton;
    }
}

