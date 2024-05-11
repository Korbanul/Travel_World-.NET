namespace Travel_World
{
    partial class AdminDashbord
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            adminL = new Label();
            BackL = new Button();
            showalladminsB = new Button();
            admindatagrid = new DataGridView();
            showallagenciesB = new Button();
            button1 = new Button();
            showallpackage = new Button();
            totaladminP = new Panel();
            totaladminL = new Label();
            Ad = new Label();
            total_customerP = new Panel();
            total_customerL = new Label();
            C = new Label();
            total_agenciesP = new Panel();
            total_agenciesL = new Label();
            A = new Label();
            total_packagesP = new Panel();
            total_packagesL = new Label();
            P = new Label();
            balanceP = new Panel();
            balanceL = new Label();
            B = new Label();
            searchbox = new TextBox();
            label2 = new Label();
            agenciesRB = new RadioButton();
            customerRB = new RadioButton();
            adminRB = new RadioButton();
            packageRB = new RadioButton();
            searchB = new Button();
            deleteB = new Button();
            updateB = new Button();
            transactionB = new Button();
            custompackageB = new Button();
            transactionRB = new RadioButton();
            custompackageRB = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)admindatagrid).BeginInit();
            totaladminP.SuspendLayout();
            total_customerP.SuspendLayout();
            total_agenciesP.SuspendLayout();
            total_packagesP.SuspendLayout();
            balanceP.SuspendLayout();
            SuspendLayout();
            // 
            // adminL
            // 
            adminL.AutoSize = true;
            adminL.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            adminL.ForeColor = Color.FromArgb(0, 192, 0);
            adminL.Location = new Point(623, 12);
            adminL.Name = "adminL";
            adminL.Size = new Size(205, 28);
            adminL.TabIndex = 15;
            adminL.Text = "Admin Dashboard";
            // 
            // BackL
            // 
            BackL.FlatStyle = FlatStyle.Popup;
            BackL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            BackL.ForeColor = Color.Red;
            BackL.Location = new Point(12, 12);
            BackL.Name = "BackL";
            BackL.Size = new Size(76, 38);
            BackL.TabIndex = 45;
            BackL.Text = "Back";
            BackL.UseVisualStyleBackColor = true;
            BackL.Click += BackL_Click;
            // 
            // showalladminsB
            // 
            showalladminsB.BackColor = Color.Transparent;
            showalladminsB.FlatStyle = FlatStyle.Popup;
            showalladminsB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            showalladminsB.ForeColor = Color.FromArgb(65, 122, 140);
            showalladminsB.Location = new Point(12, 339);
            showalladminsB.Name = "showalladminsB";
            showalladminsB.Size = new Size(196, 44);
            showalladminsB.TabIndex = 47;
            showalladminsB.Text = "Show All Admins";
            showalladminsB.UseVisualStyleBackColor = false;
            showalladminsB.Click += showalladminsB_Click;
            // 
            // admindatagrid
            // 
            admindatagrid.AllowUserToOrderColumns = true;
            admindatagrid.BackgroundColor = SystemColors.GradientActiveCaption;
            admindatagrid.BorderStyle = BorderStyle.None;
            admindatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            admindatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            admindatagrid.DefaultCellStyle = dataGridViewCellStyle1;
            admindatagrid.GridColor = Color.DimGray;
            admindatagrid.Location = new Point(229, 312);
            admindatagrid.Name = "admindatagrid";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            admindatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            admindatagrid.RowHeadersWidth = 51;
            admindatagrid.Size = new Size(1220, 472);
            admindatagrid.TabIndex = 46;
            admindatagrid.CellContentClick += admindatagrid_CellContentClick;
            // 
            // showallagenciesB
            // 
            showallagenciesB.BackColor = Color.Transparent;
            showallagenciesB.FlatStyle = FlatStyle.Popup;
            showallagenciesB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            showallagenciesB.ForeColor = Color.FromArgb(65, 122, 140);
            showallagenciesB.Location = new Point(11, 389);
            showallagenciesB.Name = "showallagenciesB";
            showallagenciesB.Size = new Size(196, 44);
            showallagenciesB.TabIndex = 48;
            showallagenciesB.Text = "Show All Customers";
            showallagenciesB.UseVisualStyleBackColor = false;
            showallagenciesB.Click += showallagenciesB_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(65, 122, 140);
            button1.Location = new Point(11, 439);
            button1.Name = "button1";
            button1.Size = new Size(196, 44);
            button1.TabIndex = 49;
            button1.Text = "Show All Agencies";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showallpackage
            // 
            showallpackage.BackColor = Color.Transparent;
            showallpackage.FlatStyle = FlatStyle.Popup;
            showallpackage.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            showallpackage.ForeColor = Color.FromArgb(65, 122, 140);
            showallpackage.Location = new Point(11, 489);
            showallpackage.Name = "showallpackage";
            showallpackage.Size = new Size(196, 44);
            showallpackage.TabIndex = 50;
            showallpackage.Text = "Show All Packages";
            showallpackage.UseVisualStyleBackColor = false;
            showallpackage.Click += showallpackage_Click;
            // 
            // totaladminP
            // 
            totaladminP.BorderStyle = BorderStyle.Fixed3D;
            totaladminP.Controls.Add(totaladminL);
            totaladminP.Controls.Add(Ad);
            totaladminP.ForeColor = Color.Chartreuse;
            totaladminP.Location = new Point(196, 86);
            totaladminP.Name = "totaladminP";
            totaladminP.Size = new Size(168, 114);
            totaladminP.TabIndex = 51;
            // 
            // totaladminL
            // 
            totaladminL.AutoSize = true;
            totaladminL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totaladminL.Location = new Point(69, 40);
            totaladminL.Name = "totaladminL";
            totaladminL.Size = new Size(27, 31);
            totaladminL.TabIndex = 4;
            totaladminL.Text = "0";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ad.Location = new Point(16, 0);
            Ad.Name = "Ad";
            Ad.Size = new Size(101, 31);
            Ad.TabIndex = 0;
            Ad.Text = "Admin's";
            // 
            // total_customerP
            // 
            total_customerP.BorderStyle = BorderStyle.Fixed3D;
            total_customerP.Controls.Add(total_customerL);
            total_customerP.Controls.Add(C);
            total_customerP.ForeColor = Color.Chartreuse;
            total_customerP.Location = new Point(427, 86);
            total_customerP.Name = "total_customerP";
            total_customerP.Size = new Size(168, 114);
            total_customerP.TabIndex = 52;
            // 
            // total_customerL
            // 
            total_customerL.AutoSize = true;
            total_customerL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_customerL.Location = new Point(69, 40);
            total_customerL.Name = "total_customerL";
            total_customerL.Size = new Size(27, 31);
            total_customerL.TabIndex = 3;
            total_customerL.Text = "0";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.Location = new Point(13, 9);
            C.Name = "C";
            C.Size = new Size(133, 31);
            C.TabIndex = 1;
            C.Text = "Customer's";
            // 
            // total_agenciesP
            // 
            total_agenciesP.BorderStyle = BorderStyle.Fixed3D;
            total_agenciesP.Controls.Add(total_agenciesL);
            total_agenciesP.Controls.Add(A);
            total_agenciesP.ForeColor = Color.Chartreuse;
            total_agenciesP.Location = new Point(641, 88);
            total_agenciesP.Name = "total_agenciesP";
            total_agenciesP.Size = new Size(168, 114);
            total_agenciesP.TabIndex = 53;
            // 
            // total_agenciesL
            // 
            total_agenciesL.AutoSize = true;
            total_agenciesL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_agenciesL.Location = new Point(69, 40);
            total_agenciesL.Name = "total_agenciesL";
            total_agenciesL.Size = new Size(27, 31);
            total_agenciesL.TabIndex = 2;
            total_agenciesL.Text = "0";
            // 
            // A
            // 
            A.AutoSize = true;
            A.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A.Location = new Point(24, 0);
            A.Name = "A";
            A.Size = new Size(110, 31);
            A.TabIndex = 0;
            A.Text = "Agencies";
            // 
            // total_packagesP
            // 
            total_packagesP.BorderStyle = BorderStyle.Fixed3D;
            total_packagesP.Controls.Add(total_packagesL);
            total_packagesP.Controls.Add(P);
            total_packagesP.ForeColor = Color.Chartreuse;
            total_packagesP.Location = new Point(871, 90);
            total_packagesP.Name = "total_packagesP";
            total_packagesP.Size = new Size(168, 114);
            total_packagesP.TabIndex = 54;
            // 
            // total_packagesL
            // 
            total_packagesL.AutoSize = true;
            total_packagesL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_packagesL.Location = new Point(65, 43);
            total_packagesL.Name = "total_packagesL";
            total_packagesL.Size = new Size(27, 31);
            total_packagesL.TabIndex = 1;
            total_packagesL.Text = "0";
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P.Location = new Point(24, 0);
            P.Name = "P";
            P.Size = new Size(115, 31);
            P.TabIndex = 0;
            P.Text = "Package's";
            // 
            // balanceP
            // 
            balanceP.BorderStyle = BorderStyle.Fixed3D;
            balanceP.Controls.Add(balanceL);
            balanceP.Controls.Add(B);
            balanceP.ForeColor = Color.Chartreuse;
            balanceP.Location = new Point(1102, 90);
            balanceP.Name = "balanceP";
            balanceP.Size = new Size(168, 114);
            balanceP.TabIndex = 55;
            // 
            // balanceL
            // 
            balanceL.AutoSize = true;
            balanceL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balanceL.Location = new Point(24, 43);
            balanceL.Name = "balanceL";
            balanceL.Size = new Size(46, 31);
            balanceL.TabIndex = 1;
            balanceL.Text = "$ 0";
            // 
            // B
            // 
            B.AutoSize = true;
            B.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B.Location = new Point(24, 0);
            B.Name = "B";
            B.Size = new Size(97, 31);
            B.TabIndex = 0;
            B.Text = "Balance";
            // 
            // searchbox
            // 
            searchbox.BackColor = Color.FromArgb(41, 44, 51);
            searchbox.ForeColor = Color.FromArgb(65, 122, 140);
            searchbox.Location = new Point(129, 227);
            searchbox.Multiline = true;
            searchbox.Name = "searchbox";
            searchbox.PlaceholderText = "Enter id";
            searchbox.Size = new Size(221, 34);
            searchbox.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(65, 122, 140);
            label2.Location = new Point(-2, 283);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 61;
            label2.Text = "User Type";
            // 
            // agenciesRB
            // 
            agenciesRB.AutoSize = true;
            agenciesRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            agenciesRB.ForeColor = Color.FromArgb(62, 120, 138);
            agenciesRB.Location = new Point(332, 279);
            agenciesRB.Name = "agenciesRB";
            agenciesRB.Size = new Size(105, 27);
            agenciesRB.TabIndex = 60;
            agenciesRB.TabStop = true;
            agenciesRB.Text = "Agencies";
            agenciesRB.UseVisualStyleBackColor = true;
            // 
            // customerRB
            // 
            customerRB.AutoSize = true;
            customerRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            customerRB.ForeColor = Color.FromArgb(62, 120, 138);
            customerRB.Location = new Point(204, 279);
            customerRB.Name = "customerRB";
            customerRB.Size = new Size(111, 27);
            customerRB.TabIndex = 59;
            customerRB.TabStop = true;
            customerRB.Text = "Customer";
            customerRB.UseVisualStyleBackColor = true;
            // 
            // adminRB
            // 
            adminRB.AutoSize = true;
            adminRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            adminRB.ForeColor = Color.FromArgb(62, 120, 138);
            adminRB.Location = new Point(94, 279);
            adminRB.Name = "adminRB";
            adminRB.Size = new Size(84, 27);
            adminRB.TabIndex = 58;
            adminRB.TabStop = true;
            adminRB.Text = "Admin";
            adminRB.UseVisualStyleBackColor = true;
            // 
            // packageRB
            // 
            packageRB.AutoSize = true;
            packageRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            packageRB.ForeColor = Color.FromArgb(62, 120, 138);
            packageRB.Location = new Point(449, 279);
            packageRB.Name = "packageRB";
            packageRB.Size = new Size(103, 27);
            packageRB.TabIndex = 62;
            packageRB.TabStop = true;
            packageRB.Text = "Package";
            packageRB.UseVisualStyleBackColor = true;
            // 
            // searchB
            // 
            searchB.BackColor = Color.Transparent;
            searchB.FlatStyle = FlatStyle.Popup;
            searchB.ForeColor = Color.FromArgb(65, 122, 140);
            searchB.Location = new Point(12, 227);
            searchB.Name = "searchB";
            searchB.Size = new Size(94, 29);
            searchB.TabIndex = 63;
            searchB.Text = "Search";
            searchB.UseVisualStyleBackColor = false;
            searchB.Click += searchB_Click;
            // 
            // deleteB
            // 
            deleteB.FlatStyle = FlatStyle.Popup;
            deleteB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            deleteB.ForeColor = Color.FromArgb(65, 122, 140);
            deleteB.Location = new Point(12, 692);
            deleteB.Name = "deleteB";
            deleteB.Size = new Size(94, 35);
            deleteB.TabIndex = 64;
            deleteB.Text = "Delete";
            deleteB.UseVisualStyleBackColor = true;
            deleteB.Click += deleteB_Click;
            // 
            // updateB
            // 
            updateB.FlatStyle = FlatStyle.Popup;
            updateB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            updateB.ForeColor = Color.FromArgb(65, 122, 140);
            updateB.Location = new Point(129, 692);
            updateB.Name = "updateB";
            updateB.Size = new Size(94, 35);
            updateB.TabIndex = 65;
            updateB.Text = "Update";
            updateB.UseVisualStyleBackColor = true;
            updateB.Click += updateB_Click;
            // 
            // transactionB
            // 
            transactionB.BackColor = Color.Transparent;
            transactionB.FlatStyle = FlatStyle.Popup;
            transactionB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            transactionB.ForeColor = Color.FromArgb(65, 122, 140);
            transactionB.Location = new Point(11, 539);
            transactionB.Name = "transactionB";
            transactionB.Size = new Size(196, 44);
            transactionB.TabIndex = 66;
            transactionB.Text = "Show All Transaction";
            transactionB.UseVisualStyleBackColor = false;
            transactionB.Click += transactionB_Click;
            // 
            // custompackageB
            // 
            custompackageB.BackColor = Color.Transparent;
            custompackageB.FlatStyle = FlatStyle.Popup;
            custompackageB.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            custompackageB.ForeColor = Color.FromArgb(65, 122, 140);
            custompackageB.Location = new Point(12, 589);
            custompackageB.Name = "custompackageB";
            custompackageB.Size = new Size(211, 44);
            custompackageB.TabIndex = 67;
            custompackageB.Text = "Show All Custom Packages ";
            custompackageB.UseVisualStyleBackColor = false;
            custompackageB.Click += custompackageB_Click;
            // 
            // transactionRB
            // 
            transactionRB.AutoSize = true;
            transactionRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            transactionRB.ForeColor = Color.FromArgb(62, 120, 138);
            transactionRB.Location = new Point(570, 279);
            transactionRB.Name = "transactionRB";
            transactionRB.Size = new Size(132, 27);
            transactionRB.TabIndex = 68;
            transactionRB.TabStop = true;
            transactionRB.Text = "Transaction";
            transactionRB.UseVisualStyleBackColor = true;
            // 
            // custompackageRB
            // 
            custompackageRB.AutoSize = true;
            custompackageRB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic);
            custompackageRB.ForeColor = Color.FromArgb(62, 120, 138);
            custompackageRB.Location = new Point(712, 280);
            custompackageRB.Name = "custompackageRB";
            custompackageRB.Size = new Size(170, 27);
            custompackageRB.TabIndex = 69;
            custompackageRB.TabStop = true;
            custompackageRB.Text = "Custom Package";
            custompackageRB.UseVisualStyleBackColor = true;
            // 
            // AdminDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1455, 796);
            Controls.Add(custompackageRB);
            Controls.Add(transactionRB);
            Controls.Add(custompackageB);
            Controls.Add(transactionB);
            Controls.Add(updateB);
            Controls.Add(deleteB);
            Controls.Add(searchB);
            Controls.Add(packageRB);
            Controls.Add(label2);
            Controls.Add(agenciesRB);
            Controls.Add(customerRB);
            Controls.Add(adminRB);
            Controls.Add(searchbox);
            Controls.Add(balanceP);
            Controls.Add(total_packagesP);
            Controls.Add(total_agenciesP);
            Controls.Add(total_customerP);
            Controls.Add(totaladminP);
            Controls.Add(showallpackage);
            Controls.Add(button1);
            Controls.Add(showallagenciesB);
            Controls.Add(showalladminsB);
            Controls.Add(admindatagrid);
            Controls.Add(BackL);
            Controls.Add(adminL);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AdminDashbord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashbord";
            Load += AdminDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)admindatagrid).EndInit();
            totaladminP.ResumeLayout(false);
            totaladminP.PerformLayout();
            total_customerP.ResumeLayout(false);
            total_customerP.PerformLayout();
            total_agenciesP.ResumeLayout(false);
            total_agenciesP.PerformLayout();
            total_packagesP.ResumeLayout(false);
            total_packagesP.PerformLayout();
            balanceP.ResumeLayout(false);
            balanceP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label adminL;
        private Button BackL;
        private Button showalladminsB;
        private DataGridView admindatagrid;
        private Button showallagenciesB;
        private Button button1;
        private Button showallpackage;
        private Panel totaladminP;
        private Label Ad;
        private Panel total_customerP;
        private Label C;
        private Panel total_agenciesP;
        private Label A;
        private Panel total_packagesP;
        private Label P;
        private Label total_agenciesL;
        private Label total_packagesL;
        private Label total_customerL;
        private Label totaladminL;
        private Panel balanceP;
        private Label balanceL;
        private Label B;
        private TextBox searchbox;
        private Label label2;
        private RadioButton agenciesRB;
        private RadioButton customerRB;
        private RadioButton adminRB;
        private RadioButton packageRB;
        private Button searchB;
        private Button deleteB;
        private Button updateB;
        private Button transactionB;
        private Button custompackageB;
        private RadioButton transactionRB;
        private RadioButton custompackageRB;
    }
}