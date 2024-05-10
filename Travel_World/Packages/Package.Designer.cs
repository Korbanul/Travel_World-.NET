namespace Travel_World.Packages
{
    partial class Package
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            packagepic = new PictureBox();
            placeL = new Label();
            capacityL = new Label();
            durationL = new Label();
            hoyelL = new Label();
            priceL = new Label();
            delete_option_on_right_click = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)packagepic).BeginInit();
            SuspendLayout();
            // 
            // packagepic
            // 
            packagepic.Image = (Image)resources.GetObject("packagepic.Image");
            packagepic.Location = new Point(-1, 3);
            packagepic.Name = "packagepic";
            packagepic.Size = new Size(331, 239);
            packagepic.SizeMode = PictureBoxSizeMode.StretchImage;
            packagepic.TabIndex = 0;
            packagepic.TabStop = false;
            // 
            // placeL
            // 
            placeL.AutoSize = true;
            placeL.Location = new Point(3, 266);
            placeL.Name = "placeL";
            placeL.Size = new Size(102, 20);
            placeL.TabIndex = 1;
            placeL.Text = "Visited Places:";
            // 
            // capacityL
            // 
            capacityL.AutoSize = true;
            capacityL.Location = new Point(3, 309);
            capacityL.Name = "capacityL";
            capacityL.Size = new Size(69, 20);
            capacityL.TabIndex = 2;
            capacityL.Text = "Capacity:";
            // 
            // durationL
            // 
            durationL.AutoSize = true;
            durationL.Location = new Point(3, 352);
            durationL.Name = "durationL";
            durationL.Size = new Size(70, 20);
            durationL.TabIndex = 3;
            durationL.Text = "Duration:";
            // 
            // hoyelL
            // 
            hoyelL.AutoSize = true;
            hoyelL.Location = new Point(6, 389);
            hoyelL.Name = "hoyelL";
            hoyelL.Size = new Size(49, 20);
            hoyelL.TabIndex = 4;
            hoyelL.Text = "Hotel:";
            // 
            // priceL
            // 
            priceL.AutoSize = true;
            priceL.Location = new Point(6, 426);
            priceL.Name = "priceL";
            priceL.Size = new Size(44, 20);
            priceL.TabIndex = 5;
            priceL.Text = "Price:";
            // 
            // delete_option_on_right_click
            // 
            delete_option_on_right_click.ImageScalingSize = new Size(20, 20);
            delete_option_on_right_click.Name = "contextMenuStrip1";
            delete_option_on_right_click.Size = new Size(61, 4);
            // 
            // Package
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 120, 138);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(priceL);
            Controls.Add(hoyelL);
            Controls.Add(durationL);
            Controls.Add(capacityL);
            Controls.Add(placeL);
            Controls.Add(packagepic);
            ForeColor = Color.FromArgb(41, 44, 51);
            Name = "Package";
            Size = new Size(329, 505);
            Load += Package_Load;
            ((System.ComponentModel.ISupportInitialize)packagepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox packagepic;
        private Label placeL;
        private Label capacityL;
        private Label durationL;
        private Label hoyelL;
        private Label priceL;
        private ContextMenuStrip delete_option_on_right_click;
    }
}
