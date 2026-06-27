namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    partial class chatboxCC
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            lblWHO = new Label();
            txtMSG = new TextBox();
            lblDate = new Label();
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // lblWHO
            // 
            lblWHO.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblWHO.Location = new Point(84, 20);
            lblWHO.Name = "lblWHO";
            lblWHO.Size = new Size(304, 23);
            lblWHO.TabIndex = 0;
            lblWHO.Text = "customer service";
            // 
            // txtMSG
            // 
            txtMSG.Location = new Point(84, 46);
            txtMSG.Multiline = true;
            txtMSG.Name = "txtMSG";
            txtMSG.ReadOnly = true;
            txtMSG.Size = new Size(468, 61);
            txtMSG.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(84, 110);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(43, 17);
            lblDate.TabIndex = 4;
            lblDate.Text = "label1";
            // 
            // picBox
            // 
            picBox.Location = new Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(603, 149);
            picBox.TabIndex = 5;
            picBox.TabStop = false;
            // 
            // chatboxCC
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDate);
            Controls.Add(txtMSG);
            Controls.Add(lblWHO);
            Controls.Add(picBox);
            Name = "chatboxCC";
            Size = new Size(603, 149);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWHO;
        private TextBox txtMSG;
        private Label lblDate;
        private PictureBox picBox;
    }
}
