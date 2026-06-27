namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    partial class After_sales_Request
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
            txtReason = new TextBox();
            txtoid = new TextBox();
            lblOid = new Label();
            lblReason = new Label();
            lbltype = new Label();
            cmbtype = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            tital = new Label();
            lblfID = new Label();
            txtfID = new TextBox();
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.Location = new Point(78, 135);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(246, 81);
            txtReason.TabIndex = 0;
            // 
            // txtoid
            // 
            txtoid.Location = new Point(78, 44);
            txtoid.Name = "txtoid";
            txtoid.ReadOnly = true;
            txtoid.Size = new Size(100, 23);
            txtoid.TabIndex = 1;
            // 
            // lblOid
            // 
            lblOid.AutoSize = true;
            lblOid.Location = new Point(9, 47);
            lblOid.Name = "lblOid";
            lblOid.Size = new Size(63, 17);
            lblOid.TabIndex = 2;
            lblOid.Text = "OrderID :";
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(14, 135);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(58, 17);
            lblReason.TabIndex = 3;
            lblReason.Text = "Reason :";
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Location = new Point(29, 104);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(43, 17);
            lbltype.TabIndex = 4;
            lbltype.Text = "Type :";
            // 
            // cmbtype
            // 
            cmbtype.FormattingEnabled = true;
            cmbtype.Items.AddRange(new object[] { "Refund", "Replace" });
            cmbtype.Location = new Point(78, 104);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(121, 25);
            cmbtype.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSubmit.Location = new Point(261, 237);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(9, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tital
            // 
            tital.AutoSize = true;
            tital.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tital.Location = new Point(50, 4);
            tital.Name = "tital";
            tital.Size = new Size(248, 31);
            tital.TabIndex = 8;
            tital.Text = "After sales Request";
            // 
            // lblfID
            // 
            lblfID.AutoSize = true;
            lblfID.Location = new Point(40, 75);
            lblfID.Name = "lblfID";
            lblfID.Size = new Size(32, 17);
            lblfID.TabIndex = 10;
            lblfID.Text = "fID :";
            // 
            // txtfID
            // 
            txtfID.Location = new Point(78, 75);
            txtfID.Name = "txtfID";
            txtfID.ReadOnly = true;
            txtfID.Size = new Size(100, 23);
            txtfID.TabIndex = 9;
            // 
            // After_sales_Request
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 291);
            Controls.Add(lblfID);
            Controls.Add(txtfID);
            Controls.Add(tital);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbtype);
            Controls.Add(lbltype);
            Controls.Add(lblReason);
            Controls.Add(lblOid);
            Controls.Add(txtoid);
            Controls.Add(txtReason);
            Name = "After_sales_Request";
            Text = "After_sales_Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReason;
        private TextBox txtoid;
        private Label lblOid;
        private Label lblReason;
        private Label lbltype;
        private ComboBox cmbtype;
        private Button btnSubmit;
        private Button btnCancel;
        private Label tital;
        private Label lblfID;
        private TextBox txtfID;
    }
}