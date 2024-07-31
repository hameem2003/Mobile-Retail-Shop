namespace Mobile_Retail_Shop
{
    partial class ShopOwner
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
            this.left_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.data_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(174, 450);
            this.left_panel.TabIndex = 0;
            // 
            // data_panel
            // 
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(174, 0);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(626, 450);
            this.data_panel.TabIndex = 1;
            // 
            // ShopOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.left_panel);
            this.Name = "ShopOwner";
            this.Text = "ShopOwner";
            this.Load += new System.EventHandler(this.ShopOwner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel left_panel;
        private Guna.UI2.WinForms.Guna2Panel data_panel;
    }
}