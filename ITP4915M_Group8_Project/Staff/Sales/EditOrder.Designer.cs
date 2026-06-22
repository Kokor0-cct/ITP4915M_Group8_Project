namespace ITP4915M_Group8_Project.Staff.Sales
{
    partial class EditOrder
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
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvOrderControl = new DataGridView();
            lblTitle = new Label();
            btnFindSimilar = new Button();
            txtDeliveryDate = new TextBox();
            txtAmount = new TextBox();
            txtAddress = new TextBox();
            txtUserID = new TextBox();
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
            llBack = new LinkLabel();
            btnUpdate = new Button();
            nudQuantity = new NumericUpDown();
            cbShipping = new ComboBox();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(893, 293);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 26);
            btnRefresh.TabIndex = 29;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(356, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 24);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 27;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(80, 85);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(92, 15);
            lblSearch.TabIndex = 26;
            lblSearch.Text = "Search OrderID :";
            // 
            // dgvOrderControl
            // 
            dgvOrderControl.AllowUserToAddRows = false;
            dgvOrderControl.AllowUserToDeleteRows = false;
            dgvOrderControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderControl.Location = new Point(80, 112);
            dgvOrderControl.MultiSelect = false;
            dgvOrderControl.Name = "dgvOrderControl";
            dgvOrderControl.ReadOnly = true;
            dgvOrderControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderControl.Size = new Size(944, 162);
            dgvOrderControl.TabIndex = 25;
            dgvOrderControl.CellClick += dgvOrderControl_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(404, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 31);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Edit Order Control";
            // 
            // btnFindSimilar
            // 
            btnFindSimilar.Location = new Point(670, 303);
            btnFindSimilar.Name = "btnFindSimilar";
            btnFindSimilar.Size = new Size(129, 23);
            btnFindSimilar.TabIndex = 64;
            btnFindSimilar.Text = "Find Related Records";
            btnFindSimilar.UseVisualStyleBackColor = true;
            btnFindSimilar.Click += btnFindSimilar_Click;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(455, 361);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(209, 23);
            txtDeliveryDate.TabIndex = 63;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(455, 332);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(92, 23);
            txtAmount.TabIndex = 62;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 390);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(510, 23);
            txtAddress.TabIndex = 59;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(154, 361);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(162, 23);
            txtUserID.TabIndex = 58;
            // 
            // txtFurniture
            // 
            txtFurniture.Location = new Point(455, 303);
            txtFurniture.Name = "txtFurniture";
            txtFurniture.ReadOnly = true;
            txtFurniture.Size = new Size(209, 23);
            txtFurniture.TabIndex = 56;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(154, 303);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(162, 23);
            txtOrderID.TabIndex = 55;
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(356, 422);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(42, 15);
            lblStatusType.TabIndex = 54;
            lblStatusType.Text = "Status:";
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Location = new Point(94, 422);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(84, 15);
            lblShippingType.TabIndex = 53;
            lblShippingType.Text = "Shipping Type:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(94, 393);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 52;
            lblAddress.Text = "Address:";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(356, 365);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(79, 15);
            lblDeliveryDate.TabIndex = 51;
            lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(356, 336);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 50;
            lblAmount.Text = "Amount:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(94, 365);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 49;
            lblUser.Text = "User ID:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(94, 336);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 48;
            lblQuantity.Text = "Quantity:";
            // 
            // lblFurniture
            // 
            lblFurniture.AutoSize = true;
            lblFurniture.Location = new Point(356, 306);
            lblFurniture.Name = "lblFurniture";
            lblFurniture.Size = new Size(93, 15);
            lblFurniture.TabIndex = 47;
            lblFurniture.Text = "Furniture Name:";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(94, 306);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(54, 15);
            lblOrder.TabIndex = 46;
            lblOrder.Text = "Order ID:";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(80, 293);
            lblback.Name = "lblback";
            lblback.Size = new Size(729, 158);
            lblback.TabIndex = 45;
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(80, 38);
            llBack.Name = "llBack";
            llBack.Size = new Size(91, 15);
            llBack.TabIndex = 67;
            llBack.TabStop = true;
            llBack.Text = "< Back to Menu";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(893, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 26);
            btnUpdate.TabIndex = 68;
            btnUpdate.Text = "Update Record";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(154, 334);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(162, 23);
            nudQuantity.TabIndex = 69;
            // 
            // cbShipping
            // 
            cbShipping.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShipping.FormattingEnabled = true;
            cbShipping.Items.AddRange(new object[] { "-Select Shipping Type-", "Ordinary Transport", "Express Shipping" });
            cbShipping.Location = new Point(184, 419);
            cbShipping.Name = "cbShipping";
            cbShipping.Size = new Size(132, 23);
            cbShipping.TabIndex = 70;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "--Select Status--", "Pending", "Accepted", "Waiting For Delivery" });
            cmbStatus.Location = new Point(455, 419);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(130, 23);
            cmbStatus.TabIndex = 71;
            // 
            // EditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 514);
            Controls.Add(cmbStatus);
            Controls.Add(cbShipping);
            Controls.Add(nudQuantity);
            Controls.Add(btnUpdate);
            Controls.Add(llBack);
            Controls.Add(btnFindSimilar);
            Controls.Add(txtDeliveryDate);
            Controls.Add(txtAmount);
            Controls.Add(txtAddress);
            Controls.Add(txtUserID);
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
            Name = "EditOrder";
            Text = "Edit Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvOrderControl;
        private Label lblTitle;
        private Button btnFindSimilar;
        private TextBox txtDeliveryDate;
        private TextBox txtAmount;
        private TextBox txtAddress;
        private TextBox txtUserID;
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
        private LinkLabel llBack;
        private Button btnUpdate;
        private NumericUpDown nudQuantity;
        private ComboBox cbShipping;
        private ComboBox cmbStatus;
    }
}