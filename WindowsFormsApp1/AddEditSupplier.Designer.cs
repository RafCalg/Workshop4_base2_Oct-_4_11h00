namespace WindowsFormsApp1
{
    partial class AddEditSupplier
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
            this.newSuppLabel = new System.Windows.Forms.Label();
            this.addSuppLierButton = new System.Windows.Forms.Button();
            this.newSuppIDLabel = new System.Windows.Forms.Label();
            this.newSuppIDTextBox = new System.Windows.Forms.TextBox();
            this.oKButton = new System.Windows.Forms.Button();
            this.newSuppTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newSuppLabel
            // 
            this.newSuppLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newSuppLabel.AutoSize = true;
            this.newSuppLabel.BackColor = System.Drawing.Color.LightCyan;
            this.newSuppLabel.Location = new System.Drawing.Point(45, 135);
            this.newSuppLabel.Name = "newSuppLabel";
            this.newSuppLabel.Size = new System.Drawing.Size(70, 13);
            this.newSuppLabel.TabIndex = 0;
            this.newSuppLabel.Text = "New Supplier";
            // 
            // addSuppLierButton
            // 
            this.addSuppLierButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addSuppLierButton.Location = new System.Drawing.Point(345, 194);
            this.addSuppLierButton.Name = "addSuppLierButton";
            this.addSuppLierButton.Size = new System.Drawing.Size(89, 23);
            this.addSuppLierButton.TabIndex = 3;
            this.addSuppLierButton.Text = "Add Supplier";
            this.addSuppLierButton.UseVisualStyleBackColor = true;
            this.addSuppLierButton.Click += new System.EventHandler(this.addSuppLierButton_Click);
            // 
            // newSuppIDLabel
            // 
            this.newSuppIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newSuppIDLabel.AutoSize = true;
            this.newSuppIDLabel.BackColor = System.Drawing.Color.LightCyan;
            this.newSuppIDLabel.Location = new System.Drawing.Point(45, 85);
            this.newSuppIDLabel.Name = "newSuppIDLabel";
            this.newSuppIDLabel.Size = new System.Drawing.Size(84, 13);
            this.newSuppIDLabel.TabIndex = 3;
            this.newSuppIDLabel.Text = "New Supplier ID";
            // 
            // newSuppIDTextBox
            // 
            this.newSuppIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newSuppIDTextBox.Location = new System.Drawing.Point(170, 78);
            this.newSuppIDTextBox.Name = "newSuppIDTextBox";
            this.newSuppIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.newSuppIDTextBox.TabIndex = 1;
            this.newSuppIDTextBox.TextChanged += new System.EventHandler(this.newSuppIDTextBox_TextChanged);
            // 
            // oKButton
            // 
            this.oKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oKButton.Location = new System.Drawing.Point(461, 194);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(89, 23);
            this.oKButton.TabIndex = 4;
            this.oKButton.Text = "Back";
            this.oKButton.UseVisualStyleBackColor = true;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // newSuppTextBox
            // 
            this.newSuppTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newSuppTextBox.Location = new System.Drawing.Point(170, 132);
            this.newSuppTextBox.Name = "newSuppTextBox";
            this.newSuppTextBox.Size = new System.Drawing.Size(390, 20);
            this.newSuppTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 263);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add and Edit Suppliers";
            // 
            // AddEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(609, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.newSuppIDTextBox);
            this.Controls.Add(this.newSuppIDLabel);
            this.Controls.Add(this.addSuppLierButton);
            this.Controls.Add(this.newSuppTextBox);
            this.Controls.Add(this.newSuppLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddEditSupplier";
            this.Text = "Add or Edit a Supplier";
            this.Load += new System.EventHandler(this.AddEditSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newSuppLabel;
        private System.Windows.Forms.Button addSuppLierButton;
        private System.Windows.Forms.Label newSuppIDLabel;
        private System.Windows.Forms.TextBox newSuppIDTextBox;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.TextBox newSuppTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}