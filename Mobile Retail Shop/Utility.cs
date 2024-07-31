using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Retail_Shop
{
    internal class Utility
    {
        public static void TogglePasswordVisibility(Guna2TextBox textBox, Guna2Button button)
        {
            if (textBox.PasswordChar != '●')
            {
                textBox.PasswordChar = '●';
                // textBox.UseSystemPasswordChar = false;
                button.Image = Properties.Resources.hide;
                return;
            }

            textBox.PasswordChar = '\0';
            // textBox.UseSystemPasswordChar = true;
            button.Image = Properties.Resources.show;
        }
    }
}
