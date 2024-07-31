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

namespace Mobile_Retail_Shop
{
    public partial class AdminDeshBoard : Form
    {
        public static AdminDeshBoard obj;
        private string id;
        public AdminDeshBoard()
        {
            InitializeComponent();
        }
        public AdminDeshBoard(string id ):this()
        {
            this.id = id;
        }

        private void AdminDeshBoard_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        public static AdminDeshBoard Instance
        {
            get
            {
                if (obj == null) 
                    obj = new AdminDeshBoard();

                return obj;
            }
        }

        public Guna2Panel panelContainer
        {
            get { return data_panel; }
            set { data_panel = value; }

        }

        private void new_admin_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewUser newAdmin = new NewUser(1);
            newAdmin.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newAdmin);
        }

       

        private void new_owner_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewUser newAdmin = new NewUser(2);
            newAdmin.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newAdmin);
        }

        private void new_shop_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewShop newShop = new NewShop();
            newShop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newShop);
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
             
        }
    }
    
}
