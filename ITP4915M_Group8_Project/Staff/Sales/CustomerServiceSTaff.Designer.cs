namespace ITP4915M_Group8_Project.Staff.Sales
{
    partial class CustomerServiceSTaff
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
            linlblBack = new LinkLabel();
            btnSend = new Button();
            txtSendMsg = new TextBox();
            lblTaital = new Label();
            flpChatPanel = new FlowLayoutPanel();
            label1 = new Label();
            flpCustomerContactList = new FlowLayoutPanel();
            label2 = new Label();
            lblCustomerContactList = new Label();
            SuspendLayout();
            // 
            // linlblBack
            // 
            linlblBack.AutoSize = true;
            linlblBack.Location = new Point(12, 9);
            linlblBack.Name = "linlblBack";
            linlblBack.Size = new Size(54, 17);
            linlblBack.TabIndex = 11;
            linlblBack.TabStop = true;
            linlblBack.Text = "<<Back";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(874, 405);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(107, 28);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send Msg";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // txtSendMsg
            // 
            txtSendMsg.BorderStyle = BorderStyle.FixedSingle;
            txtSendMsg.Location = new Point(324, 330);
            txtSendMsg.Multiline = true;
            txtSendMsg.Name = "txtSendMsg";
            txtSendMsg.Size = new Size(657, 70);
            txtSendMsg.TabIndex = 9;
            txtSendMsg.Text = "Please edit your requirements.";
            // 
            // lblTaital
            // 
            lblTaital.AutoSize = true;
            lblTaital.Font = new Font("Noto Sans SC", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTaital.Location = new Point(355, 9);
            lblTaital.Name = "lblTaital";
            lblTaital.Size = new Size(268, 42);
            lblTaital.TabIndex = 8;
            lblTaital.Text = "Customer Service";
            // 
            // flpChatPanel
            // 
            flpChatPanel.AutoScroll = true;
            flpChatPanel.FlowDirection = FlowDirection.TopDown;
            flpChatPanel.Location = new Point(314, 79);
            flpChatPanel.Name = "flpChatPanel";
            flpChatPanel.Size = new Size(677, 245);
            flpChatPanel.TabIndex = 7;
            flpChatPanel.WrapContents = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Noto Sans SC", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(301, 76);
            label1.Name = "label1";
            label1.Size = new Size(700, 369);
            label1.TabIndex = 12;
            // 
            // flpCustomerContactList
            // 
            flpCustomerContactList.Location = new Point(45, 88);
            flpCustomerContactList.Name = "flpCustomerContactList";
            flpCustomerContactList.Size = new Size(228, 345);
            flpCustomerContactList.TabIndex = 13;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Noto Sans SC", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(38, 76);
            label2.Name = "label2";
            label2.Size = new Size(242, 369);
            label2.TabIndex = 14;
            // 
            // lblCustomerContactList
            // 
            lblCustomerContactList.AutoSize = true;
            lblCustomerContactList.Font = new Font("Noto Sans SC", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCustomerContactList.Location = new Point(45, 65);
            lblCustomerContactList.Name = "lblCustomerContactList";
            lblCustomerContactList.Size = new Size(162, 20);
            lblCustomerContactList.TabIndex = 15;
            lblCustomerContactList.Text = "Customer Contact List";
            // 
            // CustomerServiceSTaff
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 474);
            Controls.Add(flpCustomerContactList);
            Controls.Add(lblCustomerContactList);
            Controls.Add(label2);
            Controls.Add(linlblBack);
            Controls.Add(btnSend);
            Controls.Add(txtSendMsg);
            Controls.Add(lblTaital);
            Controls.Add(flpChatPanel);
            Controls.Add(label1);
            Name = "CustomerServiceSTaff";
            Text = "CustomerServiceSTaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linlblBack;
        private Button btnSend;
        private TextBox txtSendMsg;
        private Label lblTaital;
        private FlowLayoutPanel flpChatPanel;
        private Label label1;
        private FlowLayoutPanel flpCustomerContactList;
        private Label label2;
        private Label lblCustomerContactList;
    }
}