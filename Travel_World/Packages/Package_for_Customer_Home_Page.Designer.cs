namespace Travel_World.Packages
{
    partial class Package_for_Customer_Home_Page
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package_for_Customer_Home_Page));
            packagepic = new PictureBox();
            visited_placesL = new Label();
            capacityL = new Label();
            durationL = new Label();
            priceL = new Label();
            buyB = new Button();
            make_favorite_option_on_right_click = new ContextMenuStrip(components);
            delete_option_on_right_click = new ContextMenuStrip(components);
            packageidL = new Label();
            ((System.ComponentModel.ISupportInitialize)packagepic).BeginInit();
            SuspendLayout();
            // 
            // packagepic
            // 
            packagepic.Image = (Image)resources.GetObject("packagepic.Image");
            packagepic.Location = new Point(1, 0);
            packagepic.Name = "packagepic";
            packagepic.Size = new Size(389, 252);
            packagepic.SizeMode = PictureBoxSizeMode.StretchImage;
            packagepic.TabIndex = 1;
            packagepic.TabStop = false;
            // 
            // visited_placesL
            // 
            visited_placesL.AutoSize = true;
            visited_placesL.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            visited_placesL.ForeColor = Color.FromArgb(65, 122, 140);
            visited_placesL.Location = new Point(0, 275);
            visited_placesL.Name = "visited_placesL";
            visited_placesL.Size = new Size(133, 23);
            visited_placesL.TabIndex = 2;
            visited_placesL.Text = "Visited Places: ";
            // 
            // capacityL
            // 
            capacityL.AutoSize = true;
            capacityL.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            capacityL.ForeColor = Color.FromArgb(65, 122, 140);
            capacityL.Location = new Point(3, 323);
            capacityL.Name = "capacityL";
            capacityL.Size = new Size(92, 23);
            capacityL.TabIndex = 3;
            capacityL.Text = "Capacity: ";
            // 
            // durationL
            // 
            durationL.AutoSize = true;
            durationL.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            durationL.ForeColor = Color.FromArgb(65, 122, 140);
            durationL.Location = new Point(3, 365);
            durationL.Name = "durationL";
            durationL.Size = new Size(92, 23);
            durationL.TabIndex = 4;
            durationL.Text = "Duration: ";
            // 
            // priceL
            // 
            priceL.AutoSize = true;
            priceL.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            priceL.ForeColor = Color.FromArgb(65, 122, 140);
            priceL.Location = new Point(3, 412);
            priceL.Name = "priceL";
            priceL.Size = new Size(62, 23);
            priceL.TabIndex = 5;
            priceL.Text = "Price: ";
            // 
            // buyB
            // 
            buyB.FlatStyle = FlatStyle.Popup;
            buyB.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buyB.ForeColor = Color.Cyan;
            buyB.Location = new Point(139, 509);
            buyB.Name = "buyB";
            buyB.Size = new Size(81, 33);
            buyB.TabIndex = 6;
            buyB.Text = "Buy";
            buyB.UseVisualStyleBackColor = true;
            buyB.Click += buyB_Click;
            // 
            // make_favorite_option_on_right_click
            // 
            make_favorite_option_on_right_click.ImageScalingSize = new Size(20, 20);
            make_favorite_option_on_right_click.Name = "contextMenuStrip1";
            make_favorite_option_on_right_click.Size = new Size(61, 4);
            // 
            // delete_option_on_right_click
            // 
            delete_option_on_right_click.ImageScalingSize = new Size(20, 20);
            delete_option_on_right_click.Name = "contextMenuStrip1";
            delete_option_on_right_click.Size = new Size(61, 4);
            // 
            // packageidL
            // 
            packageidL.AutoSize = true;
            packageidL.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            packageidL.ForeColor = Color.FromArgb(65, 122, 140);
            packageidL.Location = new Point(0, 465);
            packageidL.Name = "packageidL";
            packageidL.Size = new Size(107, 23);
            packageidL.TabIndex = 9;
            packageidL.Text = "Package ID: ";
            // 
            // Package_for_Customer_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            Controls.Add(packageidL);
            Controls.Add(buyB);
            Controls.Add(priceL);
            Controls.Add(durationL);
            Controls.Add(capacityL);
            Controls.Add(visited_placesL);
            Controls.Add(packagepic);
            Name = "Package_for_Customer_Home_Page";
            Size = new Size(390, 560);
            Load += Package_for_Customer_Home_Page_Load;
            ((System.ComponentModel.ISupportInitialize)packagepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox packagepic;
        private Label visited_placesL;
        private Label capacityL;
        private Label durationL;
        private Label priceL;
        private Button buyB;
        private ContextMenuStrip make_favorite_option_on_right_click;
        private ContextMenuStrip delete_option_on_right_click;
        private Label packageidL;
    }
}
