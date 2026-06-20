namespace ITP4915M_Group8_Project.Staff.Production
{
    partial class Production_Control
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
            lblTitle = new Label();
            dgvOrderControl = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnCompleteProduction = new Button();
            lblOrder = new Label();
            lblFurniture = new Label();
            lblQuantity = new Label();
            lblUser = new Label();
            lblAmount = new Label();
            lblDeliveryDate = new Label();
            lblAddress = new Label();
            lblShippingType = new Label();
            lblStatusType = new Label();
            txtOrderID = new TextBox();
            txtFurniture = new TextBox();
            txtQuantity = new TextBox();
            txtUserID = new TextBox();
            txtAddress = new TextBox();
            txtShipping = new TextBox();
            txtStatus = new TextBox();
            txtAmount = new TextBox();
            txtDeliveryDate = new TextBox();
            btnFindSimilar = new Button();
            groupBox1 = new GroupBox();
            llBack = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(452, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Production Control";
            // 
            // dgvOrderControl
            // 
            dgvOrderControl.AllowUserToAddRows = false;
            dgvOrderControl.AllowUserToDeleteRows = false;
            dgvOrderControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderControl.Location = new Point(77, 93);
            dgvOrderControl.MultiSelect = false;
            dgvOrderControl.Name = "dgvOrderControl";
            dgvOrderControl.ReadOnly = true;
            dgvOrderControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderControl.Size = new Size(944, 149);
            dgvOrderControl.TabIndex = 3;
            dgvOrderControl.CellClick += dgvOrderControl_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(77, 66);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(92, 15);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search OrderID :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(175, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(353, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 24);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(753, 432);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 26);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCompleteProduction
            // 
            btnCompleteProduction.Location = new Point(890, 432);
            btnCompleteProduction.Name = "btnCompleteProduction";
            btnCompleteProduction.Size = new Size(131, 26);
            btnCompleteProduction.TabIndex = 24;
            btnCompleteProduction.Text = "Complete Production";
            btnCompleteProduction.UseVisualStyleBackColor = true;
            btnCompleteProduction.Click += btnCompleteProduction_Click;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(91, 272);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(54, 15);
            lblOrder.TabIndex = 25;
            lblOrder.Text = "Order ID:";
            // 
            // lblFurniture
            // 
            lblFurniture.AutoSize = true;
            lblFurniture.Location = new Point(353, 272);
            lblFurniture.Name = "lblFurniture";
            lblFurniture.Size = new Size(93, 15);
            lblFurniture.TabIndex = 26;
            lblFurniture.Text = "Furniture Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(89, 302);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 27;
            lblQuantity.Text = "Quantity:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(91, 331);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 28;
            lblUser.Text = "User ID:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(353, 302);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(82, 15);
            lblAmount.TabIndex = 29;
            lblAmount.Text = "Total Amount:";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(356, 331);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(79, 15);
            lblDeliveryDate.TabIndex = 30;
            lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(91, 359);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 31;
            lblAddress.Text = "Address:";
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Location = new Point(91, 388);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(84, 15);
            lblShippingType.TabIndex = 32;
            lblShippingType.Text = "Shipping Type:";
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(353, 389);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(42, 15);
            lblStatusType.TabIndex = 33;
            lblStatusType.Text = "Status:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(151, 269);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(162, 23);
            txtOrderID.TabIndex = 34;
            // 
            // txtFurniture
            // 
            txtFurniture.Location = new Point(452, 269);
            txtFurniture.Name = "txtFurniture";
            txtFurniture.ReadOnly = true;
            txtFurniture.Size = new Size(389, 23);
            txtFurniture.TabIndex = 35;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(151, 298);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(162, 23);
            txtQuantity.TabIndex = 36;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(151, 327);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(162, 23);
            txtUserID.TabIndex = 37;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 356);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(690, 23);
            txtAddress.TabIndex = 38;
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(175, 386);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(132, 23);
            txtShipping.TabIndex = 39;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(401, 386);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 40;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(452, 298);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(92, 23);
            txtAmount.TabIndex = 41;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(452, 328);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.ReadOnly = true;
            txtDeliveryDate.Size = new Size(209, 23);
            txtDeliveryDate.TabIndex = 42;
            // 
            // btnFindSimilar
            // 
            btnFindSimilar.Location = new Point(712, 386);
            btnFindSimilar.Name = "btnFindSimilar";
            btnFindSimilar.Size = new Size(129, 23);
            btnFindSimilar.TabIndex = 44;
            btnFindSimilar.Text = "Find Related Records";
            btnFindSimilar.UseVisualStyleBackColor = true;
            btnFindSimilar.Click += btnFindSimilar_Click;
            // 
            // groupBox1
            // 
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(77, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 178);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(77, 19);
            llBack.Name = "llBack";
            llBack.Size = new Size(91, 15);
            llBack.TabIndex = 67;
            llBack.TabStop = true;
            llBack.Text = "< Back to Menu";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // Production_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 514);
            Controls.Add(llBack);
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
            Controls.Add(btnCompleteProduction);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvOrderControl);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Name = "Production_Control";
            Text = "Logistics Delivery Control";
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvOrderControl;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCompleteProduction;
        private Label lblOrder;
        private Label lblFurniture;
        private Label lblQuantity;
        private Label lblUser;
        private Label lblAmount;
        private Label lblDeliveryDate;
        private Label lblAddress;
        private Label lblShippingType;
        private Label lblStatusType;
        private TextBox txtOrderID;
        private TextBox txtFurniture;
        private TextBox txtQuantity;
        private TextBox txtUserID;
        private TextBox txtAddress;
        private TextBox txtShipping;
        private TextBox txtStatus;
        private TextBox txtAmount;
        private TextBox txtDeliveryDate;
        private Button btnFindSimilar;
        private GroupBox groupBox1;
        private LinkLabel llBack;
    }
}