namespace Mobile_Retail_Shop
{
    partial class User
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phone_number = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(41, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Name: ";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Location = new System.Drawing.Point(41, 48);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(28, 15);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // phone_number
            // 
            this.phone_number.BackColor = System.Drawing.Color.Transparent;
            this.phone_number.Location = new System.Drawing.Point(41, 69);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(74, 15);
            this.phone_number.TabIndex = 0;
            this.phone_number.Text = "Phone Number";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "User";
            this.Size = new System.Drawing.Size(346, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel name;
        private Guna.UI2.WinForms.Guna2HtmlLabel email;
        private Guna.UI2.WinForms.Guna2HtmlLabel phone_number;
    }
}
