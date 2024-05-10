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

namespace Travel_World
{
    public partial class customOffrer : Form
    {
        int custom_id = 0, p_id=0, c_id, cp_price, cp_capacity, cp_duration;
        string cp_country, cp_hotel, picloc;
        public customOffrer(int c_id)
        {
            this.c_id = c_id;
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();    
            if (placesTB.Text == "" || hotelnameTB.Text == "" || durationTB.Text == "" || priceTB.Text == "" || capacityTB.Text == "")
            {
                MessageBox.Show("Please Fill All Box");
            }
            else
            {
                cp_country = placesTB.Text;
                cp_hotel = hotelnameTB.Text;
                cp_duration = Convert.ToInt32(durationTB.Text);
                cp_price = Convert.ToInt32(priceTB.Text);
                cp_capacity = Convert.ToInt32(capacityTB.Text);
                Connect c1 = new Connect();
                //finding how many package i have 
                var reader = c1.Connection("SELECT COUNT(*) FROM customoffer");
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
                    reader = c1.Connection("SELECT MAX(custom_id) FROM customoffer;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            custom_id = reader.GetInt32(0) + 1;

                        }
                        c1.close();
                    }


                }
                else
                {
                    custom_id++;
                }
                connect.Connection("insert into customoffer(custom_id,c_id,cp_country,cp_hotel,cp_price,cp_capacity,cp_duration,picloc)values ('" + custom_id+"','"+c_id+"','"+cp_country+"','"+cp_hotel+"','"+cp_price+"','"+cp_capacity+"','"+cp_duration+"','"+picloc+"')");

                connect.close();
                MessageBox.Show("Creation Susscessful");
                placesTB.Text = "";
                hotelnameTB.Text = "";
                durationTB.Text = "";
                priceTB.Text = "";
                capacityTB.Text = "";


            }
        }
    }
}
