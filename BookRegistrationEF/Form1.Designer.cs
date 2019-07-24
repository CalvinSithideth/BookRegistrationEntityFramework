namespace BookRegistrationEF
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
            this.CboCustomers = new System.Windows.Forms.ComboBox();
            this.CboBooks = new System.Windows.Forms.ComboBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboCustomers
            // 
            this.CboCustomers.FormattingEnabled = true;
            this.CboCustomers.Location = new System.Drawing.Point(13, 13);
            this.CboCustomers.Name = "CboCustomers";
            this.CboCustomers.Size = new System.Drawing.Size(121, 21);
            this.CboCustomers.TabIndex = 0;
            // 
            // CboBooks
            // 
            this.CboBooks.FormattingEnabled = true;
            this.CboBooks.Location = new System.Drawing.Point(13, 41);
            this.CboBooks.Name = "CboBooks";
            this.CboBooks.Size = new System.Drawing.Size(121, 21);
            this.CboBooks.TabIndex = 1;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(13, 69);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(121, 23);
            this.BtnAddCustomer.TabIndex = 2;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.CboBooks);
            this.Controls.Add(this.CboCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCustomers;
        private System.Windows.Forms.ComboBox CboBooks;
        private System.Windows.Forms.Button BtnAddCustomer;
    }
}

