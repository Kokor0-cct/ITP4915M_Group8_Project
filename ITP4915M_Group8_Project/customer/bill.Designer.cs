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
            txtCardNumber = new RadioButton();
            rbPaypal = new RadioButton();
            lalPaymentMethod = new Label();
            txtAddress = new TextBox();
            txtPhonenum = new TextBox();
            txtPhone = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnContinue = new Button();
            lalOrderName = new Label();
            lalQuantitty = new Label();
            lalAmount = new Label();
            label4 = new Label();
            lalProductName = new Label();
            label6 = new Label();
            lalTotalAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TotalPriceLib = new Label();
            TotalPriceLib2 = new Label();
            grpbBillingDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lalBillplease
            // 
            lalBillplease.AutoSize = true;
            lalBillplease.Font = new Font("新細明體", 30F);
            lalBillplease.Location = new Point(550, 61);
            lalBillplease.Margin = new Padding(6, 0, 6, 0);
            lalBillplease.Name = "lalBillplease";
            lalBillplease.Size = new Size(268, 60);
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
            grpbBillingDetails.Controls.Add(txtCardNumber);
            grpbBillingDetails.Controls.Add(rbPaypal);
            grpbBillingDetails.Controls.Add(lalPaymentMethod);
            grpbBillingDetails.Controls.Add(txtAddress);
            grpbBillingDetails.Controls.Add(txtPhonenum);
            grpbBillingDetails.Controls.Add(txtPhone);
            grpbBillingDetails.Controls.Add(txtLastName);
            grpbBillingDetails.Controls.Add(txtFirstName);
            grpbBillingDetails.Location = new Point(198, 199);
            grpbBillingDetails.Margin = new Padding(6);
            grpbBillingDetails.Name = "grpbBillingDetails";
            grpbBillingDetails.Padding = new Padding(6);
            grpbBillingDetails.Size = new Size(464, 596);
            grpbBillingDetails.TabIndex = 1;
            grpbBillingDetails.TabStop = false;
            grpbBillingDetails.Text = "Billing Details";
            // 
            // lalShoppingAddres
            // 
            lalShoppingAddres.AutoSize = true;
            lalShoppingAddres.Location = new Point(31, 224);
            lalShoppingAddres.Margin = new Padding(6, 0, 6, 0);
            lalShoppingAddres.Name = "lalShoppingAddres";
            lalShoppingAddres.Size = new Size(150, 23);
            lalShoppingAddres.TabIndex = 11;
            lalShoppingAddres.Text = "ShoppingAddres";
            // 
            // lalPhoneNumber
            // 
            lalPhoneNumber.AutoSize = true;
            lalPhoneNumber.Location = new Point(211, 140);
            lalPhoneNumber.Margin = new Padding(6, 0, 6, 0);
            lalPhoneNumber.Name = "lalPhoneNumber";
            lalPhoneNumber.Size = new Size(140, 23);
            lalPhoneNumber.TabIndex = 10;
            lalPhoneNumber.Text = "Phone Number";
            // 
            // lalLastName
            // 
            lalLastName.AutoSize = true;
            lalLastName.Location = new Point(207, 52);
            lalLastName.Margin = new Padding(6, 0, 6, 0);
            lalLastName.Name = "lalLastName";
            lalLastName.Size = new Size(101, 23);
            lalLastName.TabIndex = 9;
            lalLastName.Text = "Last Name";
            // 
            // lalFristName
            // 
            lalFristName.AutoSize = true;
            lalFristName.Location = new Point(31, 52);
            lalFristName.Margin = new Padding(6, 0, 6, 0);
            lalFristName.Name = "lalFristName";
            lalFristName.Size = new Size(103, 23);
            lalFristName.TabIndex = 8;
            lalFristName.Text = "Frist Name";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Enabled = false;
            txtCardNumber.Location = new Point(31, 489);
            txtCardNumber.Margin = new Padding(6);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(394, 46);
            txtCardNumber.TabIndex = 7;
            txtCardNumber.TabStop = true;
            txtCardNumber.Text = "Card Number";
            txtCardNumber.UseVisualStyleBackColor = true;
            // 
            // rbPaypal
            // 
            rbPaypal.Location = new Point(31, 431);
            rbPaypal.Margin = new Padding(6);
            rbPaypal.Name = "rbPaypal";
            rbPaypal.Size = new Size(394, 44);
            rbPaypal.TabIndex = 6;
            rbPaypal.TabStop = true;
            rbPaypal.Text = "Paypal";
            rbPaypal.UseVisualStyleBackColor = true;
            // 
            // lalPaymentMethod
            // 
            lalPaymentMethod.AutoSize = true;
            lalPaymentMethod.Location = new Point(163, 383);
            lalPaymentMethod.Margin = new Padding(6, 0, 6, 0);
            lalPaymentMethod.Name = "lalPaymentMethod";
            lalPaymentMethod.Size = new Size(157, 23);
            lalPaymentMethod.TabIndex = 5;
            lalPaymentMethod.Text = "Payment Method";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(31, 247);
            txtAddress.Margin = new Padding(6);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(391, 109);
            txtAddress.TabIndex = 4;
            // 
            // txtPhonenum
            // 
            txtPhonenum.Location = new Point(211, 167);
            txtPhonenum.Margin = new Padding(6);
            txtPhonenum.Name = "txtPhonenum";
            txtPhonenum.Size = new Size(211, 30);
            txtPhonenum.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.FormattingEnabled = true;
            txtPhone.Location = new Point(31, 172);
            txtPhone.Margin = new Padding(6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(118, 31);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "+852";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(211, 84);
            txtLastName.Margin = new Padding(6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 30);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(31, 84);
            txtFirstName.Margin = new Padding(6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(138, 30);
            txtFirstName.TabIndex = 0;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(810, 688);
            btnContinue.Margin = new Padding(6);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(504, 79);
            btnContinue.TabIndex = 3;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += button1_Click;
            // 
            // lalOrderName
            // 
            lalOrderName.AutoSize = true;
            lalOrderName.Location = new Point(832, 230);
            lalOrderName.Margin = new Padding(6, 0, 6, 0);
            lalOrderName.Name = "lalOrderName";
            lalOrderName.Size = new Size(117, 23);
            lalOrderName.TabIndex = 0;
            lalOrderName.Text = "Order Name";
            lalOrderName.Click += lalOrderName_Click;
            // 
            // lalQuantitty
            // 
            lalQuantitty.Location = new Point(0, 0);
            lalQuantitty.Name = "lalQuantitty";
            lalQuantitty.Size = new Size(100, 23);
            lalQuantitty.TabIndex = 8;
            // 
            // lalAmount
            // 
            lalAmount.AutoSize = true;
            lalAmount.Location = new Point(944, 630);
            lalAmount.Margin = new Padding(6, 0, 6, 0);
            lalAmount.Name = "lalAmount";
            lalAmount.Size = new Size(20, 23);
            lalAmount.TabIndex = 2;
            lalAmount.Text = "0";
            lalAmount.Click += lalAmount_Click;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 7;
            // 
            // lalProductName
            // 
            lalProductName.AutoSize = true;
            lalProductName.Location = new Point(832, 303);
            lalProductName.Margin = new Padding(6, 0, 6, 0);
            lalProductName.Name = "lalProductName";
            lalProductName.Size = new Size(129, 23);
            lalProductName.TabIndex = 4;
            lalProductName.Text = "ProductName";
            lalProductName.Click += lalProductName_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1006, 303);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 23);
            label6.TabIndex = 5;
            label6.Text = "x1";
            label6.Click += label6_Click;
            // 
            // lalTotalAmount
            // 
            lalTotalAmount.Location = new Point(0, 0);
            lalTotalAmount.Name = "lalTotalAmount";
            lalTotalAmount.Size = new Size(100, 23);
            lalTotalAmount.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(981, 230);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 9;
            label1.Text = "Quantity";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1131, 230);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 10;
            label2.Text = "Amount";
            label2.Click += totalPrice;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // TotalPriceLib
            // 
            TotalPriceLib.AutoSize = true;
            TotalPriceLib.Location = new Point(832, 630);
            TotalPriceLib.Margin = new Padding(6, 0, 6, 0);
            TotalPriceLib.Name = "TotalPriceLib";
            TotalPriceLib.Size = new Size(100, 23);
            TotalPriceLib.TabIndex = 12;
            TotalPriceLib.Text = "Total Price";
            TotalPriceLib.Click += TotalPriceLib_Click;
            // 
            // TotalPriceLib2
            // 
            TotalPriceLib2.AutoSize = true;
            TotalPriceLib2.Location = new Point(1161, 303);
            TotalPriceLib2.Margin = new Padding(6, 0, 6, 0);
            TotalPriceLib2.Name = "TotalPriceLib2";
            TotalPriceLib2.Size = new Size(20, 23);
            TotalPriceLib2.TabIndex = 13;
            TotalPriceLib2.Text = "0";
            TotalPriceLib2.Click += TotalPriceLib2_Click;
            // 
            // bill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 862);
            Controls.Add(TotalPriceLib2);
            Controls.Add(TotalPriceLib);
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
            Controls.Add(lalAmount);
            Controls.Add(lalOrderName);
            Controls.Add(lalQuantitty);
            Margin = new Padding(6);
            Name = "bill";
            Text = "bill";
            grpbBillingDetails.ResumeLayout(false);
            grpbBillingDetails.PerformLayout();
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
        private System.Windows.Forms.Label lalPaymentMethod;
        private System.Windows.Forms.RadioButton txtCardNumber;
        private System.Windows.Forms.Label lalPhoneNumber;
        private System.Windows.Forms.Label lalLastName;
        private System.Windows.Forms.Label lalFristName;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lalOrderName;
        private System.Windows.Forms.Label lalQuantitty;
        private System.Windows.Forms.Label lalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lalProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lalTotalAmount;
        private System.Windows.Forms.Label lalShoppingAddres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TotalPriceLib;
        private Label TotalPriceLib2;
    }
}