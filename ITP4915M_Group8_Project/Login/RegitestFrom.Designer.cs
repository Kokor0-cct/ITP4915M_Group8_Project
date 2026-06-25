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
            llLogin = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 167);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            NametextBox.Location = new Point(252, 206);
            NametextBox.Margin = new Padding(2);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(412, 35);
            NametextBox.TabIndex = 3;
            // 
            // PwtextBox
            // 
            PwtextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            PwtextBox.Location = new Point(250, 307);
            PwtextBox.Margin = new Padding(2);
            PwtextBox.Name = "PwtextBox";
            PwtextBox.Size = new Size(415, 35);
            PwtextBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 267);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // PhonetextBox
            // 
            PhonetextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            PhonetextBox.Location = new Point(252, 414);
            PhonetextBox.Margin = new Padding(2);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(412, 35);
            PhonetextBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 374);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 26);
            label4.TabIndex = 14;
            label4.Text = "Phone Number:";
            // 
            // AddstextBox
            // 
            AddstextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddstextBox.Location = new Point(250, 519);
            AddstextBox.Margin = new Padding(2);
            AddstextBox.Name = "AddstextBox";
            AddstextBox.ScrollBars = ScrollBars.Vertical;
            AddstextBox.Size = new Size(411, 35);
            AddstextBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 478);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 16;
            label5.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(308, 122);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(239, 20);
            label7.TabIndex = 20;
            label7.Text = "Register a new customer Accont";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(334, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 55);
            label2.TabIndex = 4;
            label2.Text = "Sign Up";
            label2.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -9);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 172);
            panel1.TabIndex = 21;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ControlLight;
            buttonSubmit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(740, 671);
            buttonSubmit.Margin = new Padding(2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(142, 59);
            buttonSubmit.TabIndex = 22;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            buttonSubmit.Enter += buttonSubmit_Click;
            // 
            // CompanyBox
            // 
            CompanyBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompanyBox.Location = new Point(252, 617);
            CompanyBox.Margin = new Padding(2);
            CompanyBox.Name = "CompanyBox";
            CompanyBox.ScrollBars = ScrollBars.Vertical;
            CompanyBox.Size = new Size(411, 35);
            CompanyBox.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 577);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(271, 26);
            label6.TabIndex = 24;
            label6.Text = "Your Company(optional)";
            // 
            // llLogin
            // 
            llLogin.AutoSize = true;
            llLogin.Location = new Point(58, 695);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(110, 17);
            llLogin.TabIndex = 27;
            llLogin.TabStop = true;
            llLogin.Text = "Have an account?";
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 770);
            Controls.Add(llLogin);
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
            Margin = new Padding(2);
            MaximumSize = new Size(922, 809);
            MinimumSize = new Size(922, 809);
            Name = "RegisterForm";
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
        private LinkLabel llLogin;
    }
}

