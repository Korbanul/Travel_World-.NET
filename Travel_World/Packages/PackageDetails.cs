using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_World.Packages
{
    public partial class PackageDetails : Form
    {
        public static string places, hotel, picloc;
        public static int price = 0, duration = 0, capacity = 0;
        public static bool saved = false;
        public object sendobj;
        int custom_id = 0, p_id, A_id, cp_c_id, cp_price, cp_capacity, cp_duration;
        string cp_country, cp_hotel, cp_picloc;
        public PackageDetails()
        {
            InitializeComponent();
        }
        public PackageDetails(int c_id)
        {
           this.cp_c_id = c_id;
            InitializeComponent();
        }

        private void PackageDetails_Load(object sender, EventArgs e)
        {
            sendobj = sender ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (placesTB.Text == "" || hotelnameTB.Text == "" || durationTB.Text == "" || priceTB.Text == "" || capacityTB.Text == "")
            {
                MessageBox.Show("Please Fill All Box");
            }
            else
            {
                places = placesTB.Text;
                hotel = hotelnameTB.Text;
                duration = Convert.ToInt32(durationTB.Text);
                price = Convert.ToInt32(priceTB.Text);
                capacity = Convert.ToInt32(capacityTB.Text);

                DialogResult = DialogResult.OK;
                MessageBox.Show("Creation Succesfull");
                this.Hide();

                placesTB.Text = "";
                hotelnameTB.Text="";
                durationTB.Text = "";
                priceTB.Text = "";
                capacityTB.Text = "";

            }


        }
        



        private void chooseimageB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
          //  openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|jpg Files (*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picloc = openFileDialog1.FileName.ToString();
                packagepic.ImageLocation = picloc;
             
            }

           
        }

       
    }
}
