using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mobile_Retail_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("fill the email");
                email_tb.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("fill the password");
                password_tb.Focus();
                return;
            }
            string query = $"SELECT TOP  1  * FROM [User Information] WHERE [Email] = '{email_tb.Text}' AND [Password] = '{password_tb.Text}'";

            DataBase dataBase = new DataBase();
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            // If error is not empty that means something is wrong
            // So, user requst is not valid for next 
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: loginPage function: Login, error: {error}");
                return;
            }

            // If no data found in database based on email and password
            // So, user requst is not valid for next 
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid email or password");
                return;

            }
            if (dataTable.Rows[0]["User Type"].ToString() == "1")
            {
                AdminDeshBoard adminDeshBoard = new AdminDeshBoard(dataTable.Rows[0]["ID"].ToString());
                this.Hide();
                adminDeshBoard.Show();

            }


            if (dataTable.Rows[0]["User Type"].ToString() == "2")
            {
                ShopOwner shopOwner = new ShopOwner(dataTable.Rows[0]["ID"].ToString());
                this.Hide();
                shopOwner.Show();
            }
        }
    }
}
