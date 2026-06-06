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
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numUDProductQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 95);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 41);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPoductCategory
            // 
            btnPoductCategory.FormattingEnabled = true;
            btnPoductCategory.Items.AddRange(new object[] { "Sofa", "Chair" });
            btnPoductCategory.Location = new Point(310, 22);
            btnPoductCategory.Margin = new Padding(4);
            btnPoductCategory.Name = "btnPoductCategory";
            btnPoductCategory.Size = new Size(140, 23);
            btnPoductCategory.TabIndex = 20;
            btnPoductCategory.Text = "Product Category";
            btnPoductCategory.SelectedIndexChanged += btnPoductCategory_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(758, 21);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 23);
            textBox1.TabIndex = 19;
            // 
            // btnMyOrder
            // 
            btnMyOrder.Location = new Point(654, 18);
            btnMyOrder.Margin = new Padding(4);
            btnMyOrder.Name = "btnMyOrder";
            btnMyOrder.Size = new Size(88, 29);
            btnMyOrder.TabIndex = 18;
            btnMyOrder.Text = "My Order";
            btnMyOrder.UseVisualStyleBackColor = true;
            // 
            // btnTailorMadeFurniture
            // 
            btnTailorMadeFurniture.Location = new Point(470, 18);
            btnTailorMadeFurniture.Margin = new Padding(4);
            btnTailorMadeFurniture.Name = "btnTailorMadeFurniture";
            btnTailorMadeFurniture.Size = new Size(137, 29);
            btnTailorMadeFurniture.TabIndex = 17;
            btnTailorMadeFurniture.Text = "Tailor Made Furniture";
            btnTailorMadeFurniture.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(827, 18);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(214, 18);
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(88, 29);
            btnHome.TabIndex = 15;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnShoppingCart
            // 
            btnShoppingCart.Location = new Point(108, 18);
            btnShoppingCart.Margin = new Padding(4);
            btnShoppingCart.Name = "btnShoppingCart";
            btnShoppingCart.Size = new Size(88, 29);
            btnShoppingCart.TabIndex = 14;
            btnShoppingCart.Text = "ShoppingCart";
            btnShoppingCart.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 17);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 29);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnAddToShoppingCart
            // 
            btnAddToShoppingCart.Location = new Point(46, 484);
            btnAddToShoppingCart.Margin = new Padding(4);
            btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            btnAddToShoppingCart.Size = new Size(148, 37);
            btnAddToShoppingCart.TabIndex = 21;
            btnAddToShoppingCart.Text = "Add To Shopping Cart";
            btnAddToShoppingCart.UseVisualStyleBackColor = true;
            btnAddToShoppingCart.Click += btnAddToShopingCar_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(725, 484);
            btnCheckOut.Margin = new Padding(4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(126, 37);
            btnCheckOut.TabIndex = 22;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // numUDProductQuantity
            // 
            numUDProductQuantity.Location = new Point(596, 233);
            numUDProductQuantity.Margin = new Padding(4);
            numUDProductQuantity.Name = "numUDProductQuantity";
            numUDProductQuantity.Size = new Size(52, 23);
            numUDProductQuantity.TabIndex = 29;
            numUDProductQuantity.ValueChanged += numUDProductQuantity_ValueChanged;
            // 
            // lalProductQuantity
            // 
            lalProductQuantity.AutoSize = true;
            lalProductQuantity.Location = new Point(529, 233);
            lalProductQuantity.Margin = new Padding(4, 0, 4, 0);
            lalProductQuantity.Name = "lalProductQuantity";
            lalProductQuantity.Size = new Size(59, 15);
            lalProductQuantity.TabIndex = 30;
            lalProductQuantity.Text = " Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 234);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 31;
            label1.Text = "Product:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 231);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 32;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(698, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(93, 94);
            listBox1.TabIndex = 33;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 562);
            Controls.Add(listBox1);
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
            Margin = new Padding(4);
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
        private ListBox listBox1;
    }
}