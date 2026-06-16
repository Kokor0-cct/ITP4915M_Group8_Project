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
            llblBack = new LinkLabel();
            lblTitle = new Label();
            lblProductDESC = new Label();
            lblPrice = new Label();
            btnAddToCart = new Button();
            picProduct = new PictureBox();
            lblStock = new Label();
            numNumOfProduct = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumOfProduct).BeginInit();
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
            // llblBack
            // 
            llblBack.AutoSize = true;
            llblBack.Location = new Point(16, 72);
            llblBack.Name = "llblBack";
            llblBack.Size = new Size(58, 17);
            llblBack.TabIndex = 2;
            llblBack.TabStop = true;
            llblBack.Text = "<< Back";
            llblBack.LinkClicked += llblBack_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Silver;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(371, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "lblTitle";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductDESC
            // 
            lblProductDESC.BackColor = Color.Silver;
            lblProductDESC.Location = new Point(371, 181);
            lblProductDESC.Name = "lblProductDESC";
            lblProductDESC.Size = new Size(621, 86);
            lblProductDESC.TabIndex = 4;
            lblProductDESC.Text = "lblProductDESC";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Silver;
            lblPrice.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblPrice.Location = new Point(869, 347);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 27);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "lblPrice";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(794, 507);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(231, 51);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // picProduct
            // 
            picProduct.BackColor = Color.Silver;
            picProduct.Location = new Point(80, 119);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(255, 255);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 8;
            picProduct.TabStop = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Silver;
            lblStock.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblStock.Location = new Point(371, 355);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 17);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock :";
            // 
            // numNumOfProduct
            // 
            numNumOfProduct.Location = new Point(794, 478);
            numNumOfProduct.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numNumOfProduct.Name = "numNumOfProduct";
            numNumOfProduct.Size = new Size(231, 23);
            numNumOfProduct.TabIndex = 10;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 581);
            Controls.Add(numNumOfProduct);
            Controls.Add(lblStock);
            Controls.Add(picProduct);
            Controls.Add(btnAddToCart);
            Controls.Add(lblPrice);
            Controls.Add(lblProductDESC);
            Controls.Add(lblTitle);
            Controls.Add(llblBack);
            Controls.Add(labProductBack);
            Controls.Add(lblback);
            Name = "ProductDetail";
            Text = "ProductDetail";
            Load += ProductDetail_Load;
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumOfProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblback;
        private Label labProductBack;
        private LinkLabel llblBack;
        private Label lblTitle;
        private Label lblProductDESC;
        private Label lblPrice;
        private Button btnAddToCart;
        private PictureBox picProduct;
        private Label lblStock;
        private NumericUpDown numNumOfProduct;
    }
}