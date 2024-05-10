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
    public partial class User_Info_Update : Form
    {
        string firstname, secondname, email, address, password, retypepassword, username, phone, Birthdate, picloc = "";
        int rowCount = 0, id = 0;
        public User_Info_Update(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            //cheaking any field empty ornot and password and retypr password same or not?
            if (firstnameTB.Text == "" || secondnameTB.Text == "" || emailTB.Text == "" || phoneTB.Text == "" || birthdateTB.Text == "" || addressTB.Text == "" || passwordTB.Text == "" || picloc == "")
            {
                if (passwordTB.Text != passwordretypeTB.Text)
                {
                    MessageBox.Show("Please Re-Type Password Correctly");
                }
                else if (phoneTB.Text.Length > 11)
                {
                    MessageBox.Show("Please Enter 11 number only");
                }
                else if (picloc == "")
                {
                    MessageBox.Show("Please select a profile picture");
                }
                else
                {
                    MessageBox.Show("Please Fill All Box");
                }
            }
            else
            {

                firstname = firstnameTB.Text;
                secondname = secondnameTB.Text;
                email = emailTB.Text;
                address = addressTB.Text;
                Birthdate = birthdateTB.Text;
                password = passwordTB.Text;
                retypepassword = passwordretypeTB.Text;
                username = usernameTB.Text;
                phone = phoneTB.Text;

                Connect c1 = new Connect();



                //checking same username exist or not.
                var Exist = c1.Connection("SELECT COUNT(*) FROM UserDetails Where Username='" + username + "' ");
                if (Exist.HasRows)
                {
                    while (Exist.Read())
                    {

                        rowCount = Exist.GetInt32(0);

                    }
                    c1.close();
                }

                if (rowCount > 0)
                {
                    MessageBox.Show("Username Exist.Please choose another");
                }
                else
                {
                    //inserting values in database and seting null 
                    var value = c1.Connection("Update UserDetails set FirstName='" + firstname + "',SeconName='" + secondname + "',Username='" + username + "',Email='" + email + "',Phone='" + phone + "', BirthDate= '" + Birthdate + "', Address='" + address + "',password='" + password + "',picloc='" + picloc + "' where c_id='" + id + "'");
                    c1.close();
                    firstnameTB.Text = "";
                    secondnameTB.Text = "";
                    emailTB.Text = "";
                    addressTB.Text = "";
                    birthdateTB.Text = "";
                    passwordTB.Text = "";
                    phoneTB.Text = "";
                    passwordretypeTB.Text = "";
                    usernameTB.Text = "";
                }
            }
        }

        private void chooseimageB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //  openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|jpg Files (*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picloc = openFileDialog1.FileName.ToString();
                customerpic.ImageLocation = picloc;

            }
        }
    }
}
