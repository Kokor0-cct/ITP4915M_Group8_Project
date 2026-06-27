namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    partial class CustomerService
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTaital = new Label();
            txtSendMsg = new TextBox();
            button2 = new Button();
            linlblBack = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(66, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(677, 245);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTaital
            // 
            lblTaital.AutoSize = true;
            lblTaital.Font = new Font("Noto Sans SC", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTaital.Location = new Point(253, 9);
            lblTaital.Name = "lblTaital";
            lblTaital.Size = new Size(268, 42);
            lblTaital.TabIndex = 1;
            lblTaital.Text = "Customer Service";
            lblTaital.Click += lblTaital_Click;
            // 
            // txtSendMsg
            // 
            txtSendMsg.BorderStyle = BorderStyle.FixedSingle;
            txtSendMsg.Location = new Point(76, 316);
            txtSendMsg.Multiline = true;
            txtSendMsg.Name = "txtSendMsg";
            txtSendMsg.Size = new Size(657, 70);
            txtSendMsg.TabIndex = 2;
            txtSendMsg.Text = "Please edit your requirements.";
            // 
            // button2
            // 
            button2.Location = new Point(626, 391);
            button2.Name = "button2";
            button2.Size = new Size(107, 28);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // linlblBack
            // 
            linlblBack.AutoSize = true;
            linlblBack.Location = new Point(2, 42);
            linlblBack.Name = "linlblBack";
            linlblBack.Size = new Size(54, 17);
            linlblBack.TabIndex = 5;
            linlblBack.TabStop = true;
            linlblBack.Text = "<<Back";
            linlblBack.LinkClicked += linlblBack_LinkClicked;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Noto Sans SC", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(53, 62);
            label1.Name = "label1";
            label1.Size = new Size(700, 369);
            label1.TabIndex = 6;
            // 
            // CustomerService
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linlblBack);
            Controls.Add(button2);
            Controls.Add(txtSendMsg);
            Controls.Add(lblTaital);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "CustomerService";
            Text = "CustomerService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTaital;
        private TextBox txtSendMsg;
        private Button button2;
        private LinkLabel linlblBack;
        private Label label1;
    }
}