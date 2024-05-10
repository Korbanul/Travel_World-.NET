namespace Travel_World
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            selectedpackageP = new Panel();
            BackL = new Button();
            bankslogoP = new Panel();
            alarafaB = new Button();
            ucbB = new Button();
            nagadB = new Button();
            cityB = new Button();
            rocketB = new Button();
            bkashB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MoborAccnumberTB = new TextBox();
            passwordTB = new TextBox();
            passwordL = new Label();
            confirmB = new Button();
            payment_optionL = new Label();
            bankslogoP.SuspendLayout();
            SuspendLayout();
            // 
            // selectedpackageP
            // 
            selectedpackageP.AutoScroll = true;
            selectedpackageP.Location = new Point(12, 127);
            selectedpackageP.Name = "selectedpackageP";
            selectedpackageP.Size = new Size(320, 591);
            selectedpackageP.TabIndex = 0;
            // 
            // BackL
            // 
            BackL.BackColor = Color.PaleGreen;
            BackL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackL.ForeColor = Color.Red;
            BackL.Location = new Point(12, 12);
            BackL.Name = "BackL";
            BackL.Size = new Size(68, 31);
            BackL.TabIndex = 47;
            BackL.Text = "Back";
            BackL.UseVisualStyleBackColor = false;
            BackL.Click += BackL_Click;
            // 
            // bankslogoP
            // 
            bankslogoP.AutoScroll = true;
            bankslogoP.Controls.Add(alarafaB);
            bankslogoP.Controls.Add(ucbB);
            bankslogoP.Controls.Add(nagadB);
            bankslogoP.Controls.Add(cityB);
            bankslogoP.Controls.Add(rocketB);
            bankslogoP.Controls.Add(bkashB);
            bankslogoP.Location = new Point(368, 127);
            bankslogoP.Name = "bankslogoP";
            bankslogoP.Size = new Size(727, 150);
            bankslogoP.TabIndex = 48;
            // 
            // alarafaB
            // 
            alarafaB.BackgroundImage = (Image)resources.GetObject("alarafaB.BackgroundImage");
            alarafaB.BackgroundImageLayout = ImageLayout.Stretch;
            alarafaB.Location = new Point(479, 3);
            alarafaB.Name = "alarafaB";
            alarafaB.Size = new Size(112, 141);
            alarafaB.TabIndex = 54;
            alarafaB.TextAlign = ContentAlignment.BottomRight;
            alarafaB.UseVisualStyleBackColor = true;
            alarafaB.Click += alarafaB_Click;
            // 
            // ucbB
            // 
            ucbB.BackgroundImage = (Image)resources.GetObject("ucbB.BackgroundImage");
            ucbB.BackgroundImageLayout = ImageLayout.Stretch;
            ucbB.Location = new Point(361, 3);
            ucbB.Name = "ucbB";
            ucbB.Size = new Size(112, 141);
            ucbB.TabIndex = 53;
            ucbB.TextAlign = ContentAlignment.BottomRight;
            ucbB.UseVisualStyleBackColor = true;
            ucbB.Click += ucbB_Click;
            // 
            // nagadB
            // 
            nagadB.BackgroundImage = (Image)resources.GetObject("nagadB.BackgroundImage");
            nagadB.BackgroundImageLayout = ImageLayout.Stretch;
            nagadB.Location = new Point(243, 3);
            nagadB.Name = "nagadB";
            nagadB.Size = new Size(112, 141);
            nagadB.TabIndex = 52;
            nagadB.TextAlign = ContentAlignment.BottomRight;
            nagadB.UseVisualStyleBackColor = true;
            nagadB.Click += nagadB_Click;
            // 
            // cityB
            // 
            cityB.BackgroundImage = (Image)resources.GetObject("cityB.BackgroundImage");
            cityB.BackgroundImageLayout = ImageLayout.Stretch;
            cityB.Location = new Point(597, 3);
            cityB.Name = "cityB";
            cityB.Size = new Size(118, 141);
            cityB.TabIndex = 51;
            cityB.TextAlign = ContentAlignment.BottomRight;
            cityB.UseVisualStyleBackColor = true;
            cityB.Click += cityB_Click;
            // 
            // rocketB
            // 
            rocketB.BackgroundImage = (Image)resources.GetObject("rocketB.BackgroundImage");
            rocketB.BackgroundImageLayout = ImageLayout.Stretch;
            rocketB.Location = new Point(125, 3);
            rocketB.Name = "rocketB";
            rocketB.Size = new Size(112, 141);
            rocketB.TabIndex = 50;
            rocketB.TextAlign = ContentAlignment.BottomRight;
            rocketB.UseVisualStyleBackColor = true;
            rocketB.Click += rocketB_Click;
            // 
            // bkashB
            // 
            bkashB.BackgroundImage = (Image)resources.GetObject("bkashB.BackgroundImage");
            bkashB.BackgroundImageLayout = ImageLayout.Stretch;
            bkashB.Location = new Point(7, 3);
            bkashB.Name = "bkashB";
            bkashB.Size = new Size(112, 141);
            bkashB.TabIndex = 49;
            bkashB.TextAlign = ContentAlignment.BottomRight;
            bkashB.UseVisualStyleBackColor = true;
            bkashB.Click += bkashB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 62);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 49;
            label1.Text = "Please Select Payment option";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 50;
            label2.Text = "Your Selected Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 462);
            label3.Name = "label3";
            label3.Size = new Size(252, 23);
            label3.TabIndex = 51;
            label3.Text = "Enter Mobile/Account number:";
            // 
            // MoborAccnumberTB
            // 
            MoborAccnumberTB.BackColor = Color.FromArgb(41, 44, 51);
            MoborAccnumberTB.BorderStyle = BorderStyle.FixedSingle;
            MoborAccnumberTB.ForeColor = Color.White;
            MoborAccnumberTB.Location = new Point(692, 460);
            MoborAccnumberTB.Multiline = true;
            MoborAccnumberTB.Name = "MoborAccnumberTB";
            MoborAccnumberTB.Size = new Size(336, 37);
            MoborAccnumberTB.TabIndex = 52;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(41, 44, 51);
            passwordTB.BorderStyle = BorderStyle.FixedSingle;
            passwordTB.ForeColor = Color.White;
            passwordTB.Location = new Point(692, 532);
            passwordTB.Multiline = true;
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(336, 37);
            passwordTB.TabIndex = 53;
            // 
            // passwordL
            // 
            passwordL.AutoSize = true;
            passwordL.Location = new Point(434, 534);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(142, 23);
            passwordL.TabIndex = 54;
            passwordL.Text = "Enter Password:";
            // 
            // confirmB
            // 
            confirmB.BackColor = Color.PaleGreen;
            confirmB.FlatStyle = FlatStyle.Popup;
            confirmB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmB.Location = new Point(772, 610);
            confirmB.Name = "confirmB";
            confirmB.Size = new Size(113, 52);
            confirmB.TabIndex = 55;
            confirmB.Text = "Confirm";
            confirmB.UseVisualStyleBackColor = false;
            confirmB.Click += confirmB_Click;
            // 
            // payment_optionL
            // 
            payment_optionL.AutoSize = true;
            payment_optionL.Location = new Point(375, 335);
            payment_optionL.Name = "payment_optionL";
            payment_optionL.Size = new Size(215, 23);
            payment_optionL.TabIndex = 56;
            payment_optionL.Text = "Selected Payment option:";
            // 
            // PaymentPage
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1285, 730);
            Controls.Add(payment_optionL);
            Controls.Add(confirmB);
            Controls.Add(passwordL);
            Controls.Add(passwordTB);
            Controls.Add(MoborAccnumberTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bankslogoP);
            Controls.Add(BackL);
            Controls.Add(selectedpackageP);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            ForeColor = Color.FromArgb(65, 122, 140);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PaymentPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaymentPage";
            bankslogoP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel selectedpackageP;
        private Button BackL;
        private Panel bankslogoP;
        private Button alarafaB;
        private Button ucbB;
        private Button nagadB;
        private Button cityB;
        private Button rocketB;
        private Button bkashB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MoborAccnumberTB;
        private TextBox passwordTB;
        private Label passwordL;
        private Button confirmB;
        private Label payment_optionL;
    }
}