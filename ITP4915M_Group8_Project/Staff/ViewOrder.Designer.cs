namespace ITP4915M_Group8_Project.Staff
{
    partial class ViewOrder
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
            grpStatus = new GroupBox();
            rbAll = new RadioButton();
            rbCancel = new RadioButton();
            rbFailed = new RadioButton();
            rbDelivered = new RadioButton();
            rbTransit = new RadioButton();
            rbProduction = new RadioButton();
            rbPending = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).BeginInit();
            grpStatus.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(893, 457);
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
            lblTitle.Size = new Size(247, 31);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "View Order Control";
            // 
            // btnFindSimilar
            // 
            btnFindSimilar.Location = new Point(535, 420);
            btnFindSimilar.Name = "btnFindSimilar";
            btnFindSimilar.Size = new Size(129, 23);
            btnFindSimilar.TabIndex = 64;
            btnFindSimilar.Text = "Find Related Records";
            btnFindSimilar.UseVisualStyleBackColor = true;
            btnFindSimilar.Click += btnFindSimilar_Click;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(455, 362);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.ReadOnly = true;
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
            // txtStatus
            // 
            txtStatus.Location = new Point(404, 420);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 61;
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(178, 420);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(132, 23);
            txtShipping.TabIndex = 60;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 390);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
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
            // txtQuantity
            // 
            txtQuantity.Location = new Point(154, 332);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(162, 23);
            txtQuantity.TabIndex = 57;
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
            lblStatusType.Location = new Point(356, 423);
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
            lblDeliveryDate.Location = new Point(359, 365);
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
            lblAmount.Size = new Size(82, 15);
            lblAmount.TabIndex = 50;
            lblAmount.Text = "Total Amount:";
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
            lblQuantity.Location = new Point(92, 336);
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
            lblback.Size = new Size(597, 158);
            lblback.TabIndex = 45;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(rbAll);
            grpStatus.Controls.Add(rbCancel);
            grpStatus.Controls.Add(rbFailed);
            grpStatus.Controls.Add(rbDelivered);
            grpStatus.Controls.Add(rbTransit);
            grpStatus.Controls.Add(rbProduction);
            grpStatus.Controls.Add(rbPending);
            grpStatus.Location = new Point(683, 293);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(341, 158);
            grpStatus.TabIndex = 65;
            grpStatus.TabStop = false;
            grpStatus.Text = "Status";
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Location = new Point(6, 22);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(39, 19);
            rbAll.TabIndex = 6;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // rbCancel
            // 
            rbCancel.AutoSize = true;
            rbCancel.Location = new Point(147, 110);
            rbCancel.Name = "rbCancel";
            rbCancel.Size = new Size(61, 19);
            rbCancel.TabIndex = 5;
            rbCancel.TabStop = true;
            rbCancel.Text = "Cancel";
            rbCancel.UseVisualStyleBackColor = true;
            rbCancel.CheckedChanged += rbCancel_CheckedChanged;
            // 
            // rbFailed
            // 
            rbFailed.AutoSize = true;
            rbFailed.Location = new Point(6, 110);
            rbFailed.Name = "rbFailed";
            rbFailed.Size = new Size(56, 19);
            rbFailed.TabIndex = 4;
            rbFailed.TabStop = true;
            rbFailed.Text = "Failed";
            rbFailed.UseVisualStyleBackColor = true;
            rbFailed.CheckedChanged += rbFailed_CheckedChanged;
            // 
            // rbDelivered
            // 
            rbDelivered.AutoSize = true;
            rbDelivered.Location = new Point(147, 85);
            rbDelivered.Name = "rbDelivered";
            rbDelivered.Size = new Size(74, 19);
            rbDelivered.TabIndex = 3;
            rbDelivered.TabStop = true;
            rbDelivered.Text = "Delivered";
            rbDelivered.UseVisualStyleBackColor = true;
            rbDelivered.CheckedChanged += rbDelivered_CheckedChanged;
            // 
            // rbTransit
            // 
            rbTransit.AutoSize = true;
            rbTransit.Location = new Point(6, 85);
            rbTransit.Name = "rbTransit";
            rbTransit.Size = new Size(72, 19);
            rbTransit.TabIndex = 2;
            rbTransit.TabStop = true;
            rbTransit.Text = "In Transit";
            rbTransit.UseVisualStyleBackColor = true;
            rbTransit.CheckedChanged += rbTransit_CheckedChanged;
            // 
            // rbProduction
            // 
            rbProduction.AutoSize = true;
            rbProduction.Location = new Point(147, 60);
            rbProduction.Name = "rbProduction";
            rbProduction.Size = new Size(97, 19);
            rbProduction.TabIndex = 1;
            rbProduction.TabStop = true;
            rbProduction.Text = "In Production";
            rbProduction.UseVisualStyleBackColor = true;
            rbProduction.CheckedChanged += rbProduction_CheckedChanged;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Location = new Point(6, 60);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(69, 19);
            rbPending.TabIndex = 0;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            rbPending.CheckedChanged += rbPending_CheckedChanged;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 514);
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
            Name = "ViewOrder";
            Text = "ViewOrder";
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).EndInit();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
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
        private GroupBox grpStatus;
        private RadioButton rbCancel;
        private RadioButton rbFailed;
        private RadioButton rbDelivered;
        private RadioButton rbTransit;
        private RadioButton rbProduction;
        private RadioButton rbPending;
        private RadioButton rbAll;
    }
}