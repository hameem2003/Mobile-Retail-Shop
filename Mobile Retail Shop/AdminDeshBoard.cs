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
        private string id;
        public AdminDeshBoard()
        {
            InitializeComponent();
        }
        public AdminDeshBoard(string id ):this()
        {
            this.id = id;
        }
    }
    
}
