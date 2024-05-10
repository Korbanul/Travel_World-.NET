namespace Travel_World
{
    partial class AgencieHomePage
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
            sidepanel = new Panel();
            bid_for_a_offer = new Button();
            accountB = new Button();
            addpackageB = new Button();
            homeB = new Button();
            flowLayoutpanel = new FlowLayoutPanel();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackL
            // 
            BackL.FlatStyle = FlatStyle.Flat;
            BackL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            BackL.ForeColor = Color.Red;
            BackL.Location = new Point(3, 3);
            BackL.Name = "BackL";
            BackL.Size = new Size(87, 38);
            BackL.TabIndex = 46;
            BackL.Text = "Back";
            BackL.UseVisualStyleBackColor = true;
            BackL.Click += BackL_Click;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.DarkSeaGreen;
            sidepanel.Controls.Add(bid_for_a_offer);
            sidepanel.Controls.Add(accountB);
            sidepanel.Controls.Add(BackL);
            sidepanel.Controls.Add(addpackageB);
            sidepanel.Controls.Add(homeB);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(250, 799);
            sidepanel.TabIndex = 47;
            // 
            // bid_for_a_offer
            // 
            bid_for_a_offer.FlatStyle = FlatStyle.Flat;
            bid_for_a_offer.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bid_for_a_offer.ForeColor = Color.WhiteSmoke;
            bid_for_a_offer.Location = new Point(44, 270);
            bid_for_a_offer.Name = "bid_for_a_offer";
            bid_for_a_offer.Size = new Size(130, 30);
            bid_for_a_offer.TabIndex = 3;
            bid_for_a_offer.Text = "Bid for a offer";
            bid_for_a_offer.UseVisualStyleBackColor = true;
            bid_for_a_offer.Click += bid_for_a_offer_Click;
            // 
            // accountB
            // 
            accountB.FlatStyle = FlatStyle.Flat;
            accountB.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            accountB.ForeColor = Color.WhiteSmoke;
            accountB.Location = new Point(44, 726);
            accountB.Name = "accountB";
            accountB.Size = new Size(130, 41);
            accountB.TabIndex = 2;
            accountB.Text = "Account";
            accountB.UseVisualStyleBackColor = true;
            accountB.Click += accountB_Click;
            // 
            // addpackageB
            // 
            addpackageB.FlatStyle = FlatStyle.Flat;
            addpackageB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addpackageB.ForeColor = Color.WhiteSmoke;
            addpackageB.Location = new Point(44, 218);
            addpackageB.Name = "addpackageB";
            addpackageB.Size = new Size(130, 35);
            addpackageB.TabIndex = 1;
            addpackageB.Text = "Add Package";
            addpackageB.UseVisualStyleBackColor = true;
            addpackageB.Click += addpackageB_Click;
            // 
            // homeB
            // 
            homeB.BackColor = Color.Transparent;
            homeB.FlatStyle = FlatStyle.Flat;
            homeB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            homeB.ForeColor = Color.WhiteSmoke;
            homeB.Location = new Point(44, 163);
            homeB.Name = "homeB";
            homeB.Size = new Size(130, 36);
            homeB.TabIndex = 0;
            homeB.Text = "Home";
            homeB.UseVisualStyleBackColor = false;
            homeB.Click += homeB_Click;
            // 
            // flowLayoutpanel
            // 
            flowLayoutpanel.AutoScroll = true;
            flowLayoutpanel.BackColor = Color.FromArgb(41, 44, 51);
            flowLayoutpanel.Dock = DockStyle.Fill;
            flowLayoutpanel.Location = new Point(250, 0);
            flowLayoutpanel.Name = "flowLayoutpanel";
            flowLayoutpanel.Size = new Size(1205, 799);
            flowLayoutpanel.TabIndex = 48;
            // 
            // AgencieHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 799);
            Controls.Add(flowLayoutpanel);
            Controls.Add(sidepanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AgencieHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgencieHomePage";
            sidepanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackL;
        private Panel sidepanel;
        private Button addpackageB;
        private Button homeB;
        private FlowLayoutPanel flowLayoutpanel;
        private Button bid_for_a_offer;
        private Button accountB;
    }
}