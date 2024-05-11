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
    public partial class AdminDashbord : Form
    {

        int total_admin = 0, total_customer = 0, total_agencies = 0, total_packages = 0;
        int rowCount = 0;
        float Balance = 0;
        public AdminDashbord()
        {
            InitializeComponent();
            Connect c1 = new Connect();

            var reader = c1.Connection("Select Balance from Admin Where Uname='shanto'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "Balance")
                        {
                            //  Agencies_Name = Convert.ToString(reader[i]);aaaa
                            Balance = (float)Convert.ToDouble(reader[i]);
                        }
                    }
                }
            }
            balanceL.Text = "$" + Balance;
            c1.close();
            //finding how many user i have 
            reader = c1.Connection("SELECT COUNT(*) FROM UserDetails");



            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    rowCount = reader.GetInt32(0);

                }
                c1.close();
            }
            total_customer = rowCount;
            //finding how many Admin i have 
            reader = c1.Connection("SELECT COUNT(*) FROM Admin");

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    rowCount = reader.GetInt32(0);

                }
                c1.close();
            }
            total_admin = rowCount;

            //finding how many Agencies i have 
            reader = c1.Connection("SELECT COUNT(*) FROM AgenciesDetails");

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    rowCount = reader.GetInt32(0);

                }
                c1.close();
            }
            total_agencies = rowCount;

            //finding how many Package i have 
            reader = c1.Connection("SELECT COUNT(*) FROM Package");

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    rowCount = reader.GetInt32(0);

                }
                c1.close();
            }
            total_packages = rowCount;

        }

        private void BackL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void admindatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showallagenciesB_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();

            var reader = connect.Connection("select * from UserDetails");
            DataTable dt = new DataTable();

            dt.Load(reader);

            admindatagrid.DataSource = dt;
            admindatagrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();

            var reader = connect.Connection("select * from AgenciesDetails");
            DataTable dt = new DataTable();
            dt.Load(reader);

            admindatagrid.DataSource = dt;
            admindatagrid.Refresh();
        }

        private void showalladminsB_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();

            var reader = connect.Connection("select * from Admin");
            DataTable dt = new DataTable();
            dt.Load(reader);

            admindatagrid.DataSource = dt;
            admindatagrid.Refresh();
        }

        private void showallpackage_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();

            var reader = connect.Connection("select * from Package");
            DataTable dt = new DataTable();
            dt.Load(reader);

            admindatagrid.DataSource = dt;
            admindatagrid.Refresh();
        }

        private void AdminDashbord_Load(object sender, EventArgs e)
        {
            total_customerL.Text = Convert.ToString(total_customer);
            totaladminL.Text = Convert.ToString(total_admin);
            total_agenciesL.Text = Convert.ToString(total_agencies);
            total_packagesL.Text = Convert.ToString(total_packages);
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(searchbox.Text);

            Connect connect = new Connect();
            if (adminRB.Checked)
            {
                var reader = connect.Connection("select * from Admin Where Admin_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
                //MessageBox.Show("Cannot Delete a Admin");
            }
            else if (customerRB.Checked)
            {
                var reader = connect.Connection("select * from UserDetails Where c_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
            }
            else if (agenciesRB.Checked)
            {
                var reader = connect.Connection("select * from AgenciesDetails Where A_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
            }
            else if (packageRB.Checked)
            {
                //GAZI KORBANUL ISLAM
                var reader = connect.Connection("select * from Package Where p_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
            }else if(transactionRB.Checked)
            {
                var reader = connect.Connection("select * from TransactionDetails Where Payment_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
            }else if(custompackageRB.Checked)
            {
                var reader = connect.Connection("select * from customoffer Where custom_id='" + id + "'");
                DataTable dt = new DataTable();
                dt.Load(reader);
                admindatagrid.DataSource = dt;
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (adminRB.Checked)
            {

                MessageBox.Show("Cannot Delete a Admin");
            }
            else if (customerRB.Checked || agenciesRB.Checked || packageRB.Checked && searchbox.Text != "")
            {
                int id = Convert.ToInt32(searchbox.Text);
                Connect connect = new Connect();

                if (customerRB.Checked)
                {
                    var reader = connect.Connection("DELETE FROM UserDetails Where c_id='" + id + "'");
                    MessageBox.Show("Customer Delete done");
                }
                else if (agenciesRB.Checked)
                {
                    var reader = connect.Connection("DELETE FROM AgenciesDetails Where A_id='" + id + "'");
                    MessageBox.Show("Agencie Delete done");
                }
                else if (packageRB.Checked)
                {
                    var reader = connect.Connection("DELETE FROM Package Where p_id='" + id + "'");
                    MessageBox.Show("Package Delete done");
                }else if(transactionRB.Checked)
                {
                    var reader = connect.Connection("DELETE FROM TransactionDetails Where Payment_id='" + id + "'");
                    MessageBox.Show("Transaction Delete done");
                }else if(customerRB.Checked)
                {
                    var reader = connect.Connection("DELETE FROM customoffer Where custom_id='" + id + "'");
                    MessageBox.Show("Custom Package Delete done");
                }


            }
            else
            {
                MessageBox.Show("Please Enter id and select user type");
            }
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            if (adminRB.Checked)
            {

                MessageBox.Show("Cannot Update a Admin");
            }
            else if (customerRB.Checked || agenciesRB.Checked || packageRB.Checked && searchbox.Text != "")
            {
                int id = Convert.ToInt32(searchbox.Text);
                Connect connect = new Connect();

                if (customerRB.Checked)
                {
                    User_Info_Update user_Info_Update = new User_Info_Update(id);
                    user_Info_Update.ShowDialog();
                    MessageBox.Show("Customer update done");
                }
                else if (agenciesRB.Checked)
                {

                    MessageBox.Show("Agencie update done");
                }
                else if (packageRB.Checked)
                {

                    MessageBox.Show("Package update done");
                }


            }
            else
            {
                MessageBox.Show("Please Enter id and select user type");
            }



        }

        private void custompackageB_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            var reader = connect.Connection("select * from customoffer");
            DataTable dt = new DataTable();
            dt.Load(reader);
            admindatagrid.DataSource = dt;
        }

        private void transactionB_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            var reader = connect.Connection("select * from TransactionDetails");
            DataTable dt = new DataTable();
            dt.Load(reader);
            admindatagrid.DataSource = dt;
        }
    }
}
