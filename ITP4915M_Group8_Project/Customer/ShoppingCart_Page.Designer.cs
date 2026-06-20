namespace ITP4915M_Group8_Project.Customer
{
    partial class ShoppingCart_Page
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
            dgvShoppingCart = new DataGridView();
            lblTitle = new Label();
            lblBack = new Label();
            btnCheckOut = new Button();
            lblTotalPrice = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblQty = new Label();
            btnUpdate = new Button();
            numQty = new NumericUpDown();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Location = new Point(57, 78);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.Size = new Size(673, 157);
            dgvShoppingCart.TabIndex = 0;
            dgvShoppingCart.SelectionChanged += dgvShoppingCart_SelectionChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(57, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Shopping Cart";
            // 
            // lblBack
            // 
            lblBack.BackColor = Color.FromArgb(224, 224, 224);
            lblBack.BorderStyle = BorderStyle.Fixed3D;
            lblBack.Location = new Point(57, 245);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(673, 118);
            lblBack.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(618, 366);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(112, 24);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTotalPrice.Location = new Point(78, 308);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(59, 22);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "label2";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 252);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 23);
            txtName.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(78, 255);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Name :";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(332, 255);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(59, 15);
            lblQty.TabIndex = 8;
            lblQty.Text = "Quantity :";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(564, 252);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 24);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // numQty
            // 
            numQty.Location = new Point(401, 253);
            numQty.Name = "numQty";
            numQty.Size = new Size(120, 23);
            numQty.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(645, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 24);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ShoppingCart_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(btnDelete);
            Controls.Add(numQty);
            Controls.Add(btnUpdate);
            Controls.Add(lblQty);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnCheckOut);
            Controls.Add(lblBack);
            Controls.Add(lblTitle);
            Controls.Add(dgvShoppingCart);
            Name = "ShoppingCart_Page";
            Text = "ShoppingCart_Page";
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShoppingCart;
        private Label lblTitle;
        private Label lblBack;
        private Button btnCheckOut;
        private Label lblTotalPrice;
        private TextBox txtName;
        private Label lblName;
        private Label lblQty;
        private Button btnUpdate;
        private NumericUpDown numQty;
        private Button btnDelete;
    }
}