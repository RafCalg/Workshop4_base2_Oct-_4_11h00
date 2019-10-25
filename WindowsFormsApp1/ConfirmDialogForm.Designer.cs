namespace WindowsFormsApp1
{
    partial class ConfirmDialogForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packageInfolistBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prodSuppListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packageInfolistBox);
            this.groupBox1.Location = new System.Drawing.Point(113, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // packageInfolistBox
            // 
            this.packageInfolistBox.FormattingEnabled = true;
            this.packageInfolistBox.Location = new System.Drawing.Point(7, 20);
            this.packageInfolistBox.Name = "packageInfolistBox";
            this.packageInfolistBox.Size = new System.Drawing.Size(269, 108);
            this.packageInfolistBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prodSuppListBox);
            this.groupBox2.Location = new System.Drawing.Point(113, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products and Suppliers";
            // 
            // prodSuppListBox
            // 
            this.prodSuppListBox.FormattingEnabled = true;
            this.prodSuppListBox.Location = new System.Drawing.Point(7, 20);
            this.prodSuppListBox.Name = "prodSuppListBox";
            this.prodSuppListBox.Size = new System.Drawing.Size(269, 95);
            this.prodSuppListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(149, 412);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(293, 412);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(75, 23);
            this.declineButton.TabIndex = 3;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 588);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfirmDialogForm";
            this.Text = "Confirmation Dialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox packageInfolistBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox prodSuppListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button declineButton;
    }
}