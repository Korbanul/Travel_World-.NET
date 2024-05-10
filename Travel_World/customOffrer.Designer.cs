namespace Travel_World
{
    partial class customOffrer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseimageB = new Button();
            button1 = new Button();
            packagepic = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            hotelnameTB = new TextBox();
            durationTB = new TextBox();
            priceTB = new TextBox();
            capacityTB = new TextBox();
            placesTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)packagepic).BeginInit();
            SuspendLayout();
            // 
            // chooseimageB
            // 
            chooseimageB.FlatStyle = FlatStyle.Popup;
            chooseimageB.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chooseimageB.ForeColor = Color.FromArgb(65, 122, 140);
            chooseimageB.Location = new Point(634, 216);
            chooseimageB.Name = "chooseimageB";
            chooseimageB.Size = new Size(139, 31);
            chooseimageB.TabIndex = 20;
            chooseimageB.Text = "Choose image";
            chooseimageB.UseVisualStyleBackColor = true;
            chooseimageB.Click += chooseimageB_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(65, 122, 140);
            button1.Location = new Point(477, 580);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // packagepic
            // 
            packagepic.Location = new Point(198, 24);
            packagepic.Name = "packagepic";
            packagepic.Size = new Size(407, 223);
            packagepic.SizeMode = PictureBoxSizeMode.StretchImage;
            packagepic.TabIndex = 18;
            packagepic.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(65, 122, 140);
            label5.Location = new Point(54, 505);
            label5.Name = "label5";
            label5.Size = new Size(278, 28);
            label5.TabIndex = 17;
            label5.Text = "Please enter hotel name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(65, 122, 140);
            label4.Location = new Point(54, 444);
            label4.Name = "label4";
            label4.Size = new Size(252, 28);
            label4.TabIndex = 16;
            label4.Text = "Please enter Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(65, 122, 140);
            label3.Location = new Point(54, 393);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 15;
            label3.Text = "Please enter price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(65, 122, 140);
            label2.Location = new Point(54, 339);
            label2.Name = "label2";
            label2.Size = new Size(251, 28);
            label2.TabIndex = 14;
            label2.Text = "Please enter capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(65, 122, 140);
            label1.Location = new Point(54, 279);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 13;
            label1.Text = "Please enter places";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // hotelnameTB
            // 
            hotelnameTB.BackColor = Color.FromArgb(41, 44, 51);
            hotelnameTB.BorderStyle = BorderStyle.FixedSingle;
            hotelnameTB.ForeColor = Color.White;
            hotelnameTB.Location = new Point(354, 505);
            hotelnameTB.Multiline = true;
            hotelnameTB.Name = "hotelnameTB";
            hotelnameTB.Size = new Size(340, 40);
            hotelnameTB.TabIndex = 25;
            // 
            // durationTB
            // 
            durationTB.BackColor = Color.FromArgb(41, 44, 51);
            durationTB.BorderStyle = BorderStyle.FixedSingle;
            durationTB.ForeColor = Color.White;
            durationTB.Location = new Point(354, 448);
            durationTB.Multiline = true;
            durationTB.Name = "durationTB";
            durationTB.Size = new Size(340, 40);
            durationTB.TabIndex = 24;
            // 
            // priceTB
            // 
            priceTB.BackColor = Color.FromArgb(41, 44, 51);
            priceTB.BorderStyle = BorderStyle.FixedSingle;
            priceTB.ForeColor = Color.White;
            priceTB.Location = new Point(353, 397);
            priceTB.Multiline = true;
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(340, 40);
            priceTB.TabIndex = 23;
            // 
            // capacityTB
            // 
            capacityTB.BackColor = Color.FromArgb(41, 44, 51);
            capacityTB.BorderStyle = BorderStyle.FixedSingle;
            capacityTB.ForeColor = Color.White;
            capacityTB.Location = new Point(353, 339);
            capacityTB.Multiline = true;
            capacityTB.Name = "capacityTB";
            capacityTB.Size = new Size(340, 40);
            capacityTB.TabIndex = 22;
            // 
            // placesTB
            // 
            placesTB.BackColor = Color.FromArgb(41, 44, 51);
            placesTB.BorderStyle = BorderStyle.FixedSingle;
            placesTB.ForeColor = Color.White;
            placesTB.Location = new Point(353, 279);
            placesTB.Multiline = true;
            placesTB.Name = "placesTB";
            placesTB.Size = new Size(340, 40);
            placesTB.TabIndex = 21;
            // 
            // customOffrer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(826, 633);
            Controls.Add(chooseimageB);
            Controls.Add(button1);
            Controls.Add(packagepic);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hotelnameTB);
            Controls.Add(durationTB);
            Controls.Add(priceTB);
            Controls.Add(capacityTB);
            Controls.Add(placesTB);
            ForeColor = Color.White;
            Name = "customOffrer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customOffrer";
            ((System.ComponentModel.ISupportInitialize)packagepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseimageB;
        private Button button1;
        private PictureBox packagepic;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox hotelnameTB;
        private TextBox durationTB;
        private TextBox priceTB;
        private TextBox capacityTB;
        private TextBox placesTB;
    }
}