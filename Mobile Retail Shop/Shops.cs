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
    public partial class Shops : UserControl
    {
        public Shops()
        {
            InitializeComponent();
            DataLoad();
        }


        private void DataLoad()
        {
            string error, query = "SELECT * FROM [Shop Information]";

            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name Shops Function Name DataLoad \n error: {error}");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                ShopList shopList = new ShopList(row["ID"].ToString(), row["Name"].ToString(), row["Email"].ToString(), row["Phone Number"].ToString(), row["Owner ID"];

            }
        }



        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
