namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class InventoryFurniture
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
            lblInventoryFurnitureTitle = new Label();
            lblSearch = new Label();
            dgvInventoryControl = new DataGridView();
            lblFurniturName = new Label();
            lblFurnitureQuantity = new Label();
            lblFurniturePrice = new Label();
            lblFurniturType = new Label();
            txtSearch = new TextBox();
            txtFurnitureName = new TextBox();
            txtFurnitureQuantity = new TextBox();
            txtFurnitureType = new TextBox();
            txtFurniturePrice = new TextBox();
            txtFurnitureDesc = new TextBox();
            btnSearch = new Button();
            btnDeleteFurniture = new Button();
            btnUpdateFurniture = new Button();
            lblFurnitureDesc = new Label();
            lblback = new Label();
            btnInsertFurniture = new Button();
            btnRefresh = new Button();
            btnClearTextBox = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryControl).BeginInit();
            SuspendLayout();
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(283, 9);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(230, 31);
            lblInventoryFurnitureTitle.TabIndex = 0;
            lblInventoryFurnitureTitle.Text = "Inventory Control";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(75, 51);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(93, 17);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Name :";
            // 
            // dgvInventoryControl
            // 
            dgvInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryControl.Location = new Point(75, 77);
            dgvInventoryControl.MultiSelect = false;
            dgvInventoryControl.Name = "dgvInventoryControl";
            dgvInventoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventoryControl.Size = new Size(664, 169);
            dgvInventoryControl.TabIndex = 2;
            dgvInventoryControl.RowEnter += dgvInventoryControl_RowEnter;
            // 
            // lblFurniturName
            // 
            lblFurniturName.AutoSize = true;
            lblFurniturName.Location = new Point(75, 274);
            lblFurniturName.Name = "lblFurniturName";
            lblFurniturName.Size = new Size(101, 17);
            lblFurniturName.TabIndex = 3;
            lblFurniturName.Text = "Furniture Name:";
            // 
            // lblFurnitureQuantity
            // 
            lblFurnitureQuantity.AutoSize = true;
            lblFurnitureQuantity.Location = new Point(399, 274);
            lblFurnitureQuantity.Name = "lblFurnitureQuantity";
            lblFurnitureQuantity.Size = new Size(118, 17);
            lblFurnitureQuantity.TabIndex = 4;
            lblFurnitureQuantity.Text = "Furniture Quantity :";
            // 
            // lblFurniturePrice
            // 
            lblFurniturePrice.AutoSize = true;
            lblFurniturePrice.Location = new Point(75, 312);
            lblFurniturePrice.Name = "lblFurniturePrice";
            lblFurniturePrice.Size = new Size(98, 17);
            lblFurniturePrice.TabIndex = 5;
            lblFurniturePrice.Text = "Furniture Price :";
            // 
            // lblFurniturType
            // 
            lblFurniturType.AutoSize = true;
            lblFurniturType.Location = new Point(592, 274);
            lblFurniturType.Name = "lblFurniturType";
            lblFurniturType.Size = new Size(95, 17);
            lblFurniturType.TabIndex = 6;
            lblFurniturType.Text = "Furnitur Type : ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(167, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 8;
            // 
            // txtFurnitureName
            // 
            txtFurnitureName.Location = new Point(182, 271);
            txtFurnitureName.Name = "txtFurnitureName";
            txtFurnitureName.Size = new Size(211, 23);
            txtFurnitureName.TabIndex = 9;
            // 
            // txtFurnitureQuantity
            // 
            txtFurnitureQuantity.Location = new Point(523, 271);
            txtFurnitureQuantity.Name = "txtFurnitureQuantity";
            txtFurnitureQuantity.Size = new Size(61, 23);
            txtFurnitureQuantity.TabIndex = 10;
            // 
            // txtFurnitureType
            // 
            txtFurnitureType.Location = new Point(693, 271);
            txtFurnitureType.Name = "txtFurnitureType";
            txtFurnitureType.Size = new Size(44, 23);
            txtFurnitureType.TabIndex = 11;
            // 
            // txtFurniturePrice
            // 
            txtFurniturePrice.Location = new Point(179, 309);
            txtFurniturePrice.Name = "txtFurniturePrice";
            txtFurniturePrice.Size = new Size(112, 23);
            txtFurniturePrice.TabIndex = 12;
            // 
            // txtFurnitureDesc
            // 
            txtFurnitureDesc.Location = new Point(384, 309);
            txtFurnitureDesc.Multiline = true;
            txtFurnitureDesc.Name = "txtFurnitureDesc";
            txtFurnitureDesc.Size = new Size(353, 71);
            txtFurnitureDesc.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(273, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteFurniture
            // 
            btnDeleteFurniture.Location = new Point(617, 409);
            btnDeleteFurniture.Name = "btnDeleteFurniture";
            btnDeleteFurniture.Size = new Size(131, 29);
            btnDeleteFurniture.TabIndex = 15;
            btnDeleteFurniture.Text = "Delete Furniture";
            btnDeleteFurniture.UseVisualStyleBackColor = true;
            btnDeleteFurniture.Click += btnDeleteFurniture_Click;
            // 
            // btnUpdateFurniture
            // 
            btnUpdateFurniture.Location = new Point(75, 349);
            btnUpdateFurniture.Name = "btnUpdateFurniture";
            btnUpdateFurniture.Size = new Size(144, 31);
            btnUpdateFurniture.TabIndex = 16;
            btnUpdateFurniture.Text = "Update Furniture";
            btnUpdateFurniture.UseVisualStyleBackColor = true;
            btnUpdateFurniture.Click += btnUpdateFurniture_Click;
            // 
            // lblFurnitureDesc
            // 
            lblFurnitureDesc.AutoSize = true;
            lblFurnitureDesc.Location = new Point(297, 312);
            lblFurnitureDesc.Name = "lblFurnitureDesc";
            lblFurnitureDesc.Size = new Size(81, 17);
            lblFurnitureDesc.TabIndex = 17;
            lblFurnitureDesc.Text = "Description :";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(64, 259);
            lblback.Name = "lblback";
            lblback.Size = new Size(684, 136);
            lblback.TabIndex = 18;
            // 
            // btnInsertFurniture
            // 
            btnInsertFurniture.Location = new Point(234, 349);
            btnInsertFurniture.Name = "btnInsertFurniture";
            btnInsertFurniture.Size = new Size(144, 31);
            btnInsertFurniture.TabIndex = 19;
            btnInsertFurniture.Text = "Insert Furniture";
            btnInsertFurniture.UseVisualStyleBackColor = true;
            btnInsertFurniture.Click += btnInsertFurniture_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(480, 409);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 29);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClearTextBox
            // 
            btnClearTextBox.Location = new Point(343, 409);
            btnClearTextBox.Name = "btnClearTextBox";
            btnClearTextBox.Size = new Size(131, 29);
            btnClearTextBox.TabIndex = 21;
            btnClearTextBox.Text = "Clear Text Box";
            btnClearTextBox.UseVisualStyleBackColor = true;
            btnClearTextBox.Click += btnClearTextBox_Click;
            // 
            // InventoryFurniture
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearTextBox);
            Controls.Add(btnRefresh);
            Controls.Add(btnInsertFurniture);
            Controls.Add(lblFurnitureDesc);
            Controls.Add(btnUpdateFurniture);
            Controls.Add(btnDeleteFurniture);
            Controls.Add(btnSearch);
            Controls.Add(txtFurnitureDesc);
            Controls.Add(txtFurniturePrice);
            Controls.Add(txtFurnitureType);
            Controls.Add(txtFurnitureQuantity);
            Controls.Add(txtFurnitureName);
            Controls.Add(txtSearch);
            Controls.Add(lblFurniturType);
            Controls.Add(lblFurniturePrice);
            Controls.Add(lblFurnitureQuantity);
            Controls.Add(lblFurniturName);
            Controls.Add(dgvInventoryControl);
            Controls.Add(lblSearch);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Name = "InventoryFurniture";
            Text = "Inventory Furniture Control";
            ((System.ComponentModel.ISupportInitialize)dgvInventoryControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryFurnitureTitle;
        private Label lblSearch;
        private DataGridView dgvInventoryControl;
        private Label lblFurniturName;
        private Label lblFurnitureQuantity;
        private Label lblFurniturePrice;
        private Label lblFurniturType;
        private Label label7;
        private TextBox txtSearch;
        private TextBox txtFurnitureName;
        private TextBox txtFurnitureQuantity;
        private TextBox txtFurnitureType;
        private TextBox txtFurniturePrice;
        private TextBox txtFurnitureDesc;
        private Button btnSearch;
        private Button btnDeleteFurniture;
        private Button btnUpdateFurniture;
        private Label lblFurnitureDesc;
        private Label lblback;
        private Button btnInsertFurniture;
        private Button btnRefresh;
        private Button btnClearTextBox;
    }
}