using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Travel_World.Packages
{

    public partial class Package : UserControl
    {
        public string place, hotel, picloc;
        public int capcity, price, duration,p_id;
        private static Package selectedPackage = null;
        Color myColor = Color.FromArgb(65, 122, 140);
        public Package()
        {
            InitializeComponent();
           

        }
        public Package(string place, int capacity, int price, int duration, string hotel, string loc,int p_id)
        {
            InitializeComponent();
            this.place = place;
            this.hotel = hotel;
            this.capcity = capacity;
            this.price = price;
            this.duration = duration;
            this.picloc = loc;
            this.p_id = p_id;
            // Adding a even handlar and callng MyUserControl_Click
            this.Click += new EventHandler(MyUserControl_Click);
            // Add delete option in ContextMenuStrip
            
            delete_option_on_right_click.Items.Add("Delete", null, DeleteSelectedPackage);
            this.ContextMenuStrip = delete_option_on_right_click;

        }


        public void Package_Load(object sender, EventArgs e)
        {
            placeL.Text = @"Visited Place: " + place;
            capacityL.Text =@"Capacity: " + capcity + " Person";
            durationL.Text =@"Duration: " + duration + " Days";
            hoyelL.Text = @"Hotel: " + hotel;
            priceL.Text = @"Price: " + price + " Taka";
            packagepic.ImageLocation = picloc;
        }

        private void MyUserControl_Click(object sender, EventArgs e)
        {
            // Change the background color to indicate selection
            if (selectedPackage != null)
            {
                selectedPackage.BackColor = myColor; // Or whatever my original color was
            }

            // Select the current UserControl
            this.BackColor = Color.LightBlue;
            selectedPackage = this;
        }
        private static void DeleteSelectedPackage(object sender, EventArgs e)
        {
            if (selectedPackage != null)
            {
                //Deleting from ui(flowlayout panel)
                selectedPackage.Parent.Controls.Remove(selectedPackage);
                //selectedPackage = null;
                Connect c1 = new Connect();
               
                //Deleting from database
                var reader = c1.Connection("DELETE FROM Package WHERE p_id= '"+selectedPackage.p_id+"'");
                MessageBox.Show("Deleted Package Id: "+ selectedPackage.p_id);

            }
        }
    }
}
