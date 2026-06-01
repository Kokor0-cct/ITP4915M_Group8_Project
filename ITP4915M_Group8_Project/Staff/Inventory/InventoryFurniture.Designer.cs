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
            lblfSearch = new Label();
            dgvfInventoryControl = new DataGridView();
            lblFurniturName = new Label();
            lblFurnitureQuantity = new Label();
            lblFurniturePrice = new Label();
            lblFurniturType = new Label();
            txtfSearch = new TextBox();
            txtFurnitureName = new TextBox();
            txtFurnitureQuantity = new TextBox();
            txtFurnitureType = new TextBox();
            txtFurniturePrice = new TextBox();
            txtFurnitureDesc = new TextBox();
            btnfSearch = new Button();
            btnfDeleteFurniture = new Button();
            btnfUpdateFurniture = new Button();
            lblFurnitureDesc = new Label();
            lblback = new Label();
            btnfInsertFurniture = new Button();
            btnfRefresh = new Button();
            btnfClearTextBox = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).BeginInit();
            SuspendLayout();
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(224, 9);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(349, 31);
            lblInventoryFurnitureTitle.TabIndex = 0;
            lblInventoryFurnitureTitle.Text = "Inventory Furniture Control";
            // 
            // lblfSearch
            // 
            lblfSearch.AutoSize = true;
            lblfSearch.Location = new Point(75, 51);
            lblfSearch.Name = "lblfSearch";
            lblfSearch.Size = new Size(93, 17);
            lblfSearch.TabIndex = 1;
            lblfSearch.Text = "Search Name :";
            // 
            // dgvfInventoryControl
            // 
            dgvfInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfInventoryControl.Location = new Point(75, 77);
            dgvfInventoryControl.MultiSelect = false;
            dgvfInventoryControl.Name = "dgvfInventoryControl";
            dgvfInventoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfInventoryControl.Size = new Size(664, 169);
            dgvfInventoryControl.TabIndex = 2;
            dgvfInventoryControl.RowEnter += dgvInventoryControl_RowEnter;
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
            // txtfSearch
            // 
            txtfSearch.Location = new Point(167, 48);
            txtfSearch.Name = "txtfSearch";
            txtfSearch.Size = new Size(100, 23);
            txtfSearch.TabIndex = 8;
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
            // btnfSearch
            // 
            btnfSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnfSearch.Location = new Point(273, 48);
            btnfSearch.Name = "btnfSearch";
            btnfSearch.Size = new Size(75, 23);
            btnfSearch.TabIndex = 14;
            btnfSearch.Text = "Search";
            btnfSearch.UseVisualStyleBackColor = true;
            btnfSearch.Click += btnSearch_Click;
            // 
            // btnfDeleteFurniture
            // 
            btnfDeleteFurniture.Location = new Point(617, 409);
            btnfDeleteFurniture.Name = "btnfDeleteFurniture";
            btnfDeleteFurniture.Size = new Size(131, 29);
            btnfDeleteFurniture.TabIndex = 15;
            btnfDeleteFurniture.Text = "Delete Furniture";
            btnfDeleteFurniture.UseVisualStyleBackColor = true;
            btnfDeleteFurniture.Click += btnDeleteFurniture_Click;
            // 
            // btnfUpdateFurniture
            // 
            btnfUpdateFurniture.Location = new Point(75, 349);
            btnfUpdateFurniture.Name = "btnfUpdateFurniture";
            btnfUpdateFurniture.Size = new Size(144, 31);
            btnfUpdateFurniture.TabIndex = 16;
            btnfUpdateFurniture.Text = "Update Furniture";
            btnfUpdateFurniture.UseVisualStyleBackColor = true;
            btnfUpdateFurniture.Click += btnUpdateFurniture_Click;
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
            // btnfInsertFurniture
            // 
            btnfInsertFurniture.Location = new Point(234, 349);
            btnfInsertFurniture.Name = "btnfInsertFurniture";
            btnfInsertFurniture.Size = new Size(144, 31);
            btnfInsertFurniture.TabIndex = 19;
            btnfInsertFurniture.Text = "Insert Furniture";
            btnfInsertFurniture.UseVisualStyleBackColor = true;
            btnfInsertFurniture.Click += btnInsertFurniture_Click;
            // 
            // btnfRefresh
            // 
            btnfRefresh.Location = new Point(480, 409);
            btnfRefresh.Name = "btnfRefresh";
            btnfRefresh.Size = new Size(131, 29);
            btnfRefresh.TabIndex = 20;
            btnfRefresh.Text = "Refresh";
            btnfRefresh.UseVisualStyleBackColor = true;
            btnfRefresh.Click += btnRefresh_Click;
            // 
            // btnfClearTextBox
            // 
            btnfClearTextBox.Location = new Point(343, 409);
            btnfClearTextBox.Name = "btnfClearTextBox";
            btnfClearTextBox.Size = new Size(131, 29);
            btnfClearTextBox.TabIndex = 21;
            btnfClearTextBox.Text = "Clear Text Box";
            btnfClearTextBox.UseVisualStyleBackColor = true;
            btnfClearTextBox.Click += btnClearTextBox_Click;
            // 
            // InventoryFurniture
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfClearTextBox);
            Controls.Add(btnfRefresh);
            Controls.Add(btnfInsertFurniture);
            Controls.Add(lblFurnitureDesc);
            Controls.Add(btnfUpdateFurniture);
            Controls.Add(btnfDeleteFurniture);
            Controls.Add(btnfSearch);
            Controls.Add(txtFurnitureDesc);
            Controls.Add(txtFurniturePrice);
            Controls.Add(txtFurnitureType);
            Controls.Add(txtFurnitureQuantity);
            Controls.Add(txtFurnitureName);
            Controls.Add(txtfSearch);
            Controls.Add(lblFurniturType);
            Controls.Add(lblFurniturePrice);
            Controls.Add(lblFurnitureQuantity);
            Controls.Add(lblFurniturName);
            Controls.Add(dgvfInventoryControl);
            Controls.Add(lblfSearch);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Name = "InventoryFurniture";
            Text = "Inventory Furniture Control";
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryFurnitureTitle;
        private Label lblfSearch;
        private DataGridView dgvfInventoryControl;
        private Label lblFurniturName;
        private Label lblFurnitureQuantity;
        private Label lblFurniturePrice;
        private Label lblFurniturType;
        private Label label7;
        private TextBox txtfSearch;
        private TextBox txtFurnitureName;
        private TextBox txtFurnitureQuantity;
        private TextBox txtFurnitureType;
        private TextBox txtFurniturePrice;
        private TextBox txtFurnitureDesc;
        private Button btnfSearch;
        private Button btnfDeleteFurniture;
        private Button btnfUpdateFurniture;
        private Label lblFurnitureDesc;
        private Label lblback;
        private Button btnfInsertFurniture;
        private Button btnfRefresh;
        private Button btnfClearTextBox;
    }
}