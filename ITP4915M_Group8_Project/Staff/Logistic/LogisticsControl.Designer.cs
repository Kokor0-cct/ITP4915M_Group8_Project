namespace ITP4915M_Group8_Project.Staff.Logistic
{
    partial class Logistics_Control
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
            dgvDeliveryControl = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnCompleteDelivery = new Button();
            lblShippingRequest = new Label();
            lblItem = new Label();
            lblItemType = new Label();
            lblCreateDate = new Label();
            lblCollectionAddress = new Label();
            lblDeliveryDate = new Label();
            lblDeliveryAddress = new Label();
            lblStatusType = new Label();
            txtSRID = new TextBox();
            txtIID = new TextBox();
            txtItemType = new TextBox();
            txtCreatedDate = new TextBox();
            txtDeliveryAddress = new TextBox();
            txtStatus = new TextBox();
            txtCollectionAddress = new TextBox();
            txtDeliveryDate = new TextBox();
            groupBox1 = new GroupBox();
            llBack = new LinkLabel();
            btnAccept = new Button();
            rbOrder = new RadioButton();
            rbCO = new RadioButton();
            rbMaterial = new RadioButton();
            grpRadio = new GroupBox();
            rbAll = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveryControl).BeginInit();
            groupBox1.SuspendLayout();
            grpRadio.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(401, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Logistic Delivery Control";
            // 
            // dgvDeliveryControl
            // 
            dgvDeliveryControl.AllowUserToAddRows = false;
            dgvDeliveryControl.AllowUserToDeleteRows = false;
            dgvDeliveryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveryControl.Location = new Point(77, 93);
            dgvDeliveryControl.MultiSelect = false;
            dgvDeliveryControl.Name = "dgvDeliveryControl";
            dgvDeliveryControl.ReadOnly = true;
            dgvDeliveryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveryControl.Size = new Size(944, 149);
            dgvDeliveryControl.TabIndex = 3;
            dgvDeliveryControl.CellClick += dgvOrderControl_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(77, 66);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(157, 15);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search Shipping Request ID :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(240, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(418, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 24);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(616, 458);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 26);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCompleteDelivery
            // 
            btnCompleteDelivery.Location = new Point(890, 458);
            btnCompleteDelivery.Name = "btnCompleteDelivery";
            btnCompleteDelivery.Size = new Size(131, 26);
            btnCompleteDelivery.TabIndex = 24;
            btnCompleteDelivery.Text = "Complete Delivery";
            btnCompleteDelivery.UseVisualStyleBackColor = true;
            btnCompleteDelivery.Click += btnCompleteDelivery_Click;
            // 
            // lblShippingRequest
            // 
            lblShippingRequest.AutoSize = true;
            lblShippingRequest.Location = new Point(91, 272);
            lblShippingRequest.Name = "lblShippingRequest";
            lblShippingRequest.Size = new Size(116, 15);
            lblShippingRequest.TabIndex = 25;
            lblShippingRequest.Text = "Shipping Request ID:";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(270, 24);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(48, 15);
            lblItem.TabIndex = 26;
            lblItem.Text = "Item ID:";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(456, 25);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(61, 15);
            lblItemType.TabIndex = 27;
            lblItemType.Text = "Item Type:";
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Location = new Point(52, 54);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(78, 15);
            lblCreateDate.TabIndex = 28;
            lblCreateDate.Text = "Created Date:";
            // 
            // lblCollectionAddress
            // 
            lblCollectionAddress.AutoSize = true;
            lblCollectionAddress.Location = new Point(21, 83);
            lblCollectionAddress.Name = "lblCollectionAddress";
            lblCollectionAddress.Size = new Size(109, 15);
            lblCollectionAddress.TabIndex = 29;
            lblCollectionAddress.Text = "Collection Address:";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(315, 54);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(79, 15);
            lblDeliveryDate.TabIndex = 30;
            lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Location = new Point(430, 83);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(97, 15);
            lblDeliveryAddress.TabIndex = 31;
            lblDeliveryAddress.Text = "Delivery Address:";
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(597, 155);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(42, 15);
            lblStatusType.TabIndex = 33;
            lblStatusType.Text = "Status:";
            // 
            // txtSRID
            // 
            txtSRID.Location = new Point(324, 22);
            txtSRID.Name = "txtSRID";
            txtSRID.ReadOnly = true;
            txtSRID.Size = new Size(111, 23);
            txtSRID.TabIndex = 34;
            // 
            // txtIID
            // 
            txtIID.Location = new Point(136, 21);
            txtIID.Name = "txtIID";
            txtIID.ReadOnly = true;
            txtIID.Size = new Size(111, 23);
            txtIID.TabIndex = 35;
            // 
            // txtItemType
            // 
            txtItemType.Location = new Point(523, 21);
            txtItemType.Name = "txtItemType";
            txtItemType.ReadOnly = true;
            txtItemType.Size = new Size(162, 23);
            txtItemType.TabIndex = 36;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Location = new Point(136, 51);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(162, 23);
            txtCreatedDate.TabIndex = 37;
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Location = new Point(533, 80);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.ReadOnly = true;
            txtDeliveryAddress.Size = new Size(274, 23);
            txtDeliveryAddress.TabIndex = 38;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(645, 152);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(162, 23);
            txtStatus.TabIndex = 40;
            // 
            // txtCollectionAddress
            // 
            txtCollectionAddress.Location = new Point(136, 80);
            txtCollectionAddress.Name = "txtCollectionAddress";
            txtCollectionAddress.ReadOnly = true;
            txtCollectionAddress.Size = new Size(274, 23);
            txtCollectionAddress.TabIndex = 41;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(400, 51);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.ReadOnly = true;
            txtDeliveryDate.Size = new Size(162, 23);
            txtDeliveryDate.TabIndex = 42;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSRID);
            groupBox1.Controls.Add(lblItem);
            groupBox1.Controls.Add(txtIID);
            groupBox1.Controls.Add(txtDeliveryAddress);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtDeliveryDate);
            groupBox1.Controls.Add(txtCollectionAddress);
            groupBox1.Controls.Add(lblStatusType);
            groupBox1.Controls.Add(lblCollectionAddress);
            groupBox1.Controls.Add(txtItemType);
            groupBox1.Controls.Add(txtCreatedDate);
            groupBox1.Controls.Add(lblDeliveryAddress);
            groupBox1.Controls.Add(lblDeliveryDate);
            groupBox1.Controls.Add(lblCreateDate);
            groupBox1.Controls.Add(lblItemType);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(77, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 189);
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
            // btnAccept
            // 
            btnAccept.Location = new Point(753, 458);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(131, 26);
            btnAccept.TabIndex = 68;
            btnAccept.Text = "Accept Request";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // rbOrder
            // 
            rbOrder.AutoSize = true;
            rbOrder.Location = new Point(12, 11);
            rbOrder.Name = "rbOrder";
            rbOrder.Size = new Size(55, 19);
            rbOrder.TabIndex = 69;
            rbOrder.Text = "Order";
            rbOrder.UseVisualStyleBackColor = true;
            rbOrder.CheckedChanged += rbOrder_CheckedChanged;
            // 
            // rbCO
            // 
            rbCO.AutoSize = true;
            rbCO.Location = new Point(73, 11);
            rbCO.Name = "rbCO";
            rbCO.Size = new Size(100, 19);
            rbCO.TabIndex = 70;
            rbCO.Text = "Custom Order";
            rbCO.UseVisualStyleBackColor = true;
            rbCO.CheckedChanged += rbCO_CheckedChanged;
            // 
            // rbMaterial
            // 
            rbMaterial.AutoSize = true;
            rbMaterial.Location = new Point(179, 11);
            rbMaterial.Name = "rbMaterial";
            rbMaterial.Size = new Size(68, 19);
            rbMaterial.TabIndex = 71;
            rbMaterial.Text = "Material";
            rbMaterial.UseVisualStyleBackColor = true;
            rbMaterial.CheckedChanged += rbMaterial_CheckedChanged;
            // 
            // grpRadio
            // 
            grpRadio.Controls.Add(rbAll);
            grpRadio.Controls.Add(rbOrder);
            grpRadio.Controls.Add(rbCO);
            grpRadio.Controls.Add(rbMaterial);
            grpRadio.Location = new Point(720, 52);
            grpRadio.Name = "grpRadio";
            grpRadio.Size = new Size(301, 34);
            grpRadio.TabIndex = 72;
            grpRadio.TabStop = false;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Checked = true;
            rbAll.Location = new Point(253, 11);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(39, 19);
            rbAll.TabIndex = 72;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // Logistics_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 514);
            Controls.Add(btnAccept);
            Controls.Add(llBack);
            Controls.Add(lblShippingRequest);
            Controls.Add(btnCompleteDelivery);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDeliveryControl);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Controls.Add(grpRadio);
            Name = "Logistics_Control";
            Text = "Logistics Delivery Control";
            ((System.ComponentModel.ISupportInitialize)dgvDeliveryControl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpRadio.ResumeLayout(false);
            grpRadio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvDeliveryControl;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCompleteDelivery;
        private Label lblShippingRequest;
        private Label lblItem;
        private Label lblItemType;
        private Label lblCreateDate;
        private Label lblCollectionAddress;
        private Label lblDeliveryDate;
        private Label lblDeliveryAddress;
        private Label lblStatusType;
        private TextBox txtSRID;
        private TextBox txtIID;
        private TextBox txtItemType;
        private TextBox txtCreatedDate;
        private TextBox txtDeliveryAddress;
        private TextBox txtStatus;
        private TextBox txtCollectionAddress;
        private TextBox txtDeliveryDate;
        private GroupBox groupBox1;
        private LinkLabel llBack;
        private Button btnAccept;
        private RadioButton rbOrder;
        private RadioButton rbCO;
        private RadioButton rbMaterial;
        private GroupBox grpRadio;
        private RadioButton rbAll;
    }
}