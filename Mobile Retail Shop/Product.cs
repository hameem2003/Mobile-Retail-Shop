using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class Product : UserControl
    {
        private bool newProduct;
        private string ID;
        public Product()
        {
            InitializeComponent();
        }

        public Product(bool newProduct = false, string ID = null)
        {
            this.newProduct = newProduct;
            this.ID = ID;

            Design();
        }

        public void Design()
        {
            if (newProduct)
                perform_button.Text = "Add";
            else if (ID != null)
                perform_button.Text = "Back";
        }

        private void Resister()
        {
            //if ()
        }

        private void perform_button_Click(object sender, EventArgs e)
        {
            if (newProduct)
                Resister();
        }

        private void choose_picture_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
