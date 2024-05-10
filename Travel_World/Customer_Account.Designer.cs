namespace Travel_World
{
    partial class Customer_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Account));
            user_pic = new PictureBox();
            full_nameL = new Label();
            user_nameL = new Label();
            emailL = new Label();
            phoneL = new Label();
            birth_dateL = new Label();
            addressL = new Label();
            customer_idL = new Label();
            change_passwordB = new Button();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
            // 
            // user_pic
            // 
            user_pic.Image = (Image)resources.GetObject("user_pic.Image");
            user_pic.Location = new Point(251, 3);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(256, 256);
            user_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            user_pic.TabIndex = 2;
            user_pic.TabStop = false;
            // 
            // full_nameL
            // 
            full_nameL.AutoEllipsis = true;
            full_nameL.AutoSize = true;
            full_nameL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            full_nameL.ForeColor = Color.Cyan;
            full_nameL.Location = new Point(41, 307);
            full_nameL.Name = "full_nameL";
            full_nameL.Size = new Size(108, 23);
            full_nameL.TabIndex = 3;
            full_nameL.Text = "Full Name: ";
            // 
            // user_nameL
            // 
            user_nameL.AutoEllipsis = true;
            user_nameL.AutoSize = true;
            user_nameL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            user_nameL.ForeColor = Color.Cyan;
            user_nameL.Location = new Point(540, 307);
            user_nameL.Name = "user_nameL";
            user_nameL.Size = new Size(113, 23);
            user_nameL.TabIndex = 4;
            user_nameL.Text = "User Name: ";
            // 
            // emailL
            // 
            emailL.AutoEllipsis = true;
            emailL.AutoSize = true;
            emailL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            emailL.ForeColor = Color.Cyan;
            emailL.Location = new Point(41, 363);
            emailL.Name = "emailL";
            emailL.Size = new Size(71, 23);
            emailL.TabIndex = 5;
            emailL.Text = "Email: ";
            // 
            // phoneL
            // 
            phoneL.AutoEllipsis = true;
            phoneL.AutoSize = true;
            phoneL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phoneL.ForeColor = Color.Cyan;
            phoneL.Location = new Point(540, 414);
            phoneL.Name = "phoneL";
            phoneL.Size = new Size(73, 23);
            phoneL.TabIndex = 6;
            phoneL.Text = "Phone: ";
            // 
            // birth_dateL
            // 
            birth_dateL.AutoEllipsis = true;
            birth_dateL.AutoSize = true;
            birth_dateL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            birth_dateL.ForeColor = Color.Cyan;
            birth_dateL.Location = new Point(41, 414);
            birth_dateL.Name = "birth_dateL";
            birth_dateL.Size = new Size(110, 23);
            birth_dateL.TabIndex = 7;
            birth_dateL.Text = "Birth Date: ";
            // 
            // addressL
            // 
            addressL.AutoEllipsis = true;
            addressL.AutoSize = true;
            addressL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addressL.ForeColor = Color.Cyan;
            addressL.Location = new Point(41, 465);
            addressL.Name = "addressL";
            addressL.Size = new Size(89, 23);
            addressL.TabIndex = 8;
            addressL.Text = "Address: ";
            // 
            // customer_idL
            // 
            customer_idL.AutoEllipsis = true;
            customer_idL.AutoSize = true;
            customer_idL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            customer_idL.ForeColor = Color.Cyan;
            customer_idL.Location = new Point(540, 363);
            customer_idL.Name = "customer_idL";
            customer_idL.Size = new Size(81, 23);
            customer_idL.TabIndex = 9;
            customer_idL.Text = "Your ID: ";
            // 
            // change_passwordB
            // 
            change_passwordB.FlatStyle = FlatStyle.Popup;
            change_passwordB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            change_passwordB.ForeColor = Color.Cyan;
            change_passwordB.Location = new Point(251, 603);
            change_passwordB.Name = "change_passwordB";
            change_passwordB.Size = new Size(159, 32);
            change_passwordB.TabIndex = 11;
            change_passwordB.Text = "Change Password";
            change_passwordB.UseVisualStyleBackColor = true;
            change_passwordB.Click += change_passwordB_Click;
            // 
            // Customer_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(800, 686);
            Controls.Add(change_passwordB);
            Controls.Add(customer_idL);
            Controls.Add(addressL);
            Controls.Add(birth_dateL);
            Controls.Add(phoneL);
            Controls.Add(emailL);
            Controls.Add(user_nameL);
            Controls.Add(full_nameL);
            Controls.Add(user_pic);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Customer_Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Account";
            Load += Customer_Account_Load;
            ((System.ComponentModel.ISupportInitialize)user_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox user_pic;
        private Label full_nameL;
        private Label user_nameL;
        private Label emailL;
        private Label phoneL;
        private Label birth_dateL;
        private Label addressL;
        private Label customer_idL;
        private Button change_passwordB;
    }
}