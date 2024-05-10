using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Travel_World
{
    public partial class Customer_Account : Form
    {
        int c_id, Phone;
        string FirstName, SeconName, Email, BirthDate, Address, picloc, username, password;
        public Customer_Account(int c_id, int Phone, string FirstName, string SeconName, string Email, string BirthDate, string Address, string picloc, string password, string username)
        {
            InitializeComponent();
            this.c_id = c_id;
            this.Phone = Phone;
            this.FirstName = FirstName;
            this.SeconName = SeconName;
            this.Email = Email;
            this.BirthDate = BirthDate;
            this.Address = Address;
            this.picloc = picloc;
            this.password = password;
            this.username = username;

        }

        private void Customer_Account_Load(object sender, EventArgs e)
        {
            full_nameL.Text = "Full Name: " + FirstName + " " + SeconName;
            user_nameL.Text = "User Name: " + username;
            emailL.Text = "Email: " + Email;
            customer_idL.Text = "Your ID: " + c_id;
            addressL.Text = "Address: " + Address;
            phoneL.Text = "Phone: " + Phone;
            birth_dateL.Text = "Birth Date: " + BirthDate;
            user_pic.ImageLocation = picloc;

        }

        private void change_passwordB_Click(object sender, EventArgs e)
        {
            string user = "Customer";
            ChangePass changePass = new ChangePass(c_id,password, user);
            changePass.ShowDialog   ();
        }
    }
}
