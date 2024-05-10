using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_World
{
    public partial class CustomerSignUp : Form
    {
        string firstname, secondname, email, address, Birthdate, password, retypepassword, username, phone, picloc="";
        int rowCount = 0, c_id = 0;


        public CustomerSignUp()
        {
            InitializeComponent();
        }
        private void signupB_Click(object sender, EventArgs e)
        {
            //cheaking any field empty ornot and password and retypr password same or not?
            if (firstnameTB.Text == "" || secondnameTB.Text == "" || emailTB.Text == "" || phoneTB.Text == "" || birthdateTB.Text == "" || addressTB.Text == "" || passwordTB.Text == ""||picloc=="")
            {
                if (passwordTB.Text != passwordretypeTB.Text)
                {
                    MessageBox.Show("Please Re-Type Password Correctly");
                }
                else if (phoneTB.Text.Length > 11)
                {
                    MessageBox.Show("Please Enter 11 number only");
                }else if(picloc=="")
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

                //finding how many user i have 
                var reader = c1.Connection("SELECT COUNT(*) FROM UserDetails");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        rowCount = reader.GetInt32(0);

                    }
                    c1.close();
                }

                //finding last user c_id and increasing c_id for new user.
                if (rowCount > 0)
                {
                    reader = c1.Connection("SELECT MAX(c_id) FROM UserDetails;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            c_id = reader.GetInt32(0) + 1;

                        }
                        c1.close();
                    }


                }
                else
                {
                    c_id++;
                }
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
                    var value = c1.Connection("insert into UserDetails(FirstName,SeconName,Username,Email,Phone,BirthDate,Address,password,c_id,picloc) VALUES('" + firstname + "','" + secondname + "','" + username + "','" + email + "','" + phone + "','" + Birthdate + "','" + address + "','" + password + "','" + c_id + "','"+picloc+"')");
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
        private void customersignupexitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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
