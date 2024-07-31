using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobile_Retail_Shop
{
    public partial class NewShop : UserControl
    {
        public NewShop()
        {
            InitializeComponent();
            LoadShopOwner();
        }


        private void LoadShopOwner()
        {
            string error, query = "SELECT ID, Name FROM [User Information] WHERE [User Type] = 2";


            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: NewShop Function: LoadShopOwner \nError: {error}");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                owner_cb.DisplayMember = "No Owner";
                submit_btn.Enabled = false;
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                owner_cb.Text = row["Name"].ToString();
                owner_cb.Tag = row["ID"];
            }

            owner_cb.DisplayMember = "Select Owner";
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_tb.Text))
            {
                MessageBox.Show("Fill up the name");
                name_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("Fill up the email");
                email_tb.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(phone_number_tb.Text))
            {
                MessageBox.Show("Fill up the phone Numvber");
                phone_number_tb.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(city_tb.Text))
            {
                MessageBox.Show("Fill the city");
                city_tb.Focus();
                return;
            }

            if (owner_cb.DisplayMember == "No Owner")
            {
                MessageBox.Show("First you resister a owner");
                return;
            }

            if (owner_cb.Text == "Select Owner")
            {
                MessageBox.Show("Select a owner");
                return ;
            }

            if (owner_cb.SelectedItem is Guna2CheckBox selectedItem)
            {
                int ownerId = (int)selectedItem.Tag;

                string error, query = $@"INSERT INTO [Shop Information] (Name, Email, [Phone Number], City, [User ID])
                              VALUES('{name_tb.Text}', '{email_tb.Text}', '{phone_number_tb.Text}', '{city_tb.Text}', {ownerId})";

                DataBase dataBase = new DataBase();
                DataTable dataTable = dataBase.DataAccess(query, out error);


                if (!dataTable.Rows.Contains(error))
                {
                    MessageBox.Show($"Class name: NewShop Function: LoadShopOwner \nError: {error}");
                    return;
                }
            }
        }
    }
}
