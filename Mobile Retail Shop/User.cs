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
    public partial class User : UserControl
    {
        private Users users;
        public User()
        {
            InitializeComponent();
        }

        public User(string userId, string userName, string userEmail, string userPhoneNumber, string city, string password, int userType, Users users) : this()
        {
            this.Tag = new UserInfo { Id = userId, Name = userName, Email = userEmail, PhoneNumber = userPhoneNumber, City = city,  Password = password, UserType = userType };
            name.Text = userName;
            email.Text = userEmail; 
            phone_number.Text = userPhoneNumber;

            this.users = users;
            this.Click += new System.EventHandler(this.user_btn_Click);
        }


        // string userId, string userName, string userEmail, string userPhoneNumber, string password, int userType)

        private void user_btn_Click(object sender, EventArgs e)
        {
            UserInfo tag = (UserInfo)this.Tag;
            users.profile(userId: tag.Id, userName: tag.Name, userEmail: tag.Email, userPhoneNumber: tag.PhoneNumber, userCity: tag.City, userPassword: tag.Password, userType: tag.UserType);
        }
    }
}
