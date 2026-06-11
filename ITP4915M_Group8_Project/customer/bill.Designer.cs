namespace ITP4915M_Group8_Project.customer
{
    partial class bill
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
            lalBillplease = new Label();
            grpbBillingDetails = new GroupBox();
            lalShoppingAddres = new Label();
            lalPhoneNumber = new Label();
            lalLastName = new Label();
            lalFristName = new Label();
            rdbExpressShipping = new RadioButton();
            lblshippingType = new Label();
            txtAddress = new TextBox();
            rdbOrdinaryTransportat = new RadioButton();
            txtPhonenum = new TextBox();
            txtPhone = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnContinue = new Button();
            lalOrderName = new Label();
            lalQuantitty = new Label();
            label4 = new Label();
            lalProductName = new Label();
            label6 = new Label();
            lalTotalAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotalPrice = new Label();
            TotalPriceLib2 = new Label();
            btnBack = new Button();
            dgvCartList = new DataGridView();
            grpbBillingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartList).BeginInit();
            SuspendLayout();
            // 
            // lalBillplease
            // 
            lalBillplease.AutoSize = true;
            lalBillplease.Font = new Font("Microsoft Sans Serif", 30F);
            lalBillplease.Location = new Point(350, 40);
            lalBillplease.Margin = new Padding(4, 0, 4, 0);
            lalBillplease.Name = "lalBillplease";
            lalBillplease.Size = new Size(202, 46);
            lalBillplease.TabIndex = 0;
            lalBillplease.Tag = "";
            lalBillplease.Text = "Bill please";
            // 
            // grpbBillingDetails
            // 
            grpbBillingDetails.Controls.Add(lalShoppingAddres);
            grpbBillingDetails.Controls.Add(lalPhoneNumber);
            grpbBillingDetails.Controls.Add(lalLastName);
            grpbBillingDetails.Controls.Add(lalFristName);
            grpbBillingDetails.Controls.Add(rdbExpressShipping);
            grpbBillingDetails.Controls.Add(lblshippingType);
            grpbBillingDetails.Controls.Add(txtAddress);
            grpbBillingDetails.Controls.Add(rdbOrdinaryTransportat);
            grpbBillingDetails.Controls.Add(txtPhonenum);
            grpbBillingDetails.Controls.Add(txtPhone);
            grpbBillingDetails.Controls.Add(txtLastName);
            grpbBillingDetails.Controls.Add(txtFirstName);
            grpbBillingDetails.Location = new Point(128, 111);
            grpbBillingDetails.Margin = new Padding(4);
            grpbBillingDetails.Name = "grpbBillingDetails";
            grpbBillingDetails.Padding = new Padding(4);
            grpbBillingDetails.Size = new Size(295, 389);
            grpbBillingDetails.TabIndex = 1;
            grpbBillingDetails.TabStop = false;
            grpbBillingDetails.Text = "Billing Details";
            // 
            // lalShoppingAddres
            // 
            lalShoppingAddres.AutoSize = true;
            lalShoppingAddres.Location = new Point(20, 146);
            lalShoppingAddres.Margin = new Padding(4, 0, 4, 0);
            lalShoppingAddres.Name = "lalShoppingAddres";
            lalShoppingAddres.Size = new Size(99, 15);
            lalShoppingAddres.TabIndex = 11;
            lalShoppingAddres.Text = "Shipping Address";
            // 
            // lalPhoneNumber
            // 
            lalPhoneNumber.AutoSize = true;
            lalPhoneNumber.Location = new Point(134, 91);
            lalPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lalPhoneNumber.Name = "lalPhoneNumber";
            lalPhoneNumber.Size = new Size(88, 15);
            lalPhoneNumber.TabIndex = 10;
            lalPhoneNumber.Text = "Phone Number";
            // 
            // lalLastName
            // 
            lalLastName.AutoSize = true;
            lalLastName.Location = new Point(132, 34);
            lalLastName.Margin = new Padding(4, 0, 4, 0);
            lalLastName.Name = "lalLastName";
            lalLastName.Size = new Size(63, 15);
            lalLastName.TabIndex = 9;
            lalLastName.Text = "Last Name";
            // 
            // lalFristName
            // 
            lalFristName.AutoSize = true;
            lalFristName.Location = new Point(20, 34);
            lalFristName.Margin = new Padding(4, 0, 4, 0);
            lalFristName.Name = "lalFristName";
            lalFristName.Size = new Size(64, 15);
            lalFristName.TabIndex = 8;
            lalFristName.Text = "First Name";
            // 
            // rdbExpressShipping
            // 
            rdbExpressShipping.Location = new Point(19, 322);
            rdbExpressShipping.Margin = new Padding(4);
            rdbExpressShipping.Name = "rdbExpressShipping";
            rdbExpressShipping.Size = new Size(251, 30);
            rdbExpressShipping.TabIndex = 7;
            rdbExpressShipping.Text = "Express Shipping";
            rdbExpressShipping.UseVisualStyleBackColor = true;
            // 
            // lblshippingType
            // 
            lblshippingType.AutoSize = true;
            lblshippingType.Location = new Point(104, 250);
            lblshippingType.Margin = new Padding(4, 0, 4, 0);
            lblshippingType.Name = "lblshippingType";
            lblshippingType.Size = new Size(80, 15);
            lblshippingType.TabIndex = 5;
            lblshippingType.Text = "shipping Type";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 161);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 73);
            txtAddress.TabIndex = 4;
            // 
            // rdbOrdinaryTransportat
            // 
            rdbOrdinaryTransportat.Checked = true;
            rdbOrdinaryTransportat.Location = new Point(20, 286);
            rdbOrdinaryTransportat.Margin = new Padding(4);
            rdbOrdinaryTransportat.Name = "rdbOrdinaryTransportat";
            rdbOrdinaryTransportat.Size = new Size(251, 29);
            rdbOrdinaryTransportat.TabIndex = 6;
            rdbOrdinaryTransportat.TabStop = true;
            rdbOrdinaryTransportat.Text = "Ordinary Transportat";
            rdbOrdinaryTransportat.UseVisualStyleBackColor = true;
            // 
            // txtPhonenum
            // 
            txtPhonenum.Location = new Point(132, 114);
            txtPhonenum.Margin = new Padding(4);
            txtPhonenum.Name = "txtPhonenum";
            txtPhonenum.Size = new Size(136, 23);
            txtPhonenum.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.FormattingEnabled = true;
            txtPhone.Location = new Point(20, 112);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(77, 23);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "+852";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(134, 55);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(116, 23);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 55);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(89, 23);
            txtFirstName.TabIndex = 0;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(515, 449);
            btnContinue.Margin = new Padding(4);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(321, 51);
            btnContinue.TabIndex = 3;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += button1_Click;
            // 
            // lalOrderName
            // 
            lalOrderName.AutoSize = true;
            lalOrderName.Location = new Point(529, 150);
            lalOrderName.Margin = new Padding(4, 0, 4, 0);
            lalOrderName.Name = "lalOrderName";
            lalOrderName.Size = new Size(72, 15);
            lalOrderName.TabIndex = 0;
            lalOrderName.Text = "Order Name";
            lalOrderName.Click += lalOrderName_Click;
            // 
            // lalQuantitty
            // 
            lalQuantitty.Location = new Point(0, 0);
            lalQuantitty.Margin = new Padding(2, 0, 2, 0);
            lalQuantitty.Name = "lalQuantitty";
            lalQuantitty.Size = new Size(64, 15);
            lalQuantitty.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            // 
            // lalProductName
            // 
            lalProductName.AutoSize = true;
            lalProductName.Location = new Point(529, 198);
            lalProductName.Margin = new Padding(4, 0, 4, 0);
            lalProductName.Name = "lalProductName";
            lalProductName.Size = new Size(81, 15);
            lalProductName.TabIndex = 4;
            lalProductName.Text = "ProductName";
            lalProductName.Click += lalProductName_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 198);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 5;
            label6.Text = "x1";
            label6.Click += label6_Click;
            // 
            // lalTotalAmount
            // 
            lalTotalAmount.Location = new Point(0, 0);
            lalTotalAmount.Margin = new Padding(2, 0, 2, 0);
            lalTotalAmount.Name = "lalTotalAmount";
            lalTotalAmount.Size = new Size(64, 15);
            lalTotalAmount.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(624, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "Quantity";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Amount";
            label2.Click += totalPrice;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(529, 411);
            lblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(67, 15);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "Total Price :";
            lblTotalPrice.Click += TotalPriceLib_Click;
            // 
            // TotalPriceLib2
            // 
            TotalPriceLib2.AutoSize = true;
            TotalPriceLib2.Location = new Point(739, 198);
            TotalPriceLib2.Margin = new Padding(4, 0, 4, 0);
            TotalPriceLib2.Name = "TotalPriceLib2";
            TotalPriceLib2.Size = new Size(13, 15);
            TotalPriceLib2.TabIndex = 13;
            TotalPriceLib2.Text = "0";
            TotalPriceLib2.Click += TotalPriceLib2_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(29, 449);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 51);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvCartList
            // 
            dgvCartList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartList.Location = new Point(515, 113);
            dgvCartList.Name = "dgvCartList";
            dgvCartList.Size = new Size(321, 232);
            dgvCartList.TabIndex = 15;
            // 
            // bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 562);
            Controls.Add(dgvCartList);
            Controls.Add(btnBack);
            Controls.Add(TotalPriceLib2);
            Controls.Add(lblTotalPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lalTotalAmount);
            Controls.Add(btnContinue);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(lalProductName);
            Controls.Add(grpbBillingDetails);
            Controls.Add(lalBillplease);
            Controls.Add(lalOrderName);
            Controls.Add(lalQuantitty);
            Margin = new Padding(4);
            Name = "bill";
            Text = "bill";
            grpbBillingDetails.ResumeLayout(false);
            grpbBillingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalBillplease;
        private System.Windows.Forms.GroupBox grpbBillingDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhonenum;
        private System.Windows.Forms.ComboBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbPaypal;
        private System.Windows.Forms.Label lblshippingType;
        private System.Windows.Forms.Label lalPhoneNumber;
        private System.Windows.Forms.Label lalLastName;
        private System.Windows.Forms.Label lalFristName;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lalOrderName;
        private System.Windows.Forms.Label lalQuantitty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lalProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lalTotalAmount;
        private System.Windows.Forms.Label lalShoppingAddres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalPrice;
        private Label TotalPriceLib2;
        private Button btnBack;
        private DataGridView dgvCartList;
        private RadioButton rdbExpressShipping;
        private RadioButton rdbOrdinaryTransportat;
    }
}