namespace ITP4915M_Group8_Project.Login
{
    partial class RegisterForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NametextBox = new TextBox();
            PwtextBox = new TextBox();
            label3 = new Label();
            PhonetextBox = new TextBox();
            label4 = new Label();
            AddstextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            buttonSubmit = new Button();
            CompanyBox = new TextBox();
            label6 = new Label();
            comboBox_identity = new ComboBox();
            label8 = new Label();
            llLogin = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("PMingLiU", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            NametextBox.Location = new Point(252, 182);
            NametextBox.Margin = new Padding(2, 2, 2, 2);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(412, 36);
            NametextBox.TabIndex = 3;
            // 
            // PwtextBox
            // 
            PwtextBox.Font = new Font("PMingLiU", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            PwtextBox.Location = new Point(250, 271);
            PwtextBox.Margin = new Padding(2, 2, 2, 2);
            PwtextBox.Name = "PwtextBox";
            PwtextBox.Size = new Size(415, 36);
            PwtextBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 236);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 27);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // PhonetextBox
            // 
            PhonetextBox.Font = new Font("PMingLiU", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            PhonetextBox.Location = new Point(252, 365);
            PhonetextBox.Margin = new Padding(2, 2, 2, 2);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(412, 36);
            PhonetextBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 330);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 27);
            label4.TabIndex = 14;
            label4.Text = "Phone Number:";
            // 
            // AddstextBox
            // 
            AddstextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddstextBox.Location = new Point(250, 458);
            AddstextBox.Margin = new Padding(2, 2, 2, 2);
            AddstextBox.Name = "AddstextBox";
            AddstextBox.ScrollBars = ScrollBars.Vertical;
            AddstextBox.Size = new Size(411, 35);
            AddstextBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 422);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 16;
            label5.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(308, 108);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 19);
            label7.TabIndex = 20;
            label7.Text = "Register a new customer Accont";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(334, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 59);
            label2.TabIndex = 4;
            label2.Text = "Sign Up";
            label2.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -8);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 152);
            panel1.TabIndex = 21;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ControlLight;
            buttonSubmit.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(740, 592);
            buttonSubmit.Margin = new Padding(2, 2, 2, 2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(142, 52);
            buttonSubmit.TabIndex = 22;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // CompanyBox
            // 
            CompanyBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompanyBox.Location = new Point(252, 544);
            CompanyBox.Margin = new Padding(2, 2, 2, 2);
            CompanyBox.Name = "CompanyBox";
            CompanyBox.ScrollBars = ScrollBars.Vertical;
            CompanyBox.Size = new Size(411, 35);
            CompanyBox.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 509);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(279, 27);
            label6.TabIndex = 24;
            label6.Text = "Your Company(optional)";
            // 
            // comboBox_identity
            // 
            comboBox_identity.FormattingEnabled = true;
            comboBox_identity.Location = new Point(61, 202);
            comboBox_identity.Margin = new Padding(2, 2, 2, 2);
            comboBox_identity.Name = "comboBox_identity";
            comboBox_identity.Size = new Size(95, 23);
            comboBox_identity.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 166);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 26;
            label8.Text = "You are ?";
            // 
            // llLogin
            // 
            llLogin.AutoSize = true;
            llLogin.Location = new Point(58, 613);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(101, 15);
            llLogin.TabIndex = 27;
            llLogin.TabStop = true;
            llLogin.Text = "Have an account?";
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 679);
            Controls.Add(llLogin);
            Controls.Add(label8);
            Controls.Add(comboBox_identity);
            Controls.Add(label6);
            Controls.Add(CompanyBox);
            Controls.Add(buttonSubmit);
            Controls.Add(AddstextBox);
            Controls.Add(label5);
            Controls.Add(PhonetextBox);
            Controls.Add(label4);
            Controls.Add(PwtextBox);
            Controls.Add(label3);
            Controls.Add(NametextBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(922, 718);
            MinimumSize = new Size(922, 718);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PwtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddstextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_identity;
        private System.Windows.Forms.Label label8;
        private LinkLabel llLogin;
    }
}

