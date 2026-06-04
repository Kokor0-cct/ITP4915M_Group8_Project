namespace ITP4915M_Group8_Project.Login
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PwtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddstextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_identity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NametextBox.Location = new System.Drawing.Point(324, 218);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(529, 51);
            this.NametextBox.TabIndex = 3;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged_1);
            // 
            // PwtextBox
            // 
            this.PwtextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PwtextBox.Location = new System.Drawing.Point(321, 325);
            this.PwtextBox.Name = "PwtextBox";
            this.PwtextBox.Size = new System.Drawing.Size(532, 51);
            this.PwtextBox.TabIndex = 13;
            this.PwtextBox.TextChanged += new System.EventHandler(this.PwtextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhonetextBox.Location = new System.Drawing.Point(324, 438);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(529, 51);
            this.PhonetextBox.TabIndex = 15;
            this.PhonetextBox.TextChanged += new System.EventHandler(this.PhonetextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddstextBox
            // 
            this.AddstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddstextBox.Location = new System.Drawing.Point(321, 549);
            this.AddstextBox.Name = "AddstextBox";
            this.AddstextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddstextBox.Size = new System.Drawing.Size(527, 48);
            this.AddstextBox.TabIndex = 17;
            this.AddstextBox.TextChanged += new System.EventHandler(this.AddstextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(396, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "Register a new customer Accont";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(430, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 87);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sign Up";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 182);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSubmit.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(952, 710);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(182, 63);
            this.buttonSubmit.TabIndex = 22;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // CompanyBox
            // 
            this.CompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyBox.Location = new System.Drawing.Point(324, 653);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompanyBox.Size = new System.Drawing.Size(527, 48);
            this.CompanyBox.TabIndex = 23;
            this.CompanyBox.TextChanged += new System.EventHandler(this.companyBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Your Company(optional)";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // comboBox_identity
            // 
            this.comboBox_identity.FormattingEnabled = true;
            this.comboBox_identity.Location = new System.Drawing.Point(78, 243);
            this.comboBox_identity.Name = "comboBox_identity";
            this.comboBox_identity.Size = new System.Drawing.Size(121, 26);
            this.comboBox_identity.TabIndex = 25;
            this.comboBox_identity.SelectedIndexChanged += new System.EventHandler(this.comboBox_identity_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "You are ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 798);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_identity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.AddstextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PwtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1181, 854);
            this.MinimumSize = new System.Drawing.Size(1181, 854);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

