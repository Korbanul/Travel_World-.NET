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
    public partial class ChangePass : Form
    {
        string Current_password, usertype,newpasswod;
        int id;
        public ChangePass( int id,string pass,string user)
        {
            InitializeComponent();
            this.Current_password = pass;
            this.usertype = user;
            this.id = id;
        }

        private void change_password_confirmB_Click(object sender, EventArgs e)
        {
            newpasswod=newpassTB.Text;

            if (CurrentPassTB.Text==Current_password)
            {
                Connect connect = new Connect();

                if(usertype== "Customer")
                {
                    connect.Connection("UPDATE UserDetails SET password ='"+ newpasswod + "' WHERE c_id='" +id+"'");
                    connect.close();
                    MessageBox.Show("Password changed");
                    this.Hide();
                }
                else
                {
                    connect.Connection("UPDATE AgenciesDetails SET password ='"+ newpasswod + "' WHERE A_id='" + id + "'");
                    connect.close();
                    MessageBox.Show("Password changed");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
