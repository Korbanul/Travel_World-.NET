using System.Data.SqlClient;

namespace Travel_World
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginexitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signuppageB_Click(object sender, EventArgs e)
        {
            //cheaking whick radio button is selected
            if (customerRB.Checked)
            {
                CustomerSignUp customerSignUp1 = new CustomerSignUp();
                customerSignUp1.Show();
                this.Hide();
            }
            else if (agenciesRB.Checked)
            {
                AgenciesSignUp agencies1 = new AgenciesSignUp();
                agencies1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select User Type Without Admin");
            }
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            //cheaking username and password matches or not for specific user
            if (adminRB.Checked)
            {
                
                string username=usernameTB.Text,password= passwordTB.Text;

                Connect con = new Connect();
                var reader = con.Connection("select Uname from Admin where Uname='"+username+"' AND Password='"+password+"'");
                string value=null;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        value = reader.GetString(0);
                       
                    }
                }

                
                if(value==username)
                {
                    AdminDashbord adminDashbord = new AdminDashbord();
                    adminDashbord.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Input");
                }
               
            }
            else if (agenciesRB.Checked)
            {
                string username = usernameTB.Text, password = passwordTB.Text;

                Connect con = new Connect();
                var reader = con.Connection("select Username from AgenciesDetails where Username='" + username + "' AND Password='" + password + "'");
                string value = null;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        value = reader.GetString(0);

                    }
                }

                if (value == username)
                {
                    //passing username and password to home page for showing in account
                    AgencieHomePage agencieHomePage = new AgencieHomePage(username, password);
                    agencieHomePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Input");
                }

               
            
        }else if(customerRB.Checked)
            {
                string username = usernameTB.Text, password = passwordTB.Text;

                Connect con = new Connect();
                var reader = con.Connection("select Username from UserDetails where Username='" + username + "' AND Password='" + password + "'");
                string value = null;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        value = reader.GetString(0);

                    }
                }

                if (value == username)
                {
                    //passing username and password to home page for showing in account
                   CustomerHomePage customerHomePage = new CustomerHomePage(username,password);
                    customerHomePage.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Wrong Input");
                }

               
            }
            else
            {
                MessageBox.Show("Please Select User Type.");
            }

        }
    }
}
