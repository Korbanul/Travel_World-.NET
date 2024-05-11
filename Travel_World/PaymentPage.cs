using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_World.Packages;

namespace Travel_World
{
    public partial class PaymentPage : Form
    {
        int c_id, payment_id = 0, package_id, agencies_id = 0, capacity, price, duration = 0, Payment_id = 0;
        double Admin_balance = 0;
        string places, picloc, userpassword, Time_date, payment_method;


        Connect c1 = new Connect();
        public PaymentPage(int c_id, int p_id, int amount, int duration, string places, string picloc, int capacity, string password, int A_id)
        {
            InitializeComponent();
            this.c_id = c_id;
            this.package_id = p_id;
            this.price = amount;
            this.duration = duration;
            this.places = places;
            this.picloc = picloc;
            this.capacity = capacity;
            this.userpassword = password;
            this.agencies_id = A_id;
            var reader = c1.Connection("select * from Package where p_id='" + package_id + "'");
            c1.close();
            Package_for_Customer_Home_Page p1 = new Package_for_Customer_Home_Page(places, picloc, capacity, price, duration, package_id);
            selectedpackageP.Controls.Add(p1);


        }

        private void confirmB_Click(object sender, EventArgs e)
        {


            int rowCount = 0;
            if (payment_optionL.Text != "")
            {
                if (passwordTB.Text == userpassword)
                {
                    //finding how many Transaction already i have 
                    var reader = c1.Connection("SELECT COUNT(*) FROM TransactionDetails");

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
                        reader = c1.Connection("SELECT MAX(Payment_id) FROM TransactionDetails;");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                Payment_id = reader.GetInt32(0) + 1;

                            }
                            c1.close();
                        }


                    }
                    else
                    {
                        Payment_id++;
                    }


                    passwordTB.Text = "";
                    MoborAccnumberTB.Text = "";
                    //calculating commitions from package price.
                    Admin_balance = (price * 0.1);
                    var date = DateTime.Now.Date;
                    //picking time and date from system
                    string timedate = DateTime.Now.ToShortTimeString() + DateTime.Now.ToShortDateString();
                    // inserting all data into TransactionDetails database
                    var vlaue = c1.Connection("insert into TransactionDetails(Payment_id,Payment_date,Customer_id, Agencies_id ,Package_id,Amount,Payment_Method) Values ('" + Payment_id + "','" + timedate + "','" + c_id + "','" + agencies_id + "','" + package_id + "','" + price + "','" + payment_method + "')");
                    c1.close();

                    //inserting new balance in the database
                    c1.Connection("UPDATE Admin SET Balance =Balance+'" + Admin_balance + "' WHERE Password='s';");
                    c1.close();
                    MessageBox.Show("Payment Susscessful");
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Please Select Payment getway First");
            }


        }

        private void bkashB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:Bkash";
            payment_method = "Bkash";
        }

        private void rocketB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:Rocket";
            payment_method = "Rocket";

        }

        private void nagadB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:Nagad";
            payment_method = "Nagad";

        }

        private void ucbB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:UCB Bank";
            payment_method = "UCB Bank";

        }

        private void alarafaB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:Alarafa Bank";
            //Author Gazi Korbanul islam
            payment_method = "Alarafa Bank";
          

        }

        private void cityB_Click(object sender, EventArgs e)
        {
            payment_optionL.Text = "Selected Payment option:CityBank";
            payment_method = "CityBank";

        }

        private void BackL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
