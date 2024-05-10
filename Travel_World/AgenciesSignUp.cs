using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_World
{
    public partial class AgenciesSignUp : Form
    {
        public AgenciesSignUp()
        {
            InitializeComponent();
        }
        string picloc;
        private void signupB_Click(object sender, EventArgs e)
        {
            if (agenciesnameTB.Text == "" || emailTB.Text == "" || phoneTB.Text == "" || addressTB.Text == "" || passwordTB.Text == ""||picloc=="")
            {
                if (passwordTB.Text != passwordretypeTB.Text)
                {
                    MessageBox.Show("Please Re-Type Password Correctly");
                }
                else if (phoneTB.Text.Length > 11)
                {
                    MessageBox.Show("Please Enter 11 number only");
                }
                else
                {
                    MessageBox.Show("Please Fill All Box");
                }
            }
            else
            {
                string Name = agenciesnameTB.Text; ;
                string email = emailTB.Text;
                int phone = int.Parse(phoneTB.Text);
                string address = addressTB.Text;
                string pass = passwordTB.Text, username = usernameTB.Text;
                int A_id = 0, rowCount = 0;
                Connect c1 = new Connect();
                //finding how many user i have 
                var reader = c1.Connection("SELECT COUNT(*) FROM AgenciesDetails");

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
                    reader = c1.Connection("SELECT MAX(A_id) FROM AgenciesDetails;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            A_id = reader.GetInt32(0) + 1;

                        }
                        c1.close();
                    }


                }
                else
                {
                    A_id++;
                }
                //checking same username exist or not.
                var Exist = c1.Connection("SELECT COUNT(*) FROM AgenciesDetails Where Username='" + username + "' ");
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
                    var value = c1.Connection("insert into AgenciesDetails(Agencies_Name,Email,Phone,Address,password,Username,A_id,picloc) Values('" + Name + "','" + email + "','" + phone + "','" + address + "','" + pass + "','" + username + "','" + A_id + "','"+picloc+"')");
                    c1.close();
                    agenciesnameTB.Text = "";
                    emailTB.Text = "";
                    phoneTB.Text = "";
                    addressTB.Text = "";
                    passwordTB.Text = "";
                    passwordretypeTB.Text = "";
                    usernameTB.Text = "";
                }
            }


        }


        private void BackL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AgenciesSignUp_Load(object sender, EventArgs e)
        {

        }

        private void agenciessignupexitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
