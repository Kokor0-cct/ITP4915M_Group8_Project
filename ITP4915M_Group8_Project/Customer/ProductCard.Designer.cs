namespace ITP4915M_Group8_Project.Customer
{
    partial class ProductCard
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
            picImg = new PictureBox();
            lblpName = new Label();
            lblpPrice = new Label();
            lblStockText = new Label();
            btnOperate = new Button();
            lblCardBack = new Label();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            SuspendLayout();
            // 
            // picImg
            // 
            picImg.Location = new Point(7, 8);
            picImg.Name = "picImg";
            picImg.Size = new Size(180, 157);
            picImg.SizeMode = PictureBoxSizeMode.Zoom;
            picImg.TabIndex = 0;
            picImg.TabStop = false;
            // 
            // lblpName
            // 
            lblpName.AutoSize = true;
            lblpName.Location = new Point(16, 168);
            lblpName.Name = "lblpName";
            lblpName.Size = new Size(43, 17);
            lblpName.TabIndex = 1;
            lblpName.Text = "label1";
            // 
            // lblpPrice
            // 
            lblpPrice.AutoSize = true;
            lblpPrice.Location = new Point(16, 200);
            lblpPrice.Name = "lblpPrice";
            lblpPrice.Size = new Size(43, 17);
            lblpPrice.TabIndex = 2;
            lblpPrice.Text = "label2";
            // 
            // lblStockText
            // 
            lblStockText.AutoSize = true;
            lblStockText.Location = new Point(16, 227);
            lblStockText.Name = "lblStockText";
            lblStockText.Size = new Size(43, 17);
            lblStockText.TabIndex = 3;
            lblStockText.Text = "label3";
            // 
            // btnOperate
            // 
            btnOperate.Location = new Point(16, 247);
            btnOperate.Name = "btnOperate";
            btnOperate.Size = new Size(158, 38);
            btnOperate.TabIndex = 4;
            btnOperate.Text = "Porduct Info";
            btnOperate.UseVisualStyleBackColor = true;
            btnOperate.Click += btnOperate_Click_1;
            // 
            // lblCardBack
            // 
            lblCardBack.BackColor = Color.FromArgb(224, 224, 224);
            lblCardBack.Location = new Point(0, 0);
            lblCardBack.Name = "lblCardBack";
            lblCardBack.Size = new Size(194, 299);
            lblCardBack.TabIndex = 5;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOperate);
            Controls.Add(lblStockText);
            Controls.Add(lblpPrice);
            Controls.Add(lblpName);
            Controls.Add(picImg);
            Controls.Add(lblCardBack);
            Name = "ProductCard";
            Size = new Size(194, 299);
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImg;
        private Label lblpName;
        private Label lblpPrice;
        private Label lblStockText;
        private Button btnOperate;
        private Label lblCardBack;
    }
}
