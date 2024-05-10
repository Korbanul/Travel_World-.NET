namespace Travel_World
{
    partial class ChangePass
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
            currentpass = new Label();
            full_nameL = new Label();
            change_password_confirmB = new Button();
            CurrentPassTB = new TextBox();
            newpassTB = new TextBox();
            SuspendLayout();
            // 
            // currentpass
            // 
            currentpass.AutoEllipsis = true;
            currentpass.AutoSize = true;
            currentpass.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            currentpass.ForeColor = Color.Cyan;
            currentpass.Location = new Point(31, 101);
            currentpass.Name = "currentpass";
            currentpass.Size = new Size(173, 23);
            currentpass.TabIndex = 4;
            currentpass.Text = "Current Password: ";
            // 
            // full_nameL
            // 
            full_nameL.AutoEllipsis = true;
            full_nameL.AutoSize = true;
            full_nameL.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            full_nameL.ForeColor = Color.Cyan;
            full_nameL.Location = new Point(60, 170);
            full_nameL.Name = "full_nameL";
            full_nameL.Size = new Size(144, 23);
            full_nameL.TabIndex = 5;
            full_nameL.Text = "New Password: ";
            // 
            // change_password_confirmB
            // 
            change_password_confirmB.FlatStyle = FlatStyle.Popup;
            change_password_confirmB.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            change_password_confirmB.ForeColor = Color.Cyan;
            change_password_confirmB.Location = new Point(243, 276);
            change_password_confirmB.Name = "change_password_confirmB";
            change_password_confirmB.Size = new Size(159, 32);
            change_password_confirmB.TabIndex = 12;
            change_password_confirmB.Text = "Confirm";
            change_password_confirmB.UseVisualStyleBackColor = true;
            change_password_confirmB.Click += change_password_confirmB_Click;
            // 
            // CurrentPassTB
            // 
            CurrentPassTB.BackColor = Color.FromArgb(46, 64, 83);
            CurrentPassTB.ForeColor = Color.White;
            CurrentPassTB.Location = new Point(198, 100);
            CurrentPassTB.Multiline = true;
            CurrentPassTB.Name = "CurrentPassTB";
            CurrentPassTB.Size = new Size(255, 36);
            CurrentPassTB.TabIndex = 41;
            // 
            // newpassTB
            // 
            newpassTB.BackColor = Color.FromArgb(46, 64, 83);
            newpassTB.ForeColor = Color.White;
            newpassTB.Location = new Point(198, 170);
            newpassTB.Multiline = true;
            newpassTB.Name = "newpassTB";
            newpassTB.Size = new Size(255, 36);
            newpassTB.TabIndex = 42;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(620, 418);
            Controls.Add(newpassTB);
            Controls.Add(CurrentPassTB);
            Controls.Add(change_password_confirmB);
            Controls.Add(full_nameL);
            Controls.Add(currentpass);
            ForeColor = Color.White;
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CahngePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentpass;
        private Label full_nameL;
        private Button change_password_confirmB;
        private TextBox CurrentPassTB;
        private TextBox newpassTB;
    }
}