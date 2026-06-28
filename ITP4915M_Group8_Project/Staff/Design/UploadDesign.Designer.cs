namespace ITP4915M_Group8_Project.Staff.Design
{
    partial class UploadDesign
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
            btnfRefresh = new Button();
            btnUpdate = new Button();
            lblFurnitureDesc = new Label();
            btnUpload = new Button();
            txtcfDesc = new TextBox();
            txtcfType = new TextBox();
            txtcfName = new TextBox();
            lblFurnitureType = new Label();
            lblFurniturePrice = new Label();
            lblFurniturName = new Label();
            dgvCFR = new DataGridView();
            lblInventoryFurnitureTitle = new Label();
            lblback = new Label();
            label1 = new Label();
            lblBudget = new Label();
            txtcfrDescription = new TextBox();
            lblType = new Label();
            lblDescription = new Label();
            txtcfrBudget = new TextBox();
            txtcfrType = new TextBox();
            btnClearText = new Button();
            dgvCF = new DataGridView();
            numcfPrice = new NumericUpDown();
            lalQuantity = new Label();
            lalMaterial = new Label();
            fpMaterialRequirement = new FlowLayoutPanel();
            btndeleteMaterialRequirement = new Button();
            btnADDMaterialRequirement = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCFR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numcfPrice).BeginInit();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(15, 9);
            llBack.Name = "llBack";
            llBack.Size = new Size(49, 17);
            llBack.TabIndex = 107;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // btnfRefresh
            // 
            btnfRefresh.Location = new Point(616, 629);
            btnfRefresh.Name = "btnfRefresh";
            btnfRefresh.Size = new Size(131, 29);
            btnfRefresh.TabIndex = 106;
            btnfRefresh.Text = "Refresh";
            btnfRefresh.UseVisualStyleBackColor = true;
            btnfRefresh.Click += btnfRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(233, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 31);
            btnUpdate.TabIndex = 105;
            btnUpdate.Text = "Update Design";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFurnitureDesc
            // 
            lblFurnitureDesc.AutoSize = true;
            lblFurnitureDesc.Location = new Point(296, 542);
            lblFurnitureDesc.Name = "lblFurnitureDesc";
            lblFurnitureDesc.Size = new Size(81, 17);
            lblFurnitureDesc.TabIndex = 103;
            lblFurnitureDesc.Text = "Description :";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(74, 579);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(144, 31);
            btnUpload.TabIndex = 102;
            btnUpload.Text = "Insert Design";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtcfDesc
            // 
            txtcfDesc.Location = new Point(383, 539);
            txtcfDesc.Multiline = true;
            txtcfDesc.Name = "txtcfDesc";
            txtcfDesc.Size = new Size(353, 71);
            txtcfDesc.TabIndex = 100;
            // 
            // txtcfType
            // 
            txtcfType.Location = new Point(523, 501);
            txtcfType.Name = "txtcfType";
            txtcfType.ReadOnly = true;
            txtcfType.Size = new Size(110, 23);
            txtcfType.TabIndex = 98;
            // 
            // txtcfName
            // 
            txtcfName.Location = new Point(181, 501);
            txtcfName.Name = "txtcfName";
            txtcfName.Size = new Size(211, 23);
            txtcfName.TabIndex = 96;
            // 
            // lblFurnitureType
            // 
            lblFurnitureType.AutoSize = true;
            lblFurnitureType.Location = new Point(415, 504);
            lblFurnitureType.Name = "lblFurnitureType";
            lblFurnitureType.Size = new Size(102, 17);
            lblFurnitureType.TabIndex = 95;
            lblFurnitureType.Text = "Furniture Type : ";
            // 
            // lblFurniturePrice
            // 
            lblFurniturePrice.AutoSize = true;
            lblFurniturePrice.Location = new Point(74, 542);
            lblFurniturePrice.Name = "lblFurniturePrice";
            lblFurniturePrice.Size = new Size(98, 17);
            lblFurniturePrice.TabIndex = 94;
            lblFurniturePrice.Text = "Furniture Price :";
            // 
            // lblFurniturName
            // 
            lblFurniturName.AutoSize = true;
            lblFurniturName.Location = new Point(74, 504);
            lblFurniturName.Name = "lblFurniturName";
            lblFurniturName.Size = new Size(101, 17);
            lblFurniturName.TabIndex = 92;
            lblFurniturName.Text = "Furniture Name:";
            // 
            // dgvCFR
            // 
            dgvCFR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCFR.Location = new Point(72, 43);
            dgvCFR.MultiSelect = false;
            dgvCFR.Name = "dgvCFR";
            dgvCFR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCFR.Size = new Size(664, 137);
            dgvCFR.TabIndex = 91;
            dgvCFR.CellClick += dgvCFR_CellClick;
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(294, 9);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(210, 31);
            lblInventoryFurnitureTitle.TabIndex = 90;
            lblInventoryFurnitureTitle.Text = "Tailor-made List";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(63, 490);
            lblback.Name = "lblback";
            lblback.Size = new Size(684, 136);
            lblback.TabIndex = 104;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(63, 194);
            label1.Name = "label1";
            label1.Size = new Size(684, 120);
            label1.TabIndex = 108;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(273, 209);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(57, 17);
            lblBudget.TabIndex = 114;
            lblBudget.Text = "Budget :";
            // 
            // txtcfrDescription
            // 
            txtcfrDescription.Location = new Point(154, 242);
            txtcfrDescription.Multiline = true;
            txtcfrDescription.Name = "txtcfrDescription";
            txtcfrDescription.ReadOnly = true;
            txtcfrDescription.Size = new Size(582, 62);
            txtcfrDescription.TabIndex = 109;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(105, 209);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 17);
            lblType.TabIndex = 110;
            lblType.Text = "Type :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(72, 245);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 17);
            lblDescription.TabIndex = 112;
            lblDescription.Text = "description:";
            // 
            // txtcfrBudget
            // 
            txtcfrBudget.Location = new Point(336, 206);
            txtcfrBudget.Name = "txtcfrBudget";
            txtcfrBudget.ReadOnly = true;
            txtcfrBudget.Size = new Size(100, 23);
            txtcfrBudget.TabIndex = 115;
            // 
            // txtcfrType
            // 
            txtcfrType.Location = new Point(154, 206);
            txtcfrType.Name = "txtcfrType";
            txtcfrType.ReadOnly = true;
            txtcfrType.Size = new Size(100, 23);
            txtcfrType.TabIndex = 116;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(479, 629);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(131, 29);
            btnClearText.TabIndex = 120;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // dgvCF
            // 
            dgvCF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCF.Location = new Point(72, 331);
            dgvCF.MultiSelect = false;
            dgvCF.Name = "dgvCF";
            dgvCF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCF.Size = new Size(664, 145);
            dgvCF.TabIndex = 121;
            dgvCF.CellClick += dgvCF_CellClick;
            // 
            // numcfPrice
            // 
            numcfPrice.Location = new Point(181, 540);
            numcfPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numcfPrice.Name = "numcfPrice";
            numcfPrice.Size = new Size(109, 23);
            numcfPrice.TabIndex = 122;
            // 
            // lalQuantity
            // 
            lalQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalQuantity.Location = new Point(1002, 394);
            lalQuantity.Name = "lalQuantity";
            lalQuantity.Size = new Size(62, 26);
            lalQuantity.TabIndex = 127;
            lalQuantity.Text = "Quantity";
            // 
            // lalMaterial
            // 
            lalMaterial.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterial.Location = new Point(753, 394);
            lalMaterial.Name = "lalMaterial";
            lalMaterial.Size = new Size(59, 26);
            lalMaterial.TabIndex = 123;
            lalMaterial.Text = "Material";
            // 
            // fpMaterialRequirement
            // 
            fpMaterialRequirement.AutoScroll = true;
            fpMaterialRequirement.BorderStyle = BorderStyle.Fixed3D;
            fpMaterialRequirement.Location = new Point(753, 424);
            fpMaterialRequirement.Name = "fpMaterialRequirement";
            fpMaterialRequirement.Size = new Size(359, 202);
            fpMaterialRequirement.TabIndex = 126;
            // 
            // btndeleteMaterialRequirement
            // 
            btndeleteMaterialRequirement.Location = new Point(870, 358);
            btndeleteMaterialRequirement.Name = "btndeleteMaterialRequirement";
            btndeleteMaterialRequirement.Size = new Size(111, 26);
            btndeleteMaterialRequirement.TabIndex = 125;
            btndeleteMaterialRequirement.Text = "Delete Material";
            btndeleteMaterialRequirement.UseVisualStyleBackColor = true;
            btndeleteMaterialRequirement.Click += btndeleteMaterialRequirement_Click;
            // 
            // btnADDMaterialRequirement
            // 
            btnADDMaterialRequirement.Location = new Point(753, 358);
            btnADDMaterialRequirement.Name = "btnADDMaterialRequirement";
            btnADDMaterialRequirement.Size = new Size(111, 26);
            btnADDMaterialRequirement.TabIndex = 124;
            btnADDMaterialRequirement.Text = "Add  Material";
            btnADDMaterialRequirement.UseVisualStyleBackColor = true;
            btnADDMaterialRequirement.Click += btnADDMaterialRequirement_Click;
            // 
            // UploadDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 665);
            Controls.Add(lalQuantity);
            Controls.Add(lalMaterial);
            Controls.Add(fpMaterialRequirement);
            Controls.Add(btndeleteMaterialRequirement);
            Controls.Add(btnADDMaterialRequirement);
            Controls.Add(numcfPrice);
            Controls.Add(dgvCF);
            Controls.Add(btnClearText);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(txtcfrType);
            Controls.Add(txtcfrBudget);
            Controls.Add(lblBudget);
            Controls.Add(lblDescription);
            Controls.Add(lblType);
            Controls.Add(txtcfrDescription);
            Controls.Add(label1);
            Controls.Add(llBack);
            Controls.Add(btnfRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(lblFurnitureDesc);
            Controls.Add(btnUpload);
            Controls.Add(txtcfDesc);
            Controls.Add(txtcfType);
            Controls.Add(txtcfName);
            Controls.Add(lblFurnitureType);
            Controls.Add(lblFurniturePrice);
            Controls.Add(lblFurniturName);
            Controls.Add(dgvCFR);
            Controls.Add(lblback);
            Name = "UploadDesign";
            Text = "                                            ";
            ((System.ComponentModel.ISupportInitialize)dgvCFR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numcfPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private Button btnfRefresh;
        private Button btnUpdate;
        private Label lblFurnitureDesc;
        private Button btnUpload;
        private TextBox txtcfDesc;
        private TextBox txtcfType;
        private TextBox txtcfName;
        private Label lblFurnitureType;
        private Label lblFurniturePrice;
        private Label lblFurniturName;
        private DataGridView dgvCFR;
        private Label lblInventoryFurnitureTitle;
        private Label lblback;
        private Label label1;
        private Label lblBudget;
        private TextBox txtcfrDescription;
        private Label lblType;
        private Label lblDescription;
        private TextBox txtcfrBudget;
        private TextBox txtcfrType;
        private Button btnClearText;
        private DataGridView dgvCF;
        private NumericUpDown numcfPrice;
        private Label lalQuantity;
        private Label lalMaterial;
        private FlowLayoutPanel fpMaterialRequirement;
        private Button btndeleteMaterialRequirement;
        private Button btnADDMaterialRequirement;
    }
}