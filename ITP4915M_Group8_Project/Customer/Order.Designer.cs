namespace ITP4915M_Group8_Project.Customer
{
    partial class Order
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
            llBack = new LinkLabel();
            grpStatus = new GroupBox();
            rbAll = new RadioButton();
            radReplace = new RadioButton();
            rbCancel = new RadioButton();
            radRefund = new RadioButton();
            rbFailed = new RadioButton();
            radUnderreview = new RadioButton();
            radCompleted = new RadioButton();
            rbDelivered = new RadioButton();
            rbTransit = new RadioButton();
            rbProduction = new RadioButton();
            rbPending = new RadioButton();
            btnFindSimilar = new Button();
            txtDeliveryDate = new TextBox();
            txtAmount = new TextBox();
            txtStatus = new TextBox();
            txtShipping = new TextBox();
            txtAddress = new TextBox();
            txtUserID = new TextBox();
            txtQuantity = new TextBox();
            txtFurniture = new TextBox();
            txtOrderID = new TextBox();
            lblStatusType = new Label();
            lblShippingType = new Label();
            lblAddress = new Label();
            lblDeliveryDate = new Label();
            lblAmount = new Label();
            lblUser = new Label();
            lblQuantity = new Label();
            lblFurniture = new Label();
            lblOrder = new Label();
            lblback = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvOrderControl = new DataGridView();
            lblTitle = new Label();
            btnCancel = new Button();
            btnReplace = new Button();
            txtStaffNote = new TextBox();
            lblStaffNote = new Label();
            gbOC = new GroupBox();
            rbCustomOrders = new RadioButton();
            rbOrders = new RadioButton();
            rdWaitingforDelivery = new RadioButton();
            rdProduced = new RadioButton();
            grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).BeginInit();
            gbOC.SuspendLayout();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(36, 36);
            llBack.Name = "llBack";
            llBack.Size = new Size(102, 17);
            llBack.TabIndex = 94;
            llBack.TabStop = true;
            llBack.Text = "< Back to Menu";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(rdWaitingforDelivery);
            grpStatus.Controls.Add(rdProduced);
            grpStatus.Controls.Add(rbAll);
            grpStatus.Controls.Add(radReplace);
            grpStatus.Controls.Add(rbCancel);
            grpStatus.Controls.Add(radRefund);
            grpStatus.Controls.Add(rbFailed);
            grpStatus.Controls.Add(radUnderreview);
            grpStatus.Controls.Add(radCompleted);
            grpStatus.Controls.Add(rbDelivered);
            grpStatus.Controls.Add(rbTransit);
            grpStatus.Controls.Add(rbProduction);
            grpStatus.Controls.Add(rbPending);
            grpStatus.Location = new Point(639, 325);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(341, 230);
            grpStatus.TabIndex = 93;
            grpStatus.TabStop = false;
            grpStatus.Text = "Status";
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Location = new Point(6, 25);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(40, 21);
            rbAll.TabIndex = 6;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // radReplace
            // 
            radReplace.AutoSize = true;
            radReplace.Location = new Point(147, 203);
            radReplace.Name = "radReplace";
            radReplace.Size = new Size(72, 21);
            radReplace.TabIndex = 102;
            radReplace.TabStop = true;
            radReplace.Text = "Replace";
            radReplace.UseVisualStyleBackColor = true;
            radReplace.CheckedChanged += radReplace_CheckedChanged;
            // 
            // rbCancel
            // 
            rbCancel.AutoSize = true;
            rbCancel.Location = new Point(147, 145);
            rbCancel.Name = "rbCancel";
            rbCancel.Size = new Size(64, 21);
            rbCancel.TabIndex = 5;
            rbCancel.TabStop = true;
            rbCancel.Text = "Cancel";
            rbCancel.UseVisualStyleBackColor = true;
            rbCancel.CheckedChanged += rbCancel_CheckedChanged;
            // 
            // radRefund
            // 
            radRefund.AutoSize = true;
            radRefund.Location = new Point(6, 203);
            radRefund.Name = "radRefund";
            radRefund.Size = new Size(67, 21);
            radRefund.TabIndex = 101;
            radRefund.TabStop = true;
            radRefund.Text = "Refund";
            radRefund.UseVisualStyleBackColor = true;
            radRefund.CheckedChanged += radRefund_CheckedChanged;
            // 
            // rbFailed
            // 
            rbFailed.AutoSize = true;
            rbFailed.Location = new Point(6, 145);
            rbFailed.Name = "rbFailed";
            rbFailed.Size = new Size(60, 21);
            rbFailed.TabIndex = 4;
            rbFailed.TabStop = true;
            rbFailed.Text = "Failed";
            rbFailed.UseVisualStyleBackColor = true;
            rbFailed.CheckedChanged += rbFailed_CheckedChanged;
            // 
            // radUnderreview
            // 
            radUnderreview.AutoSize = true;
            radUnderreview.Location = new Point(147, 174);
            radUnderreview.Name = "radUnderreview";
            radUnderreview.Size = new Size(103, 21);
            radUnderreview.TabIndex = 100;
            radUnderreview.TabStop = true;
            radUnderreview.Text = "Under review";
            radUnderreview.UseVisualStyleBackColor = true;
            radUnderreview.CheckedChanged += radUnderreview_CheckedChanged;
            // 
            // radCompleted
            // 
            radCompleted.AutoSize = true;
            radCompleted.Location = new Point(6, 174);
            radCompleted.Name = "radCompleted";
            radCompleted.Size = new Size(90, 21);
            radCompleted.TabIndex = 99;
            radCompleted.TabStop = true;
            radCompleted.Text = "Completed";
            radCompleted.UseVisualStyleBackColor = true;
            radCompleted.CheckedChanged += radCompleted_CheckedChanged;
            // 
            // rbDelivered
            // 
            rbDelivered.AutoSize = true;
            rbDelivered.Location = new Point(147, 116);
            rbDelivered.Name = "rbDelivered";
            rbDelivered.Size = new Size(81, 21);
            rbDelivered.TabIndex = 3;
            rbDelivered.TabStop = true;
            rbDelivered.Text = "Delivered";
            rbDelivered.UseVisualStyleBackColor = true;
            rbDelivered.CheckedChanged += rbDelivered_CheckedChanged;
            // 
            // rbTransit
            // 
            rbTransit.AutoSize = true;
            rbTransit.Location = new Point(6, 116);
            rbTransit.Name = "rbTransit";
            rbTransit.Size = new Size(80, 21);
            rbTransit.TabIndex = 2;
            rbTransit.TabStop = true;
            rbTransit.Text = "In Transit";
            rbTransit.UseVisualStyleBackColor = true;
            rbTransit.CheckedChanged += rbTransit_CheckedChanged;
            // 
            // rbProduction
            // 
            rbProduction.AutoSize = true;
            rbProduction.Location = new Point(147, 68);
            rbProduction.Name = "rbProduction";
            rbProduction.Size = new Size(104, 21);
            rbProduction.TabIndex = 1;
            rbProduction.TabStop = true;
            rbProduction.Text = "In Production";
            rbProduction.UseVisualStyleBackColor = true;
            rbProduction.CheckedChanged += rbProduction_CheckedChanged;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Location = new Point(6, 68);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(73, 21);
            rbPending.TabIndex = 0;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            rbPending.CheckedChanged += rbPending_CheckedChanged;
            // 
            // btnFindSimilar
            // 
            btnFindSimilar.Location = new Point(491, 519);
            btnFindSimilar.Name = "btnFindSimilar";
            btnFindSimilar.Size = new Size(129, 26);
            btnFindSimilar.TabIndex = 92;
            btnFindSimilar.Text = "Find Related Records";
            btnFindSimilar.UseVisualStyleBackColor = true;
            btnFindSimilar.Click += btnFindSimilar_Click;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(411, 403);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.ReadOnly = true;
            txtDeliveryDate.Size = new Size(209, 23);
            txtDeliveryDate.TabIndex = 91;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(411, 369);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(92, 23);
            txtAmount.TabIndex = 90;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(360, 519);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 89;
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(149, 519);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(132, 23);
            txtShipping.TabIndex = 88;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(119, 438);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(510, 23);
            txtAddress.TabIndex = 87;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(119, 404);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(162, 23);
            txtUserID.TabIndex = 86;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 369);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(162, 23);
            txtQuantity.TabIndex = 85;
            // 
            // txtFurniture
            // 
            txtFurniture.Location = new Point(411, 336);
            txtFurniture.Name = "txtFurniture";
            txtFurniture.ReadOnly = true;
            txtFurniture.Size = new Size(209, 23);
            txtFurniture.TabIndex = 84;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(119, 336);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(162, 23);
            txtOrderID.TabIndex = 83;
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(312, 522);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(46, 17);
            lblStatusType.TabIndex = 82;
            lblStatusType.Text = "Status:";
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Location = new Point(50, 521);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(94, 17);
            lblShippingType.TabIndex = 81;
            lblShippingType.Text = "Shipping Type:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(48, 441);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 17);
            lblAddress.TabIndex = 80;
            lblAddress.Text = "Address:";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(315, 407);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(88, 17);
            lblDeliveryDate.TabIndex = 79;
            lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(312, 374);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(89, 17);
            lblAmount.TabIndex = 78;
            lblAmount.Text = "Total Amount:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(50, 407);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(55, 17);
            lblUser.TabIndex = 77;
            lblUser.Text = "User ID:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(48, 374);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(59, 17);
            lblQuantity.TabIndex = 76;
            lblQuantity.Text = "Quantity:";
            // 
            // lblFurniture
            // 
            lblFurniture.AutoSize = true;
            lblFurniture.Location = new Point(312, 340);
            lblFurniture.Name = "lblFurniture";
            lblFurniture.Size = new Size(101, 17);
            lblFurniture.TabIndex = 75;
            lblFurniture.Text = "Furniture Name:";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(50, 340);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(63, 17);
            lblOrder.TabIndex = 74;
            lblOrder.Text = "Order ID:";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(36, 325);
            lblback.Name = "lblback";
            lblback.Size = new Size(597, 230);
            lblback.TabIndex = 73;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1010, 475);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 29);
            btnRefresh.TabIndex = 72;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(312, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 27);
            btnSearch.TabIndex = 71;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(134, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 70;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(36, 89);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(106, 17);
            lblSearch.TabIndex = 69;
            lblSearch.Text = "Search OrderID :";
            // 
            // dgvOrderControl
            // 
            dgvOrderControl.AllowUserToAddRows = false;
            dgvOrderControl.AllowUserToDeleteRows = false;
            dgvOrderControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderControl.Location = new Point(36, 120);
            dgvOrderControl.MultiSelect = false;
            dgvOrderControl.Name = "dgvOrderControl";
            dgvOrderControl.ReadOnly = true;
            dgvOrderControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderControl.Size = new Size(1120, 184);
            dgvOrderControl.TabIndex = 68;
            dgvOrderControl.CellClick += dgvOrderControl_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(458, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 31);
            lblTitle.TabIndex = 67;
            lblTitle.Text = "View Order Control";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1010, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 27);
            btnCancel.TabIndex = 95;
            btnCancel.Text = "Cancel Order";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(1010, 334);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(129, 28);
            btnReplace.TabIndex = 96;
            btnReplace.Text = "Return/Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // txtStaffNote
            // 
            txtStaffNote.Location = new Point(130, 467);
            txtStaffNote.Multiline = true;
            txtStaffNote.Name = "txtStaffNote";
            txtStaffNote.ReadOnly = true;
            txtStaffNote.Size = new Size(499, 46);
            txtStaffNote.TabIndex = 98;
            // 
            // lblStaffNote
            // 
            lblStaffNote.AutoSize = true;
            lblStaffNote.Location = new Point(50, 467);
            lblStaffNote.Name = "lblStaffNote";
            lblStaffNote.Size = new Size(74, 17);
            lblStaffNote.TabIndex = 97;
            lblStaffNote.Text = "Staff Note :";
            // 
            // gbOC
            // 
            gbOC.Controls.Add(rbCustomOrders);
            gbOC.Controls.Add(rbOrders);
            gbOC.Location = new Point(1011, 75);
            gbOC.Name = "gbOC";
            gbOC.Size = new Size(145, 39);
            gbOC.TabIndex = 99;
            gbOC.TabStop = false;
            // 
            // rbCustomOrders
            // 
            rbCustomOrders.AutoSize = true;
            rbCustomOrders.Location = new Point(72, 12);
            rbCustomOrders.Name = "rbCustomOrders";
            rbCustomOrders.Size = new Size(70, 21);
            rbCustomOrders.TabIndex = 68;
            rbCustomOrders.TabStop = true;
            rbCustomOrders.Text = "Custom";
            rbCustomOrders.UseVisualStyleBackColor = true;
            rbCustomOrders.CheckedChanged += rbCustomOrders_CheckedChanged;
            // 
            // rbOrders
            // 
            rbOrders.AutoSize = true;
            rbOrders.Location = new Point(6, 12);
            rbOrders.Name = "rbOrders";
            rbOrders.Size = new Size(67, 21);
            rbOrders.TabIndex = 68;
            rbOrders.TabStop = true;
            rbOrders.Text = "Orders";
            rbOrders.UseVisualStyleBackColor = true;
            rbOrders.CheckedChanged += rbOrders_CheckedChanged;
            // 
            // rdWaitingforDelivery
            // 
            rdWaitingforDelivery.AutoSize = true;
            rdWaitingforDelivery.Location = new Point(147, 95);
            rdWaitingforDelivery.Name = "rdWaitingforDelivery";
            rdWaitingforDelivery.Size = new Size(141, 21);
            rdWaitingforDelivery.TabIndex = 104;
            rdWaitingforDelivery.TabStop = true;
            rdWaitingforDelivery.Text = "Waiting for Delivery";
            rdWaitingforDelivery.UseVisualStyleBackColor = true;
            rdWaitingforDelivery.CheckedChanged += rdWaitingforDelivery_CheckedChanged;
            // 
            // rdProduced
            // 
            rdProduced.AutoSize = true;
            rdProduced.Location = new Point(6, 95);
            rdProduced.Name = "rdProduced";
            rdProduced.Size = new Size(82, 21);
            rdProduced.TabIndex = 103;
            rdProduced.TabStop = true;
            rdProduced.Text = "Produced";
            rdProduced.UseVisualStyleBackColor = true;
            rdProduced.CheckedChanged += rdProduced_CheckedChanged;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 567);
            Controls.Add(gbOC);
            Controls.Add(txtStaffNote);
            Controls.Add(lblStaffNote);
            Controls.Add(btnReplace);
            Controls.Add(btnCancel);
            Controls.Add(llBack);
            Controls.Add(grpStatus);
            Controls.Add(btnFindSimilar);
            Controls.Add(txtDeliveryDate);
            Controls.Add(txtAmount);
            Controls.Add(txtStatus);
            Controls.Add(txtShipping);
            Controls.Add(txtAddress);
            Controls.Add(txtUserID);
            Controls.Add(txtQuantity);
            Controls.Add(txtFurniture);
            Controls.Add(txtOrderID);
            Controls.Add(lblStatusType);
            Controls.Add(lblShippingType);
            Controls.Add(lblAddress);
            Controls.Add(lblDeliveryDate);
            Controls.Add(lblAmount);
            Controls.Add(lblUser);
            Controls.Add(lblQuantity);
            Controls.Add(lblFurniture);
            Controls.Add(lblOrder);
            Controls.Add(lblback);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvOrderControl);
            Controls.Add(lblTitle);
            Name = "Order";
            Text = "Order";
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).EndInit();
            gbOC.ResumeLayout(false);
            gbOC.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private GroupBox grpStatus;
        private RadioButton rbAll;
        private RadioButton rbCancel;
        private RadioButton rbFailed;
        private RadioButton rbDelivered;
        private RadioButton rbTransit;
        private RadioButton rbProduction;
        private RadioButton rbPending;
        private Button btnFindSimilar;
        private TextBox txtDeliveryDate;
        private TextBox txtAmount;
        private TextBox txtStatus;
        private TextBox txtShipping;
        private TextBox txtAddress;
        private TextBox txtUserID;
        private TextBox txtQuantity;
        private TextBox txtFurniture;
        private TextBox txtOrderID;
        private Label lblStatusType;
        private Label lblShippingType;
        private Label lblAddress;
        private Label lblDeliveryDate;
        private Label lblAmount;
        private Label lblUser;
        private Label lblQuantity;
        private Label lblFurniture;
        private Label lblOrder;
        private Label lblback;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvOrderControl;
        private Label lblTitle;
        private Button btnCancel;
        private Button btnReplace;
        private TextBox txtStaffNote;
        private Label lblStaffNote;
        private RadioButton radReplace;
        private RadioButton radRefund;
        private RadioButton radUnderreview;
        private RadioButton radCompleted;
        private GroupBox gbOC;
        private RadioButton rbCustomOrders;
        private RadioButton rbOrders;
        private RadioButton rdWaitingforDelivery;
        private RadioButton rdProduced;
    }
}