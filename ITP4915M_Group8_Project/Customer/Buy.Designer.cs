namespace ITP4915M_Group8_Project.customer
{
    partial class Buy
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
            btnBack = new Button();
            btnPoductCategory = new ComboBox();
            textBox1 = new TextBox();
            btnMyOrder = new Button();
            btnTailorMadeFurniture = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            btnShoppingCart = new Button();
            btnLogin = new Button();
            btnAddToShoppingCart = new Button();
            btnCheckOut = new Button();
            numUDProductQuantity = new NumericUpDown();
            lalProductQuantity = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numUDProductQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 108);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 46);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPoductCategory
            // 
            btnPoductCategory.FormattingEnabled = true;
            btnPoductCategory.Items.AddRange(new object[] { "Sofa", "Chair" });
            btnPoductCategory.Location = new Point(310, 25);
            btnPoductCategory.Margin = new Padding(4, 5, 4, 5);
            btnPoductCategory.Name = "btnPoductCategory";
            btnPoductCategory.Size = new Size(140, 25);
            btnPoductCategory.TabIndex = 20;
            btnPoductCategory.Text = "Product Category";
            btnPoductCategory.SelectedIndexChanged += btnPoductCategory_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(758, 24);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 23);
            textBox1.TabIndex = 19;
            // 
            // btnMyOrder
            // 
            btnMyOrder.Location = new Point(654, 20);
            btnMyOrder.Margin = new Padding(4, 5, 4, 5);
            btnMyOrder.Name = "btnMyOrder";
            btnMyOrder.Size = new Size(88, 33);
            btnMyOrder.TabIndex = 18;
            btnMyOrder.Text = "My Order";
            btnMyOrder.UseVisualStyleBackColor = true;
            // 
            // btnTailorMadeFurniture
            // 
            btnTailorMadeFurniture.Location = new Point(470, 20);
            btnTailorMadeFurniture.Margin = new Padding(4, 5, 4, 5);
            btnTailorMadeFurniture.Name = "btnTailorMadeFurniture";
            btnTailorMadeFurniture.Size = new Size(137, 33);
            btnTailorMadeFurniture.TabIndex = 17;
            btnTailorMadeFurniture.Text = "Tailor Made Furniture";
            btnTailorMadeFurniture.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(827, 20);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 33);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(214, 20);
            btnHome.Margin = new Padding(4, 5, 4, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(88, 33);
            btnHome.TabIndex = 15;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnShoppingCart
            // 
            btnShoppingCart.Location = new Point(108, 20);
            btnShoppingCart.Margin = new Padding(4, 5, 4, 5);
            btnShoppingCart.Name = "btnShoppingCart";
            btnShoppingCart.Size = new Size(88, 33);
            btnShoppingCart.TabIndex = 14;
            btnShoppingCart.Text = "ShoppingCart";
            btnShoppingCart.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 19);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 33);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnAddToShoppingCart
            // 
            btnAddToShoppingCart.Location = new Point(46, 549);
            btnAddToShoppingCart.Margin = new Padding(4, 5, 4, 5);
            btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            btnAddToShoppingCart.Size = new Size(148, 42);
            btnAddToShoppingCart.TabIndex = 21;
            btnAddToShoppingCart.Text = "Add To Shopping Cart";
            btnAddToShoppingCart.UseVisualStyleBackColor = true;
            btnAddToShoppingCart.Click += btnAddToShopingCar_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(725, 549);
            btnCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(126, 42);
            btnCheckOut.TabIndex = 22;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // numUDProductQuantity
            // 
            numUDProductQuantity.Location = new Point(596, 264);
            numUDProductQuantity.Margin = new Padding(4, 5, 4, 5);
            numUDProductQuantity.Name = "numUDProductQuantity";
            numUDProductQuantity.Size = new Size(52, 23);
            numUDProductQuantity.TabIndex = 29;
            numUDProductQuantity.ValueChanged += numUDProductQuantity_ValueChanged;
            // 
            // lalProductQuantity
            // 
            lalProductQuantity.AutoSize = true;
            lalProductQuantity.Location = new Point(529, 264);
            lalProductQuantity.Margin = new Padding(4, 0, 4, 0);
            lalProductQuantity.Name = "lalProductQuantity";
            lalProductQuantity.Size = new Size(63, 17);
            lalProductQuantity.TabIndex = 30;
            lalProductQuantity.Text = " Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 265);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 31;
            label1.Text = "Product:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 262);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 25);
            comboBox1.TabIndex = 32;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 637);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lalProductQuantity);
            Controls.Add(numUDProductQuantity);
            Controls.Add(btnCheckOut);
            Controls.Add(btnAddToShoppingCart);
            Controls.Add(btnPoductCategory);
            Controls.Add(textBox1);
            Controls.Add(btnMyOrder);
            Controls.Add(btnTailorMadeFurniture);
            Controls.Add(btnSearch);
            Controls.Add(btnHome);
            Controls.Add(btnShoppingCart);
            Controls.Add(btnLogin);
            Controls.Add(btnBack);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Buy";
            Text = "Buy";
            Load += Buy_Load;
            ((System.ComponentModel.ISupportInitialize)numUDProductQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox btnPoductCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMyOrder;
        private System.Windows.Forms.Button btnTailorMadeFurniture;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAddToShoppingCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown numUDProductQuantity;
        private System.Windows.Forms.Label lalProductQuantity;
        private Label label1;
        private ComboBox comboBox1;
    }
}