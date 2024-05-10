using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_World.Packages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Travel_World
{
    public partial class AgencieHomePage : Form
    {
        public string places, hotel, picloc, Agencies_Name, Agencies_Email, Agencies_Address, Agencies_picloc;
        public int capacity, price, duration, p_id = 0, Agencies_phone, c_id, A_id = 0;
        string username, password;
        
        public AgencieHomePage()
        {
            InitializeComponent();
        }
        
        public AgencieHomePage(string name, string pass)
        {
            InitializeComponent();
            username = name;

            password = pass;

            //finding Agencies id.
            Connect c1 = new Connect();
            var reader = c1.Connection("select * from AgenciesDetails where Username = '" + username + "' and Password = '" + password + "'");
          
            //finding all the information of an agencies have 
           

            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if(reader.GetName(i) == "A_id")
                        {
                            A_id=Convert.ToInt32(reader.GetValue(i));   
                        }
                       else if (reader.GetName(i) == "Agencies_Name")
                        {
                            Agencies_Name = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "Email")
                        {
                            Agencies_Email = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "Address")
                        {
                            Agencies_Address = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "Phone")
                        {
                            Agencies_phone = Convert.ToInt32(reader[i]);
                        }
                        else if (reader.GetName(i) == "picloc")
                        {
                            Agencies_picloc = Convert.ToString(reader[i]);
                        }



                    }
                }

            }
            c1.close();
        
            // finding how many package already created by this A_id
            reader = c1.Connection("select * from Package where A_id='" + A_id + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                       
                         if (reader.GetName(i) == "p_price")
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
                            picloc = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_id")
                        {
                            p_id = Convert.ToInt32(reader[i]);
                        }


                    }
                    Package p1 = new Package(places, capacity, price, duration, hotel, picloc, p_id);

                    flowLayoutpanel.Controls.Add(p1);

                }
                c1.close();
            }
        }
        private void BackL_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }



        private void addpackageB_Click(object sender, EventArgs e)
        {


            PackageDetails details = new PackageDetails();
            details.Visible = false;
            //showing Package usercontrol as a Dialog .. to puse until it(package) take the input.
            if (details.ShowDialog() == DialogResult.OK)
            {


                Connect c1 = new Connect();
                //finding how many package i have 
                var reader = c1.Connection("SELECT COUNT(*) FROM Package");
                int rowCount = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        rowCount = reader.GetInt32(0);

                    }
                    c1.close();
                }

                //finding last user p_id and increasing p_id for new user.
                if (rowCount > 0)
                {
                    reader = c1.Connection("SELECT MAX(p_id) FROM Package;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            p_id = reader.GetInt32(0) + 1;

                        }
                        c1.close();
                    }


                }
                else
                {
                    p_id++;
                }
                Package p1 = new Package(PackageDetails.places, PackageDetails.capacity, PackageDetails.price, PackageDetails.duration, PackageDetails.hotel, PackageDetails.picloc, p_id);

                flowLayoutpanel.Controls.Add(p1);
                //inserting data into database;
                var value = c1.Connection("insert into Package(p_id,A_id,p_country,p_hotel,p_price,p_capacity,p_duration,picloc) values('" + p_id + "','" + A_id + "','" + PackageDetails.places + "','" + PackageDetails.hotel + "','" + PackageDetails.price + "','" + PackageDetails.capacity + "','" + PackageDetails.duration + "','" + PackageDetails.picloc + "')");
            }





        }

        private void accountB_Click(object sender, EventArgs e)
        {
            
            Agencies_account agencies_Account = new Agencies_account(A_id, username, password, Agencies_Name, Agencies_Email, Agencies_phone, Agencies_Address, Agencies_picloc);

           
            agencies_Account.ShowDialog();


        }

        private void bid_for_a_offer_Click(object sender, EventArgs e)
        {
            flowLayoutpanel.Controls.Clear();
            Connect con = new Connect();
            var reader = con.Connection("select * from customoffer");
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
                            picloc = Convert.ToString(reader[i]);
                        }
                        
                        else if (reader.GetName(i) == "c_id")
                        {
                            c_id = Convert.ToInt32(reader[i]);
                        }

                    }
                    Package_for_Customer_Home_Page pac = new Package_for_Customer_Home_Page(places, picloc, capacity, price, duration, p_id, password, c_id, A_id, "agencies_bid");

                    flowLayoutpanel.Controls.Add(pac);

                }

                con.close();

            }
        }

        private void homeB_Click(object sender, EventArgs e)
        {
            flowLayoutpanel.Controls.Clear();
           // finding how many package already created by this A_id
           Connect c1 = new Connect();
         var   reader = c1.Connection("select * from Package where A_id='" + A_id + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        
                        if (reader.GetName(i) == "p_price")
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
                            picloc = Convert.ToString(reader[i]);
                        }
                        else if (reader.GetName(i) == "p_id")
                        {
                            p_id = Convert.ToInt32(reader[i]);
                        }


                    }
                    Package p1 = new Package(places, capacity, price, duration, hotel, picloc, p_id);

                    flowLayoutpanel.Controls.Add(p1);

                }
                c1.close();
            }
        }
    }
}
