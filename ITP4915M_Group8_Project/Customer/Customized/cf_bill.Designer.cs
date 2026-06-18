namespace ITP4915M_Group8_Project.Customer.Customized
{
    partial class cf_bill
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
            lblTotalPrice = new Label();
            label3 = new Label();
            lalTotalAmount = new Label();
            btnContinue = new Button();
            label4 = new Label();
            grpbBillingDetails = new GroupBox();
            dateChoose = new DateTimePicker();
            lblDate = new Label();
            lalShoppingAddres = new Label();
            lalPhoneNumber = new Label();
            lalName = new Label();
            rdbExpressShipping = new RadioButton();
            lblshippingType = new Label();
            txtAddress = new TextBox();
            rdbOrdinaryTransportat = new RadioButton();
            txtPhonenum = new TextBox();
            txtFirstName = new TextBox();
            lalBillplease = new Label();
            lalQuantitty = new Label();
            lblPName = new Label();
            lblQty = new Label();
            lblUprice = new Label();
            txtPname = new TextBox();
            txtUnitPrice = new TextBox();
            txtQty = new TextBox();
            grpbBillingDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(29, 509);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 58);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(515, 466);
            lblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(76, 17);
            lblTotalPrice.TabIndex = 23;
            lblTotalPrice.Text = "Total Price :";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 16;
            // 
            // lalTotalAmount
            // 
            lalTotalAmount.Location = new Point(0, 0);
            lalTotalAmount.Margin = new Padding(2, 0, 2, 0);
            lalTotalAmount.Name = "lalTotalAmount";
            lalTotalAmount.Size = new Size(64, 17);
            lalTotalAmount.TabIndex = 22;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(515, 509);
            btnContinue.Margin = new Padding(4, 5, 4, 5);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(321, 58);
            btnContinue.TabIndex = 19;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 20;
            // 
            // grpbBillingDetails
            // 
            grpbBillingDetails.Controls.Add(dateChoose);
            grpbBillingDetails.Controls.Add(lblDate);
            grpbBillingDetails.Controls.Add(lalShoppingAddres);
            grpbBillingDetails.Controls.Add(lalPhoneNumber);
            grpbBillingDetails.Controls.Add(lalName);
            grpbBillingDetails.Controls.Add(rdbExpressShipping);
            grpbBillingDetails.Controls.Add(lblshippingType);
            grpbBillingDetails.Controls.Add(txtAddress);
            grpbBillingDetails.Controls.Add(rdbOrdinaryTransportat);
            grpbBillingDetails.Controls.Add(txtPhonenum);
            grpbBillingDetails.Controls.Add(txtFirstName);
            grpbBillingDetails.Location = new Point(128, 126);
            grpbBillingDetails.Margin = new Padding(4, 5, 4, 5);
            grpbBillingDetails.Name = "grpbBillingDetails";
            grpbBillingDetails.Padding = new Padding(4, 5, 4, 5);
            grpbBillingDetails.Size = new Size(295, 441);
            grpbBillingDetails.TabIndex = 18;
            grpbBillingDetails.TabStop = false;
            grpbBillingDetails.Text = "Billing Details";
            // 
            // dateChoose
            // 
            dateChoose.Location = new Point(20, 118);
            dateChoose.Name = "dateChoose";
            dateChoose.Size = new Size(248, 23);
            dateChoose.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(21, 100);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(84, 17);
            lblDate.TabIndex = 12;
            lblDate.Text = "Delivery date";
            // 
            // lalShoppingAddres
            // 
            lalShoppingAddres.AutoSize = true;
            lalShoppingAddres.Location = new Point(21, 167);
            lalShoppingAddres.Margin = new Padding(4, 0, 4, 0);
            lalShoppingAddres.Name = "lalShoppingAddres";
            lalShoppingAddres.Size = new Size(111, 17);
            lalShoppingAddres.TabIndex = 11;
            lalShoppingAddres.Text = "Shipping Address";
            // 
            // lalPhoneNumber
            // 
            lalPhoneNumber.AutoSize = true;
            lalPhoneNumber.Location = new Point(140, 41);
            lalPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lalPhoneNumber.Name = "lalPhoneNumber";
            lalPhoneNumber.Size = new Size(96, 17);
            lalPhoneNumber.TabIndex = 10;
            lalPhoneNumber.Text = "Phone Number";
            // 
            // lalName
            // 
            lalName.AutoSize = true;
            lalName.Location = new Point(21, 41);
            lalName.Margin = new Padding(4, 0, 4, 0);
            lalName.Name = "lalName";
            lalName.Size = new Size(43, 17);
            lalName.TabIndex = 8;
            lalName.Text = "Name";
            // 
            // rdbExpressShipping
            // 
            rdbExpressShipping.Location = new Point(19, 365);
            rdbExpressShipping.Margin = new Padding(4, 5, 4, 5);
            rdbExpressShipping.Name = "rdbExpressShipping";
            rdbExpressShipping.Size = new Size(251, 34);
            rdbExpressShipping.TabIndex = 7;
            rdbExpressShipping.Text = "Express Shipping                ($150)";
            rdbExpressShipping.UseVisualStyleBackColor = true;
            rdbExpressShipping.CheckedChanged += rdbOrdinaryTransportat_CheckedChanged;
            // 
            // lblshippingType
            // 
            lblshippingType.AutoSize = true;
            lblshippingType.Location = new Point(105, 285);
            lblshippingType.Margin = new Padding(4, 0, 4, 0);
            lblshippingType.Name = "lblshippingType";
            lblshippingType.Size = new Size(90, 17);
            lblshippingType.TabIndex = 5;
            lblshippingType.Text = "shipping Type";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 182);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 82);
            txtAddress.TabIndex = 4;
            // 
            // rdbOrdinaryTransportat
            // 
            rdbOrdinaryTransportat.Checked = true;
            rdbOrdinaryTransportat.Location = new Point(20, 324);
            rdbOrdinaryTransportat.Margin = new Padding(4, 5, 4, 5);
            rdbOrdinaryTransportat.Name = "rdbOrdinaryTransportat";
            rdbOrdinaryTransportat.Size = new Size(251, 33);
            rdbOrdinaryTransportat.TabIndex = 6;
            rdbOrdinaryTransportat.TabStop = true;
            rdbOrdinaryTransportat.Text = "Ordinary Transportat          ($50)";
            rdbOrdinaryTransportat.UseVisualStyleBackColor = true;
            rdbOrdinaryTransportat.CheckedChanged += rdbOrdinaryTransportat_CheckedChanged;
            // 
            // txtPhonenum
            // 
            txtPhonenum.Location = new Point(139, 62);
            txtPhonenum.Margin = new Padding(4, 5, 4, 5);
            txtPhonenum.Name = "txtPhonenum";
            txtPhonenum.Size = new Size(129, 23);
            txtPhonenum.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 62);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(111, 23);
            txtFirstName.TabIndex = 0;
            // 
            // lalBillplease
            // 
            lalBillplease.AutoSize = true;
            lalBillplease.Font = new Font("Microsoft Sans Serif", 30F);
            lalBillplease.Location = new Point(350, 45);
            lalBillplease.Margin = new Padding(4, 0, 4, 0);
            lalBillplease.Name = "lalBillplease";
            lalBillplease.Size = new Size(202, 46);
            lalBillplease.TabIndex = 17;
            lalBillplease.Tag = "";
            lalBillplease.Text = "Bill please";
            // 
            // lalQuantitty
            // 
            lalQuantitty.Location = new Point(0, 0);
            lalQuantitty.Margin = new Padding(2, 0, 2, 0);
            lalQuantitty.Name = "lalQuantitty";
            lalQuantitty.Size = new Size(64, 17);
            lalQuantitty.TabIndex = 21;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(482, 138);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(93, 17);
            lblPName.TabIndex = 25;
            lblPName.Text = "product Name";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(627, 138);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(56, 17);
            lblQty.TabIndex = 26;
            lblQty.Text = "Quantity";
            // 
            // lblUprice
            // 
            lblUprice.AutoSize = true;
            lblUprice.Location = new Point(764, 138);
            lblUprice.Name = "lblUprice";
            lblUprice.Size = new Size(64, 17);
            lblUprice.TabIndex = 27;
            lblUprice.Text = "Unit price";
            // 
            // txtPname
            // 
            txtPname.Location = new Point(482, 167);
            txtPname.Name = "txtPname";
            txtPname.ReadOnly = true;
            txtPname.Size = new Size(100, 23);
            txtPname.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(736, 167);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 29;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(615, 167);
            txtQty.Name = "txtQty";
            txtQty.ReadOnly = true;
            txtQty.Size = new Size(77, 23);
            txtQty.TabIndex = 30;
            // 
            // cf_bill
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 637);
            Controls.Add(txtQty);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtPname);
            Controls.Add(lblUprice);
            Controls.Add(lblQty);
            Controls.Add(lblPName);
            Controls.Add(btnBack);
            Controls.Add(lblTotalPrice);
            Controls.Add(label3);
            Controls.Add(lalTotalAmount);
            Controls.Add(btnContinue);
            Controls.Add(label4);
            Controls.Add(grpbBillingDetails);
            Controls.Add(lalBillplease);
            Controls.Add(lalQuantitty);
            Name = "cf_bill";
            Text = "cf_bill";
            grpbBillingDetails.ResumeLayout(false);
            grpbBillingDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Label lblTotalPrice;
        private Label label3;
        private Label lalTotalAmount;
        private Button btnContinue;
        private Label label4;
        private GroupBox grpbBillingDetails;
        private DateTimePicker dateChoose;
        private Label lblDate;
        private Label lalShoppingAddres;
        private Label lalPhoneNumber;
        private Label lalName;
        private RadioButton rdbExpressShipping;
        private Label lblshippingType;
        private TextBox txtAddress;
        private RadioButton rdbOrdinaryTransportat;
        private TextBox txtPhonenum;
        private TextBox txtFirstName;
        private Label lalBillplease;
        private Label lalQuantitty;
        private Label lblPName;
        private Label lblQty;
        private Label lblUprice;
        private TextBox txtPname;
        private TextBox txtUnitPrice;
        private TextBox txtQty;
    }
}