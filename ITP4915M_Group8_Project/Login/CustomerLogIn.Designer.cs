namespace ITP4915M_Group8_Project.Login
{
    partial class CustomerLogIn
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
            panel1 = new Panel();
            lblLogin = new Label();
            cboBoxIdentity = new ComboBox();
            lblIdentity = new Label();
            label3 = new Label();
            textBox_UserName = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            textBox_password = new TextBox();
            LogIn_button = new Button();
            llblRegister = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(-5, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 82);
            panel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Rockwell", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(323, 13);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(130, 43);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Log In";
            // 
            // cboBoxIdentity
            // 
            cboBoxIdentity.FormattingEnabled = true;
            cboBoxIdentity.Location = new Point(366, 123);
            cboBoxIdentity.Margin = new Padding(2);
            cboBoxIdentity.Name = "cboBoxIdentity";
            cboBoxIdentity.Size = new Size(155, 23);
            cboBoxIdentity.TabIndex = 2;
            cboBoxIdentity.SelectedIndexChanged += cboBoxIdentity_SelectedIndexChanged;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdentity.Location = new Point(243, 125);
            lblIdentity.Margin = new Padding(2, 0, 2, 0);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(84, 21);
            lblIdentity.TabIndex = 3;
            lblIdentity.Text = "Login as";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(650, 21);
            label3.TabIndex = 4;
            label3.Text = "________________________________________________________________";
            // 
            // textBox_UserName
            // 
            textBox_UserName.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_UserName.Location = new Point(241, 252);
            textBox_UserName.Margin = new Padding(2);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(310, 36);
            textBox_UserName.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(243, 212);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 21);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(243, 332);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password: ";
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_password.Location = new Point(241, 374);
            textBox_password.Margin = new Padding(2);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(310, 36);
            textBox_password.TabIndex = 7;
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = SystemColors.ControlLight;
            LogIn_button.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn_button.Location = new Point(241, 452);
            LogIn_button.Margin = new Padding(2);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(309, 40);
            LogIn_button.TabIndex = 9;
            LogIn_button.Text = "login";
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            LogIn_button.Enter += LogIn_button_Click;
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            llblRegister.Location = new Point(632, 543);
            llblRegister.Margin = new Padding(2, 0, 2, 0);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(141, 16);
            llblRegister.TabIndex = 10;
            llblRegister.TabStop = true;
            llblRegister.Text = "Register an account? ";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // CustomerLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 602);
            Controls.Add(llblRegister);
            Controls.Add(LogIn_button);
            Controls.Add(lblPassword);
            Controls.Add(textBox_password);
            Controls.Add(lblUsername);
            Controls.Add(textBox_UserName);
            Controls.Add(label3);
            Controls.Add(lblIdentity);
            Controls.Add(cboBoxIdentity);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximumSize = new Size(818, 641);
            MinimumSize = new Size(818, 641);
            Name = "CustomerLogIn";
            Text = "CustomerLogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cboBoxIdentity;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.LinkLabel llblRegister;
    }
}