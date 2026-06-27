namespace ITP4915M_Group8_Project.Staff.Sales
{
    partial class CustomerContacts
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
            btnCustomerID = new Button();
            SuspendLayout();
            // 
            // btnCustomerID
            // 
            btnCustomerID.Location = new Point(3, 3);
            btnCustomerID.Name = "btnCustomerID";
            btnCustomerID.Size = new Size(190, 45);
            btnCustomerID.TabIndex = 0;
            btnCustomerID.Text = "button1";
            btnCustomerID.UseVisualStyleBackColor = true;
            btnCustomerID.Click += btnCustomerID_Click;
            // 
            // CustomerContacts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCustomerID);
            Name = "CustomerContacts";
            Size = new Size(199, 52);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomerID;
    }
}
