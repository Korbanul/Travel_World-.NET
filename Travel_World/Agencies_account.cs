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
    public partial class Agencies_account : Form
    {
        public string username, password, Agencies_Name, Agencies_Email, Agencies_Address, Agencies_picloc;
        public int Agencies_phone, A_id = 0;
        public Agencies_account(int A_id, string A_username, string A_password, string Agencies_Name, string Agencies_Email, int Agencies_phone, string Agencies_Address, string Agencies_picloc)
        {

            InitializeComponent();
            this.A_id = A_id;
            username = A_username;
            password = A_password;

            this.Agencies_Name = Agencies_Name;
            this.Agencies_Email = Agencies_Email;
            this.Agencies_phone = Agencies_phone;
            this.Agencies_Address = Agencies_Address;
            this.Agencies_picloc = Agencies_picloc;
        }
        



        private void BackL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void change_passwordB_Click(object sender, EventArgs e)
        {
            string user = "Agencies";
            ChangePass cp = new ChangePass(A_id, password, user);
            cp.ShowDialog();

        }

        private void Agencies_account_Load_1(object sender, EventArgs e)
        {
            agencies_nameL.Text = @"Agencies Name: " + Agencies_Name;
            agencies_emailL.Text = @"Agencies E-mail: " + Agencies_Email;
            agencies_phoneL.Text = @"Agencies Phone: " + Convert.ToString(Agencies_phone);
            agencies_addressL.Text = @"Agencies Address: " + Agencies_Address;
            agencies_usernameL.Text = @"Agencies User-Name: " + username;
            agencies_idL.Text = "Agencies ID: " + A_id;
            agencies_pictureBox.ImageLocation = Agencies_picloc;

        }
    }
}
