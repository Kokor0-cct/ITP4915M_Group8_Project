namespace ITP4915M_Group8_Project.Customer
{
    partial class Product_page
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
            flpMainProduct = new FlowLayoutPanel();
            btnCheckOut = new Button();
            btnSortName = new Button();
            btnSortStock = new Button();
            btnSortPrice = new Button();
            cbofType = new ComboBox();
            SuspendLayout();
            // 
            // flpMainProduct
            // 
            flpMainProduct.AutoScroll = true;
            flpMainProduct.Location = new Point(124, 98);
            flpMainProduct.Name = "flpMainProduct";
            flpMainProduct.Size = new Size(825, 406);
            flpMainProduct.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(913, 512);
            btnCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(126, 42);
            btnCheckOut.TabIndex = 23;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnSortName
            // 
            btnSortName.Location = new Point(712, 69);
            btnSortName.Name = "btnSortName";
            btnSortName.Size = new Size(75, 23);
            btnSortName.TabIndex = 24;
            btnSortName.Text = "↓ Name";
            btnSortName.UseVisualStyleBackColor = true;
            btnSortName.Click += btnSortName_Click;
            // 
            // btnSortStock
            // 
            btnSortStock.Location = new Point(793, 69);
            btnSortStock.Name = "btnSortStock";
            btnSortStock.Size = new Size(75, 23);
            btnSortStock.TabIndex = 25;
            btnSortStock.Text = "↓ Stock";
            btnSortStock.UseVisualStyleBackColor = true;
            btnSortStock.Click += btnSortStock_Click_1;
            // 
            // btnSortPrice
            // 
            btnSortPrice.Location = new Point(874, 69);
            btnSortPrice.Name = "btnSortPrice";
            btnSortPrice.Size = new Size(75, 23);
            btnSortPrice.TabIndex = 26;
            btnSortPrice.Text = "↓ Price";
            btnSortPrice.UseVisualStyleBackColor = true;
            btnSortPrice.Click += btnSortPrice_Click_1;
            // 
            // cbofType
            // 
            cbofType.FormattingEnabled = true;
            cbofType.Location = new Point(124, 67);
            cbofType.Name = "cbofType";
            cbofType.Size = new Size(227, 25);
            cbofType.TabIndex = 27;
            cbofType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Product_page
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 581);
            Controls.Add(cbofType);
            Controls.Add(btnSortPrice);
            Controls.Add(btnSortStock);
            Controls.Add(btnSortName);
            Controls.Add(btnCheckOut);
            Controls.Add(flpMainProduct);
            Name = "Product_page";
            Text = "Product_page";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMainProduct;
        private Button btnCheckOut;
        private Button btnSortName;
        private Button btnSortStock;
        private Button btnSortPrice;
        private ComboBox cbofType;
    }
}