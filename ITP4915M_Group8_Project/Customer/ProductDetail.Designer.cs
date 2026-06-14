namespace ITP4915M_Group8_Project.Customer
{
    partial class ProductDetail
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
            labProductBack = new Label();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.BackColor = Color.FromArgb(224, 224, 224);
            lblback.Location = new Point(-11, 59);
            lblback.Name = "lblback";
            lblback.Size = new Size(1081, 530);
            lblback.TabIndex = 0;
            // 
            // labProductBack
            // 
            labProductBack.BackColor = Color.Silver;
            labProductBack.BorderStyle = BorderStyle.Fixed3D;
            labProductBack.Location = new Point(41, 98);
            labProductBack.Name = "labProductBack";
            labProductBack.Size = new Size(984, 311);
            labProductBack.TabIndex = 1;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 581);
            Controls.Add(labProductBack);
            Controls.Add(lblback);
            Name = "ProductDetail";
            Text = "ProductDetail";
            Load += ProductDetail_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblback;
        private Label labProductBack;
    }
}