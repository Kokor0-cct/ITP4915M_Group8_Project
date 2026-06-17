namespace ITP4915M_Group8_Project.Customer
{
    partial class CustomerMenu
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
            lblback = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblMsg = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(12, 91);
            lblback.Name = "lblback";
            lblback.Size = new Size(776, 350);
            lblback.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(82, 140);
            button1.Name = "button1";
            button1.Size = new Size(193, 64);
            button1.TabIndex = 1;
            button1.Text = "Browse products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(460, 140);
            button2.Name = "button2";
            button2.Size = new Size(193, 64);
            button2.TabIndex = 2;
            button2.Text = "shopping cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(82, 327);
            button3.Name = "button3";
            button3.Size = new Size(193, 64);
            button3.TabIndex = 3;
            button3.Text = "My Orders";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(460, 233);
            button4.Name = "button4";
            button4.Size = new Size(193, 64);
            button4.TabIndex = 4;
            button4.Text = "Customized products";
            button4.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(12, 61);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(24, 17);
            lblMsg.TabIndex = 5;
            lblMsg.Text = "HI,";
            // 
            // button6
            // 
            button6.Location = new Point(82, 233);
            button6.Name = "button6";
            button6.Size = new Size(193, 64);
            button6.TabIndex = 7;
            button6.Text = "Problem Feedback";
            button6.UseVisualStyleBackColor = true;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(lblMsg);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblback);
            Name = "CustomerMenu";
            Text = "CustomerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblback;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblMsg;
        private Button button6;
    }
}