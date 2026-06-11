namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class InventoryMaterials
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
            lblInventoryMaterialTitle = new Label();
            lblmSearch = new Label();
            lblMaterialName = new Label();
            lblMaterialQuantity = new Label();
            lblMaterialUnit = new Label();
            txtmSearch = new TextBox();
            txtMaterialName = new TextBox();
            txtMaterialUnit = new TextBox();
            txtMaterialQuantity = new TextBox();
            btnmSearch = new Button();
            btnmInsertFurniture = new Button();
            btnmClearTextBox = new Button();
            btnmRefresh = new Button();
            btnmDeleteFurniture = new Button();
            lblback = new Label();
            dgvmInventoryControl = new DataGridView();
            btnmUpdateFurniture = new Button();
            llBack = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvmInventoryControl).BeginInit();
            SuspendLayout();
            // 
            // lblInventoryMaterialTitle
            // 
            lblInventoryMaterialTitle.AutoSize = true;
            lblInventoryMaterialTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblInventoryMaterialTitle.Location = new Point(228, 8);
            lblInventoryMaterialTitle.Name = "lblInventoryMaterialTitle";
            lblInventoryMaterialTitle.Size = new Size(350, 31);
            lblInventoryMaterialTitle.TabIndex = 0;
            lblInventoryMaterialTitle.Text = "Inventory Materials Control";
            // 
            // lblmSearch
            // 
            lblmSearch.AutoSize = true;
            lblmSearch.Location = new Point(69, 44);
            lblmSearch.Name = "lblmSearch";
            lblmSearch.Size = new Size(83, 15);
            lblmSearch.TabIndex = 1;
            lblmSearch.Text = "Search Name :";
            // 
            // lblMaterialName
            // 
            lblMaterialName.AutoSize = true;
            lblMaterialName.Location = new Point(74, 239);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new Size(91, 15);
            lblMaterialName.TabIndex = 2;
            lblMaterialName.Text = "Material Name :";
            // 
            // lblMaterialQuantity
            // 
            lblMaterialQuantity.AutoSize = true;
            lblMaterialQuantity.Location = new Point(403, 239);
            lblMaterialQuantity.Name = "lblMaterialQuantity";
            lblMaterialQuantity.Size = new Size(105, 15);
            lblMaterialQuantity.TabIndex = 3;
            lblMaterialQuantity.Text = "Material Quantity :";
            // 
            // lblMaterialUnit
            // 
            lblMaterialUnit.AutoSize = true;
            lblMaterialUnit.Location = new Point(74, 271);
            lblMaterialUnit.Name = "lblMaterialUnit";
            lblMaterialUnit.Size = new Size(35, 15);
            lblMaterialUnit.TabIndex = 4;
            lblMaterialUnit.Text = "Unit :";
            // 
            // txtmSearch
            // 
            txtmSearch.Location = new Point(164, 41);
            txtmSearch.Name = "txtmSearch";
            txtmSearch.Size = new Size(100, 23);
            txtmSearch.TabIndex = 7;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(182, 236);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(215, 23);
            txtMaterialName.TabIndex = 8;
            // 
            // txtMaterialUnit
            // 
            txtMaterialUnit.Location = new Point(118, 268);
            txtMaterialUnit.Name = "txtMaterialUnit";
            txtMaterialUnit.Size = new Size(100, 23);
            txtMaterialUnit.TabIndex = 9;
            // 
            // txtMaterialQuantity
            // 
            txtMaterialQuantity.Location = new Point(524, 236);
            txtMaterialQuantity.Name = "txtMaterialQuantity";
            txtMaterialQuantity.Size = new Size(209, 23);
            txtMaterialQuantity.TabIndex = 10;
            // 
            // btnmSearch
            // 
            btnmSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnmSearch.Location = new Point(270, 41);
            btnmSearch.Name = "btnmSearch";
            btnmSearch.Size = new Size(75, 23);
            btnmSearch.TabIndex = 11;
            btnmSearch.Text = "Search";
            btnmSearch.UseVisualStyleBackColor = true;
            btnmSearch.Click += btnmSearch_Click;
            // 
            // btnmInsertFurniture
            // 
            btnmInsertFurniture.Location = new Point(261, 301);
            btnmInsertFurniture.Name = "btnmInsertFurniture";
            btnmInsertFurniture.Size = new Size(137, 27);
            btnmInsertFurniture.TabIndex = 13;
            btnmInsertFurniture.Text = "Insert Furniture";
            btnmInsertFurniture.UseVisualStyleBackColor = true;
            btnmInsertFurniture.Click += btnmInsertFurniture_Click;
            // 
            // btnmClearTextBox
            // 
            btnmClearTextBox.Location = new Point(411, 301);
            btnmClearTextBox.Name = "btnmClearTextBox";
            btnmClearTextBox.Size = new Size(137, 27);
            btnmClearTextBox.TabIndex = 14;
            btnmClearTextBox.Text = "Clear Text Box";
            btnmClearTextBox.UseVisualStyleBackColor = true;
            btnmClearTextBox.Click += btnmClearTextBox_Click;
            // 
            // btnmRefresh
            // 
            btnmRefresh.Location = new Point(597, 359);
            btnmRefresh.Name = "btnmRefresh";
            btnmRefresh.Size = new Size(144, 27);
            btnmRefresh.TabIndex = 15;
            btnmRefresh.Text = "Refresh";
            btnmRefresh.UseVisualStyleBackColor = true;
            btnmRefresh.Click += btnmRefresh_Click;
            // 
            // btnmDeleteFurniture
            // 
            btnmDeleteFurniture.Location = new Point(561, 301);
            btnmDeleteFurniture.Name = "btnmDeleteFurniture";
            btnmDeleteFurniture.Size = new Size(137, 27);
            btnmDeleteFurniture.TabIndex = 16;
            btnmDeleteFurniture.Text = "Delete Furniture";
            btnmDeleteFurniture.UseVisualStyleBackColor = true;
            btnmDeleteFurniture.Click += btnmDeleteFurniture_Click;
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(62, 229);
            lblback.Name = "lblback";
            lblback.Size = new Size(679, 117);
            lblback.TabIndex = 17;
            // 
            // dgvmInventoryControl
            // 
            dgvmInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmInventoryControl.Location = new Point(69, 67);
            dgvmInventoryControl.Name = "dgvmInventoryControl";
            dgvmInventoryControl.Size = new Size(664, 150);
            dgvmInventoryControl.TabIndex = 18;
            dgvmInventoryControl.RowEnter += dgvmInventoryControl_RowEnter;
            // 
            // btnmUpdateFurniture
            // 
            btnmUpdateFurniture.Location = new Point(111, 301);
            btnmUpdateFurniture.Name = "btnmUpdateFurniture";
            btnmUpdateFurniture.Size = new Size(137, 27);
            btnmUpdateFurniture.TabIndex = 12;
            btnmUpdateFurniture.Text = "Update Furniture";
            btnmUpdateFurniture.UseVisualStyleBackColor = true;
            btnmUpdateFurniture.Click += btnmUpdateFurniture_Click;
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(62, 9);
            llBack.Name = "llBack";
            llBack.Size = new Size(43, 15);
            llBack.TabIndex = 19;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // InventoryMaterials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 397);
            Controls.Add(llBack);
            Controls.Add(dgvmInventoryControl);
            Controls.Add(btnmDeleteFurniture);
            Controls.Add(btnmRefresh);
            Controls.Add(btnmClearTextBox);
            Controls.Add(btnmInsertFurniture);
            Controls.Add(btnmUpdateFurniture);
            Controls.Add(btnmSearch);
            Controls.Add(txtMaterialQuantity);
            Controls.Add(txtMaterialUnit);
            Controls.Add(txtMaterialName);
            Controls.Add(txtmSearch);
            Controls.Add(lblMaterialUnit);
            Controls.Add(lblMaterialQuantity);
            Controls.Add(lblMaterialName);
            Controls.Add(lblmSearch);
            Controls.Add(lblInventoryMaterialTitle);
            Controls.Add(lblback);
            Name = "InventoryMaterials";
            Text = "Inventory Materials Control";
            ((System.ComponentModel.ISupportInitialize)dgvmInventoryControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryMaterialTitle;
        private Label lblmSearch;
        private Label lblMaterialName;
        private Label lblMaterialQuantity;
        private Label lblMaterialUnit;
        private TextBox txtmSearch;
        private TextBox txtMaterialName;
        private TextBox txtMaterialUnit;
        private TextBox txtMaterialQuantity;
        private Button btnmSearch;
        private Button btnmInsertFurniture;
        private Button btnmClearTextBox;
        private Button btnmRefresh;
        private Button btnmDeleteFurniture;
        private Label lblback;
        private DataGridView dgvmInventoryControl;
        private Button btnmUpdateFurniture;
        private LinkLabel llBack;
    }
}