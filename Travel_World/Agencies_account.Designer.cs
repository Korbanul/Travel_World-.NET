namespace Travel_World
{
    partial class Agencies_account
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
            agencies_usernameL = new Label();
            change_passwordB = new Button();
            agencies_idL = new Label();
            agencies_addressL = new Label();
            agencies_phoneL = new Label();
            agencies_emailL = new Label();
            agencies_nameL = new Label();
            agencies_pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)agencies_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // agencies_usernameL
            // 
            agencies_usernameL.AutoSize = true;
            agencies_usernameL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_usernameL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_usernameL.Location = new Point(156, 326);
            agencies_usernameL.Name = "agencies_usernameL";
            agencies_usernameL.Size = new Size(247, 28);
            agencies_usernameL.TabIndex = 15;
            agencies_usernameL.Text = "Agencies User-Name: ";
            // 
            // change_passwordB
            // 
            change_passwordB.BackColor = Color.FromArgb(46, 64, 83);
            change_passwordB.FlatStyle = FlatStyle.Popup;
            change_passwordB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            change_passwordB.ForeColor = Color.FromArgb(65, 122, 140);
            change_passwordB.Location = new Point(525, 587);
            change_passwordB.Name = "change_passwordB";
            change_passwordB.Size = new Size(166, 35);
            change_passwordB.TabIndex = 14;
            change_passwordB.Text = "Change Password";
            change_passwordB.UseVisualStyleBackColor = false;
            change_passwordB.Click += change_passwordB_Click;
            // 
            // agencies_idL
            // 
            agencies_idL.AutoSize = true;
            agencies_idL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_idL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_idL.Location = new Point(253, 372);
            agencies_idL.Name = "agencies_idL";
            agencies_idL.Size = new Size(150, 28);
            agencies_idL.TabIndex = 13;
            agencies_idL.Text = "Agencies ID: ";
            // 
            // agencies_addressL
            // 
            agencies_addressL.AutoSize = true;
            agencies_addressL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_addressL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_addressL.Location = new Point(188, 522);
            agencies_addressL.Name = "agencies_addressL";
            agencies_addressL.Size = new Size(215, 28);
            agencies_addressL.TabIndex = 12;
            agencies_addressL.Text = "Agencies Address: ";
            // 
            // agencies_phoneL
            // 
            agencies_phoneL.AutoSize = true;
            agencies_phoneL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_phoneL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_phoneL.Location = new Point(209, 475);
            agencies_phoneL.Name = "agencies_phoneL";
            agencies_phoneL.Size = new Size(194, 28);
            agencies_phoneL.TabIndex = 11;
            agencies_phoneL.Text = "Agencies Phone: ";
            // 
            // agencies_emailL
            // 
            agencies_emailL.AutoSize = true;
            agencies_emailL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_emailL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_emailL.Location = new Point(204, 425);
            agencies_emailL.Name = "agencies_emailL";
            agencies_emailL.Size = new Size(199, 28);
            agencies_emailL.TabIndex = 10;
            agencies_emailL.Text = "Agencies E-mail: ";
            // 
            // agencies_nameL
            // 
            agencies_nameL.AutoSize = true;
            agencies_nameL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            agencies_nameL.ForeColor = Color.FromArgb(65, 122, 140);
            agencies_nameL.Location = new Point(213, 282);
            agencies_nameL.Name = "agencies_nameL";
            agencies_nameL.Size = new Size(190, 28);
            agencies_nameL.TabIndex = 9;
            agencies_nameL.Text = "Agencies Name: ";
            // 
            // agencies_pictureBox
            // 
            agencies_pictureBox.BorderStyle = BorderStyle.FixedSingle;
            agencies_pictureBox.Location = new Point(415, 4);
            agencies_pictureBox.Name = "agencies_pictureBox";
            agencies_pictureBox.Size = new Size(256, 256);
            agencies_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            agencies_pictureBox.TabIndex = 8;
            agencies_pictureBox.TabStop = false;
            // 
            // Agencies_account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(847, 627);
            Controls.Add(agencies_usernameL);
            Controls.Add(change_passwordB);
            Controls.Add(agencies_idL);
            Controls.Add(agencies_addressL);
            Controls.Add(agencies_phoneL);
            Controls.Add(agencies_emailL);
            Controls.Add(agencies_nameL);
            Controls.Add(agencies_pictureBox);
            Name = "Agencies_account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agencies_account";
            Load += Agencies_account_Load_1;
            ((System.ComponentModel.ISupportInitialize)agencies_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label agencies_usernameL;
        private Button change_passwordB;
        private Label agencies_idL;
        private Label agencies_addressL;
        private Label agencies_phoneL;
        private Label agencies_emailL;
        private Label agencies_nameL;
        private PictureBox agencies_pictureBox;
    }
}