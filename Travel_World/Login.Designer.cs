namespace Travel_World
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headingL = new Label();
            usernameL = new Label();
            passwordL = new Label();
            createaccountL = new Label();
            loginL = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginB = new Button();
            signuppageB = new Button();
            adminRB = new RadioButton();
            customerRB = new RadioButton();
            agenciesRB = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // headingL
            // 
            headingL.AutoSize = true;
            headingL.BackColor = Color.Transparent;
            headingL.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold | FontStyle.Italic);
            headingL.ForeColor = Color.PaleGreen;
            headingL.Location = new Point(449, 20);
            headingL.Name = "headingL";
            headingL.Size = new Size(187, 36);
            headingL.TabIndex = 0;
            headingL.Text = "Travel World";
            // 
            // usernameL
            // 
            usernameL.AutoSize = true;
            usernameL.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold | FontStyle.Italic);
            usernameL.ForeColor = Color.FromArgb(62, 120, 138);
            usernameL.Location = new Point(142, 210);
            usernameL.Name = "usernameL";
            usernameL.Size = new Size(148, 36);
            usernameL.TabIndex = 1;
            usernameL.Text = "UserName";
            // 
            // passwordL
            // 
            passwordL.AutoSize = true;
            passwordL.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold | FontStyle.Italic);
            passwordL.ForeColor = Color.FromArgb(62, 120, 138);
            passwordL.Location = new Point(142, 321);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(142, 36);
            passwordL.TabIndex = 2;
            passwordL.Text = "Password";
            // 
            // createaccountL
            // 
            createaccountL.AutoSize = true;
            createaccountL.BackColor = Color.Transparent;
            createaccountL.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold | FontStyle.Italic);
            createaccountL.ForeColor = Color.FromArgb(62, 120, 138);
            createaccountL.Location = new Point(316, 588);
            createaccountL.Name = "createaccountL";
            createaccountL.Size = new Size(216, 20);
            createaccountL.TabIndex = 3;
            createaccountL.Text = "Not a User? Create a Account";
            // 
            // loginL
            // 
            loginL.AutoSize = true;
            loginL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            loginL.ForeColor = Color.FromArgb(62, 120, 138);
            loginL.Location = new Point(449, 139);
            loginL.Name = "loginL";
            loginL.Size = new Size(129, 28);
            loginL.TabIndex = 4;
            loginL.Text = "Login Here";
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.FromArgb(41, 44, 51);
            usernameTB.BorderStyle = BorderStyle.FixedSingle;
            usernameTB.ForeColor = Color.White;
            usernameTB.Location = new Point(366, 212);
            usernameTB.Multiline = true;
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(354, 43);
            usernameTB.TabIndex = 5;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(41, 44, 51);
            passwordTB.BorderStyle = BorderStyle.FixedSingle;
            passwordTB.ForeColor = Color.White;
            passwordTB.Location = new Point(366, 321);
            passwordTB.Multiline = true;
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(354, 49);
            passwordTB.TabIndex = 6;
            // 
            // loginB
            // 
            loginB.FlatStyle = FlatStyle.Flat;
            loginB.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic);
            loginB.ForeColor = Color.FromArgb(62, 120, 138);
            loginB.Location = new Point(439, 421);
            loginB.Name = "loginB";
            loginB.Size = new Size(104, 35);
            loginB.TabIndex = 7;
            loginB.Text = "Login";
            loginB.UseVisualStyleBackColor = true;
            loginB.Click += loginB_Click;
            // 
            // signuppageB
            // 
            signuppageB.BackColor = Color.FromArgb(41, 44, 51);
            signuppageB.FlatStyle = FlatStyle.Flat;
            signuppageB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            signuppageB.ForeColor = Color.FromArgb(62, 120, 138);
            signuppageB.Location = new Point(538, 579);
            signuppageB.Name = "signuppageB";
            signuppageB.Size = new Size(115, 38);
            signuppageB.TabIndex = 8;
            signuppageB.Text = "Signup";
            signuppageB.UseVisualStyleBackColor = false;
            signuppageB.Click += signuppageB_Click;
            // 
            // adminRB
            // 
            adminRB.AutoSize = true;
            adminRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            adminRB.ForeColor = Color.FromArgb(62, 120, 138);
            adminRB.Location = new Point(876, 210);
            adminRB.Name = "adminRB";
            adminRB.Size = new Size(84, 27);
            adminRB.TabIndex = 9;
            adminRB.TabStop = true;
            adminRB.Text = "Admin";
            adminRB.UseVisualStyleBackColor = true;
            // 
            // customerRB
            // 
            customerRB.AutoSize = true;
            customerRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            customerRB.ForeColor = Color.FromArgb(62, 120, 138);
            customerRB.Location = new Point(876, 270);
            customerRB.Name = "customerRB";
            customerRB.Size = new Size(111, 27);
            customerRB.TabIndex = 10;
            customerRB.TabStop = true;
            customerRB.Text = "Customer";
            customerRB.UseVisualStyleBackColor = true;
            // 
            // agenciesRB
            // 
            agenciesRB.AutoSize = true;
            agenciesRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            agenciesRB.ForeColor = Color.FromArgb(62, 120, 138);
            agenciesRB.Location = new Point(876, 329);
            agenciesRB.Name = "agenciesRB";
            agenciesRB.Size = new Size(105, 27);
            agenciesRB.TabIndex = 11;
            agenciesRB.TabStop = true;
            agenciesRB.Text = "Agencies";
            agenciesRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(65, 122, 140);
            label1.Location = new Point(876, 155);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 13;
            label1.Text = "User Type";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1192, 665);
            Controls.Add(label1);
            Controls.Add(agenciesRB);
            Controls.Add(customerRB);
            Controls.Add(adminRB);
            Controls.Add(signuppageB);
            Controls.Add(loginB);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(loginL);
            Controls.Add(createaccountL);
            Controls.Add(passwordL);
            Controls.Add(usernameL);
            Controls.Add(headingL);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingL;
        private Label usernameL;
        private Label passwordL;
        private Label createaccountL;
        private Label loginL;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginB;
        private Button signuppageB;
        private RadioButton adminRB;
        private RadioButton customerRB;
        private RadioButton agenciesRB;
        private Label label1;
    }
}
