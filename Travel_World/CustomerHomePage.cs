using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_World.Packages;
namespace Travel_World
{
    public partial class CustomerHomePage : Form
    {
        string username, password, places, hotel;
        public int capacity, price, duration, p_id = 0;
        int c_id = 0, Phone = 0, A_id = 0;
        string FirstName = "", SeconName = "", Email = "", BirthDate = "", Address = "", picloc = "";
        int allpackagedcalledfor1sttime = 0;
        public CustomerHomePage(string name, string pass)
        {
            InitializeComponent();
            username = name;

            password = pass;
            //call add package 
            Add_package(0, 0);

            // Finding all info about user.
            Connect c1 = new Connect();
            var reader = c1.Connection("select * from UserDetails where Username='" + username + "' AND Password='" + password + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "c_id")
                        {
                            c_id = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "FirstName")
                        {
                            FirstName = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "SeconName")
                        {
                            SeconName = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "Phone")
                        {
                            Phone = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "Email")
                        {
                            Email = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "Address")
                        {
                            Address = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "picloc")
                        {
                            picloc = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "BirthDate")
                        {
                            BirthDate = Convert.ToString(reader[i]);
                        }

                    }


                }
                c1.close();
            }



        }

        private void Add_package(int price1, int price2)
        {
            int p1 = price1, p2 = price2;
            string package_pic=" ";
            // finding all packages
            Connect c1 = new Connect();
            var reader = c1.Connection("select * from Package");
            if (allpackagedcalledfor1sttime != 0)
            {
                c1.close();
            }


            if (p1 >= 10000 && p2 <= 30000)
            {
                reader = c1.Connection("select * from Package where p_price between 10000 and 30000");

            }
            if (p1 >= 30000 && p2 <= 50000)
            {
                reader = c1.Connection("select * from Package where p_price between 30000 and 50000");

            }
            if (p1 >= 50000 && p2 <= 80000)
            {
                reader = c1.Connection("select * from Package where p_price between 50000 and 80000");

            }

            if (p1 >= 80000 && p2 <= 100000)
            {
                reader = c1.Connection("select * from Package where p_price between 80000 and 100000");

            }
            if (p1 >= 100000 && p2 <= 150000)
            {
                reader = c1.Connection("select * from Package where p_price between 100000 and 150000");

            }
            if (p1 >= 150000 && p2 <= 200000)
            {
                reader = c1.Connection("select * from Package where p_price between 150000 and 200000");

            }

            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "p_id")
                        {
                            p_id = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_price")
                        {
                            price = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_country")
                        {
                            places = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_capacity")
                        {
                            capacity = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_duration")
                        {
                            duration = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_hotel")
                        {
                            hotel = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "picloc")
                        {
                            package_pic = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "A_id")
                        {
                            A_id = Convert.ToInt32(reader[i]);
                        }

                    }
                    Package_for_Customer_Home_Page pac = new Package_for_Customer_Home_Page(places, package_pic, capacity, price, duration, p_id, password, c_id, A_id,"A");

                    customerflowLayoutPanel.Controls.Add(pac);

                }
                allpackagedcalledfor1sttime++;
                c1.close();

            }
        }

        private void BackL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void accountB_Click(object sender, EventArgs e)
        {

            Customer_Account customer_Account = new Customer_Account(c_id, Phone, FirstName, SeconName, Email, BirthDate, Address, picloc, password, username);
            customer_Account.ShowDialog();
        }

        private void filter_packageB_Click(object sender, EventArgs e)
        {
            //checking which box in checked

            if (CB1.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(10000, 30000);

            }
            if (checkBox2.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(30000, 50000);
            }
            if (checkBox3.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(50000, 80000);
            }
            if (checkBox4.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(80000, 100000);
            }
            if (checkBox5.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(100000, 150000);
            }
            if (checkBox6.Checked)
            {
                customerflowLayoutPanel.Controls.Clear();
                Add_package(150000, 200000);
            }
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            //if home button clicked all filter will removed and reinsert all packages
            customerflowLayoutPanel.Controls.Clear();
            string Package_picloc = " ";
            //Author gazi korbanul islam
            Connect c1 = new Connect();
            var reader = c1.Connection("select * from Package");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "p_id")
                        {
                            p_id = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_price")
                        {
                            price = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_country")
                        {
                            places = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_capacity")
                        {
                            capacity = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_duration")
                        {
                            duration = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_hotel")
                        {
                            hotel = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "picloc")
                        {
                            Package_picloc = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "A_id")
                        {
                            A_id = Convert.ToInt32(reader[i]);
                        }

                    }
                    Package_for_Customer_Home_Page pac = new Package_for_Customer_Home_Page(places, Package_picloc, capacity, price, duration, p_id, password, c_id, A_id,"A");

                    customerflowLayoutPanel.Controls.Add(pac);

                }

                c1.close();

            }


        }

        private void custompackageB_Click(object sender, EventArgs e)
        {
            string custompackagepic = " ";
           
           customOffrer c1= new customOffrer(c_id); 
            c1.ShowDialog();
            customerflowLayoutPanel.Controls.Clear();
            Connect con = new Connect();
            var reader = con.Connection("select * from customoffer where c_id='"+c_id+"'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "custom_id")
                        {
                            p_id = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "cp_price")
                        {
                            price = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "cp_country")
                        {
                            places = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "cp_capacity")
                        {
                            capacity = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "cp_duration")
                        {
                            duration = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "cp_hotel")
                        {
                            hotel = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "picloc")
                        {
                            custompackagepic = Convert.ToString(reader[i]);
                        }
                        

                    }
                    Package_for_Customer_Home_Page pac = new Package_for_Customer_Home_Page(places, custompackagepic, capacity, price, duration, p_id, password, c_id, 0,"me");

                    customerflowLayoutPanel.Controls.Add(pac);

                }

                con.close();

            }


        }
    }
}
