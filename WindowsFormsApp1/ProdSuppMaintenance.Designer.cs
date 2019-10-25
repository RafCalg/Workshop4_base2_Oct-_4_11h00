namespace WindowsFormsApp1
{
    partial class ProdSuppMaintenance
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
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.supComboBox = new System.Windows.Forms.ComboBox();
            this.prodAddButton = new System.Windows.Forms.Button();
            this.prodEditButton = new System.Windows.Forms.Button();
            this.suppAddButton = new System.Windows.Forms.Button();
            this.suppEditButton = new System.Windows.Forms.Button();
            this.oKButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodComboBox
            // 
            this.prodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(73, 85);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(117, 21);
            this.prodComboBox.TabIndex = 0;
            this.prodComboBox.SelectedIndexChanged += new System.EventHandler(this.prodComboBox_SelectedIndexChanged);
            // 
            // supComboBox
            // 
            this.supComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supComboBox.FormattingEnabled = true;
            this.supComboBox.Location = new System.Drawing.Point(241, 85);
            this.supComboBox.Name = "supComboBox";
            this.supComboBox.Size = new System.Drawing.Size(284, 21);
            this.supComboBox.TabIndex = 4;
            // 
            // prodAddButton
            // 
            this.prodAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodAddButton.Location = new System.Drawing.Point(73, 130);
            this.prodAddButton.Name = "prodAddButton";
            this.prodAddButton.Size = new System.Drawing.Size(117, 23);
            this.prodAddButton.TabIndex = 1;
            this.prodAddButton.Text = "Add Product";
            this.prodAddButton.UseVisualStyleBackColor = true;
            this.prodAddButton.Click += new System.EventHandler(this.prodAddButton_Click);
            // 
            // prodEditButton
            // 
            this.prodEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodEditButton.Location = new System.Drawing.Point(73, 177);
            this.prodEditButton.Name = "prodEditButton";
            this.prodEditButton.Size = new System.Drawing.Size(117, 23);
            this.prodEditButton.TabIndex = 2;
            this.prodEditButton.Text = "Edit Product";
            this.prodEditButton.UseVisualStyleBackColor = true;
            this.prodEditButton.Click += new System.EventHandler(this.prodEditButton_Click);
            // 
            // suppAddButton
            // 
            this.suppAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppAddButton.Location = new System.Drawing.Point(330, 130);
            this.suppAddButton.Name = "suppAddButton";
            this.suppAddButton.Size = new System.Drawing.Size(117, 23);
            this.suppAddButton.TabIndex = 5;
            this.suppAddButton.Text = "Add Supplier";
            this.suppAddButton.UseVisualStyleBackColor = true;
            this.suppAddButton.Click += new System.EventHandler(this.suppAddButton_Click);
            // 
            // suppEditButton
            // 
            this.suppEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppEditButton.Location = new System.Drawing.Point(330, 177);
            this.suppEditButton.Name = "suppEditButton";
            this.suppEditButton.Size = new System.Drawing.Size(117, 23);
            this.suppEditButton.TabIndex = 6;
            this.suppEditButton.Text = "Edit Supplier";
            this.suppEditButton.UseVisualStyleBackColor = true;
            this.suppEditButton.Click += new System.EventHandler(this.suppEditButton_Click);
            // 
            // oKButton
            // 
            this.oKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oKButton.Location = new System.Drawing.Point(454, 239);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(71, 23);
            this.oKButton.TabIndex = 7;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = true;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add and Modify Products";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 275);
            this.label1.TabIndex = 9;
            // 
            // ProdSuppMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.suppEditButton);
            this.Controls.Add(this.prodEditButton);
            this.Controls.Add(this.suppAddButton);
            this.Controls.Add(this.prodAddButton);
            this.Controls.Add(this.supComboBox);
            this.Controls.Add(this.prodComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ProdSuppMaintenance";
            this.Text = "ProdSuppMaintenance";
            this.Load += new System.EventHandler(this.ProdSuppMaintenance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox prodComboBox;
        private System.Windows.Forms.ComboBox supComboBox;
        private System.Windows.Forms.Button prodAddButton;
        private System.Windows.Forms.Button prodEditButton;
        private System.Windows.Forms.Button suppAddButton;
        private System.Windows.Forms.Button suppEditButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}