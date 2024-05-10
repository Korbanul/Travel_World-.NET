namespace Travel_World
{
    partial class CustomerHomePage
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
            BackL = new Button();
            label2 = new Label();
            customerflowLayoutPanel = new FlowLayoutPanel();
            customerpanel = new Panel();
            custompackageB = new Button();
            filter_packageB = new Button();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            CB1 = new CheckBox();
            accountB = new Button();
            HomeB = new Button();
            customerpanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackL
            // 
            BackL.BackColor = Color.PaleGreen;
            BackL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackL.ForeColor = Color.Red;
            BackL.Location = new Point(12, 12);
            BackL.Name = "BackL";
            BackL.Size = new Size(68, 31);
            BackL.TabIndex = 46;
            BackL.Text = "Back";
            BackL.UseVisualStyleBackColor = false;
            BackL.Click += BackL_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(914, 382);
            label2.Name = "label2";
            label2.Size = new Size(0, 36);
            label2.TabIndex = 55;
            // 
            // customerflowLayoutPanel
            // 
            customerflowLayoutPanel.AutoScroll = true;
            customerflowLayoutPanel.BackColor = Color.FromArgb(41, 44, 51);
            customerflowLayoutPanel.Location = new Point(223, 0);
            customerflowLayoutPanel.Name = "customerflowLayoutPanel";
            customerflowLayoutPanel.Size = new Size(1235, 835);
            customerflowLayoutPanel.TabIndex = 57;
            // 
            // customerpanel
            // 
            customerpanel.BackColor = Color.DarkSeaGreen;
            customerpanel.Controls.Add(custompackageB);
            customerpanel.Controls.Add(filter_packageB);
            customerpanel.Controls.Add(checkBox6);
            customerpanel.Controls.Add(checkBox5);
            customerpanel.Controls.Add(checkBox4);
            customerpanel.Controls.Add(checkBox3);
            customerpanel.Controls.Add(checkBox2);
            customerpanel.Controls.Add(label1);
            customerpanel.Controls.Add(CB1);
            customerpanel.Controls.Add(accountB);
            customerpanel.Controls.Add(HomeB);
            customerpanel.Controls.Add(BackL);
            customerpanel.Dock = DockStyle.Left;
            customerpanel.Location = new Point(0, 0);
            customerpanel.Name = "customerpanel";
            customerpanel.Size = new Size(217, 835);
            customerpanel.TabIndex = 58;
            // 
            // custompackageB
            // 
            custompackageB.FlatStyle = FlatStyle.Popup;
            custompackageB.Location = new Point(22, 534);
            custompackageB.Name = "custompackageB";
            custompackageB.Size = new Size(162, 29);
            custompackageB.TabIndex = 58;
            custompackageB.Text = "Custom Package";
            custompackageB.UseVisualStyleBackColor = true;
            custompackageB.Click += custompackageB_Click;
            // 
            // filter_packageB
            // 
            filter_packageB.FlatStyle = FlatStyle.Popup;
            filter_packageB.Location = new Point(36, 407);
            filter_packageB.Name = "filter_packageB";
            filter_packageB.Size = new Size(138, 29);
            filter_packageB.TabIndex = 57;
            filter_packageB.Text = "Filter Package";
            filter_packageB.UseVisualStyleBackColor = true;
            filter_packageB.Click += filter_packageB_Click;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(12, 349);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(208, 27);
            checkBox6.TabIndex = 53;
            checkBox6.Text = "150,000-200,000 BDT";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 316);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(208, 27);
            checkBox5.TabIndex = 52;
            checkBox5.Text = "100,000-150,000 BDT";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 283);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(198, 27);
            checkBox4.TabIndex = 51;
            checkBox4.Text = "80,000-100,000 BDT";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 250);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(188, 27);
            checkBox3.TabIndex = 50;
            checkBox3.Text = "50,000-80,000 BDT";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 217);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(188, 27);
            checkBox2.TabIndex = 49;
            checkBox2.Text = "30,000-50,000 BDT";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 137);
            label1.Name = "label1";
            label1.Size = new Size(162, 23);
            label1.TabIndex = 48;
            label1.Text = "Select Price Range ";
            // 
            // CB1
            // 
            CB1.AutoSize = true;
            CB1.Location = new Point(12, 184);
            CB1.Name = "CB1";
            CB1.Size = new Size(188, 27);
            CB1.TabIndex = 47;
            CB1.Text = "10,000-30,000 BDT";
            CB1.UseVisualStyleBackColor = true;
            // 
            // accountB
            // 
            accountB.FlatStyle = FlatStyle.Popup;
            accountB.Location = new Point(41, 776);
            accountB.Name = "accountB";
            accountB.Size = new Size(94, 29);
            accountB.TabIndex = 1;
            accountB.Text = "Account";
            accountB.UseVisualStyleBackColor = true;
            accountB.Click += accountB_Click;
            // 
            // HomeB
            // 
            HomeB.FlatStyle = FlatStyle.Popup;
            HomeB.Location = new Point(41, 84);
            HomeB.Name = "HomeB";
            HomeB.Size = new Size(94, 29);
            HomeB.TabIndex = 0;
            HomeB.Text = "Home";
            HomeB.UseVisualStyleBackColor = true;
            HomeB.Click += HomeB_Click;
            // 
            // CustomerHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1458, 835);
            Controls.Add(customerpanel);
            Controls.Add(customerflowLayoutPanel);
            Controls.Add(label2);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerHomePage";
            Load += CustomerHomePage_Load;
            customerpanel.ResumeLayout(false);
            customerpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackL;
        private Label label2;
        private FlowLayoutPanel customerflowLayoutPanel;
        private Panel customerpanel;
        private Button HomeB;
        private Button accountB;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label1;
        private CheckBox CB1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private Button filter_packageB;
        private Button custompackageB;
    }
}