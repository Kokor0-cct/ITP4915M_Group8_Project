namespace ITP4915M_Group8_Project.Staff.Sales
{
    partial class Replace_Request_List
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
            btnAccept = new Button();
            btnRejected = new Button();
            btnfSearch = new Button();
            txtReason = new TextBox();
            txtType = new TextBox();
            txtfSearch = new TextBox();
            lblType = new Label();
            dgvfInventoryControl = new DataGridView();
            lblfSearch = new Label();
            lblInventoryFurnitureTitle = new Label();
            lblback = new Label();
            lblReason = new Label();
            gbStatusType = new GroupBox();
            radAccept = new RadioButton();
            radRejected = new RadioButton();
            radPending = new RadioButton();
            rdbALL = new RadioButton();
            lblStaffNote = new Label();
            txtStaffNote = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).BeginInit();
            gbStatusType.SuspendLayout();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(69, 33);
            llBack.Name = "llBack";
            llBack.Size = new Size(49, 17);
            llBack.TabIndex = 86;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(355, 396);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(144, 31);
            btnAccept.TabIndex = 85;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnRejected
            // 
            btnRejected.Location = new Point(205, 396);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(144, 31);
            btnRejected.TabIndex = 82;
            btnRejected.Text = "Rejected";
            btnRejected.UseVisualStyleBackColor = true;
            btnRejected.Click += btnRejected_Click;
            // 
            // btnfSearch
            // 
            btnfSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnfSearch.Location = new Point(291, 69);
            btnfSearch.Name = "btnfSearch";
            btnfSearch.Size = new Size(75, 26);
            btnfSearch.TabIndex = 81;
            btnfSearch.Text = "Search";
            btnfSearch.UseVisualStyleBackColor = true;
            btnfSearch.Click += btnfSearch_Click;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(107, 290);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ReadOnly = true;
            txtReason.Size = new Size(382, 47);
            txtReason.TabIndex = 80;
            // 
            // txtType
            // 
            txtType.Location = new Point(92, 400);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(107, 23);
            txtType.TabIndex = 76;
            // 
            // txtfSearch
            // 
            txtfSearch.Location = new Point(185, 71);
            txtfSearch.Name = "txtfSearch";
            txtfSearch.Size = new Size(100, 23);
            txtfSearch.TabIndex = 75;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(43, 403);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 17);
            lblType.TabIndex = 71;
            lblType.Text = "Type :";
            // 
            // dgvfInventoryControl
            // 
            dgvfInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfInventoryControl.Location = new Point(69, 100);
            dgvfInventoryControl.MultiSelect = false;
            dgvfInventoryControl.Name = "dgvfInventoryControl";
            dgvfInventoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfInventoryControl.Size = new Size(664, 169);
            dgvfInventoryControl.TabIndex = 70;
            dgvfInventoryControl.CellClick += dgvfInventoryControl_CellClick;
            // 
            // lblfSearch
            // 
            lblfSearch.AutoSize = true;
            lblfSearch.Location = new Point(69, 74);
            lblfSearch.Name = "lblfSearch";
            lblfSearch.Size = new Size(110, 17);
            lblfSearch.TabIndex = 69;
            lblfSearch.Text = "Search Order ID :";
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(218, 32);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(349, 31);
            lblInventoryFurnitureTitle.TabIndex = 68;
            lblInventoryFurnitureTitle.Text = "Inventory Furniture Control";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(32, 282);
            lblback.Name = "lblback";
            lblback.Size = new Size(498, 159);
            lblback.TabIndex = 84;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(43, 293);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(58, 17);
            lblReason.TabIndex = 83;
            lblReason.Text = "Reason :";
            // 
            // gbStatusType
            // 
            gbStatusType.Controls.Add(radAccept);
            gbStatusType.Controls.Add(radRejected);
            gbStatusType.Controls.Add(radPending);
            gbStatusType.Controls.Add(rdbALL);
            gbStatusType.Location = new Point(536, 282);
            gbStatusType.Name = "gbStatusType";
            gbStatusType.Size = new Size(231, 159);
            gbStatusType.TabIndex = 87;
            gbStatusType.TabStop = false;
            gbStatusType.Text = "Status Type";
            // 
            // radAccept
            // 
            radAccept.AutoSize = true;
            radAccept.Location = new Point(12, 100);
            radAccept.Name = "radAccept";
            radAccept.Size = new Size(65, 21);
            radAccept.TabIndex = 3;
            radAccept.TabStop = true;
            radAccept.Text = "Accept";
            radAccept.UseVisualStyleBackColor = true;
            // 
            // radRejected
            // 
            radRejected.AutoSize = true;
            radRejected.Location = new Point(134, 63);
            radRejected.Name = "radRejected";
            radRejected.Size = new Size(76, 21);
            radRejected.TabIndex = 2;
            radRejected.TabStop = true;
            radRejected.Text = "Rejected";
            radRejected.UseVisualStyleBackColor = true;
            // 
            // radPending
            // 
            radPending.AutoSize = true;
            radPending.Location = new Point(12, 63);
            radPending.Name = "radPending";
            radPending.Size = new Size(73, 21);
            radPending.TabIndex = 1;
            radPending.TabStop = true;
            radPending.Text = "Pending";
            radPending.UseVisualStyleBackColor = true;
            // 
            // rdbALL
            // 
            rdbALL.AutoSize = true;
            rdbALL.Location = new Point(12, 22);
            rdbALL.Name = "rdbALL";
            rdbALL.Size = new Size(40, 21);
            rdbALL.TabIndex = 0;
            rdbALL.TabStop = true;
            rdbALL.Text = "All";
            rdbALL.UseVisualStyleBackColor = true;
            // 
            // lblStaffNote
            // 
            lblStaffNote.AutoSize = true;
            lblStaffNote.Location = new Point(43, 346);
            lblStaffNote.Name = "lblStaffNote";
            lblStaffNote.Size = new Size(70, 17);
            lblStaffNote.TabIndex = 89;
            lblStaffNote.Text = "StaffNote :";
            // 
            // txtStaffNote
            // 
            txtStaffNote.Location = new Point(119, 343);
            txtStaffNote.Multiline = true;
            txtStaffNote.Name = "txtStaffNote";
            txtStaffNote.Size = new Size(370, 47);
            txtStaffNote.TabIndex = 88;
            txtStaffNote.TextChanged += txtStaffNote_TextChanged;
            // 
            // Replace_Request_List
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(lblStaffNote);
            Controls.Add(txtStaffNote);
            Controls.Add(gbStatusType);
            Controls.Add(llBack);
            Controls.Add(btnAccept);
            Controls.Add(lblReason);
            Controls.Add(btnRejected);
            Controls.Add(btnfSearch);
            Controls.Add(txtReason);
            Controls.Add(txtType);
            Controls.Add(txtfSearch);
            Controls.Add(lblType);
            Controls.Add(dgvfInventoryControl);
            Controls.Add(lblfSearch);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Name = "Replace_Request_List";
            Text = "Replace_Request_List";
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).EndInit();
            gbStatusType.ResumeLayout(false);
            gbStatusType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private Button btnAccept;
        private Button btnRejected;
        private Label lblFurnitureDesc;
        private Button btnfUpdateFurniture;
        private Button btnfSearch;
        private TextBox txtReason;
        private TextBox txtFurniturePrice;
        private TextBox txtFurnitureType;
        private TextBox txtFurnitureQuantity;
        private TextBox txtType;
        private TextBox txtfSearch;
        private Label lblFurnitureType;
        private Label lblFurniturePrice;
        private Label lblFurnitureQuantity;
        private Label lblType;
        private DataGridView dgvfInventoryControl;
        private Label lblfSearch;
        private Label lblInventoryFurnitureTitle;
        private Label lblback;
        private Label lblReason;
        private GroupBox gbStatusType;
        private RadioButton radAccept;
        private RadioButton radRejected;
        private RadioButton radPending;
        private RadioButton rdbALL;
        private Label lblStaffNote;
        private TextBox txtStaffNote;
    }
}