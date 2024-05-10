using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Travel_World.Packages
{
    public partial class Package_for_Customer_Home_Page : UserControl
    {
        string places, picloc,userpassword;
        public int capacity=0, price=0, duration=0, p_id = 0,c_id=0, A_id=0;
        private static Package_for_Customer_Home_Page selectedPackage = null;
        Color myColor = Color.FromArgb(65, 122, 140);
        string type;
        public Package_for_Customer_Home_Page(string places, string picloc, int capacity, int price, int duration, int p_id,string password, int c_id,int A_id, string type)
        {
            InitializeComponent();
            this.places = places;
            this.picloc = picloc;
            this.capacity = capacity;
            this.price = price;
            this.duration = duration;
            this.p_id = p_id;
            this.userpassword = password;
            this.c_id = c_id;
            this.A_id = A_id;
            this.type = type;

        }
        // this constructor for payment page. showing selected package
        public Package_for_Customer_Home_Page(string places, string picloc, int capacity, int price, int duration, int p_id)
        {
            InitializeComponent();
            this.places = places;
            this.picloc = picloc;
            this.capacity = capacity;
            this.price = price;
            this.duration = duration;
            this.p_id = p_id;
           
            

        }

        private void Package_for_Customer_Home_Page_Load(object sender, EventArgs e)
        {
            visited_placesL.Text = @"Visited Places: " + places;
            capacityL.Text =@"Capacity: " + capacity + " Person";
            durationL.Text = @"Duration: " + duration + " Days";
            priceL.Text = "Price: " + price + "Taka";
            packagepic.ImageLocation = picloc;
            packageidL.Text = "Package Id: " + Convert.ToString(p_id);
            packagepic.ImageLocation=picloc;
            // Adding a even handlar and callng MyUserControl_Click
            this.Click += new EventHandler(MyUserControl_Click);
            make_favorite_option_on_right_click.Items.Add("Make Favorite", null, Make_Favorite_SelectedPackage);
            this.ContextMenuStrip = make_favorite_option_on_right_click;
            if(type=="me")
            {
                buyB.Visible = false;
            }
            else if(type=="agencies_bid")
            {
                buyB.Text = "Bid";
            }
            else
            {
                buyB.Visible = true;
            }
            
        }
        private void MyUserControl_Click(object sender, EventArgs e)
        {
            // Change the background color to indicate selection
            if (selectedPackage != null)
            {
                selectedPackage.BackColor = myColor; // Or whatever my original color was
            }

            // Select the current UserControl
            this.BackColor = Color.LightGreen;
            selectedPackage = this;
        }
        private void Make_Favorite_SelectedPackage(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            // Add the PictureBox to the UserControl
            this.Controls.Add(pictureBox);

            // Set the size and location of the PictureBox
            pictureBox.Size = new Size(32, 32); // Width = 100, Height = 100
            pictureBox.Location = new Point(293, 504); // X = 10, Y = 10

            // Load an image into the PictureBox
            pictureBox.Image = Image.FromFile("D:\\5th Semester\\OBJECT ORIENTED PROGRAMMING 2\\Final\\Travel_World\\Travel_World\\Pictures\\heart (1).png");

        }

        private void buyB_Click(object sender, EventArgs e)
        {
          PaymentPage paymentPage = new PaymentPage( c_id, p_id,price, duration,  places, picloc,capacity, userpassword, A_id);
            
            paymentPage.ShowDialog();
        }
    }
}
