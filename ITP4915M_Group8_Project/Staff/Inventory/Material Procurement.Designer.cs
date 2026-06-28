namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class Material_Procurement
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
            cmbProductionSite = new ComboBox();
            lblDeliveryAddress = new Label();
            lblRequiredDate = new Label();
            txtRequiredDate = new TextBox();
            lalQuantity = new Label();
            lalMaterial = new Label();
            fpMaterialRequirement = new FlowLayoutPanel();
            btndeleteMaterialRequirement = new Button();
            btnADDMaterialRequirement = new Button();
            btnSubmitRequest = new Button();
            btnBack = new Button();
            lalMaterialRequirementSheet = new Label();
            SuspendLayout();
            // 
            // cmbProductionSite
            // 
            cmbProductionSite.FormattingEnabled = true;
            cmbProductionSite.Location = new Point(458, 261);
            cmbProductionSite.Name = "cmbProductionSite";
            cmbProductionSite.Size = new Size(121, 25);
            cmbProductionSite.TabIndex = 37;
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblDeliveryAddress.Location = new Point(458, 238);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(112, 17);
            lblDeliveryAddress.TabIndex = 36;
            lblDeliveryAddress.Text = "Delivery Address";
            // 
            // lblRequiredDate
            // 
            lblRequiredDate.AutoSize = true;
            lblRequiredDate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblRequiredDate.Location = new Point(458, 176);
            lblRequiredDate.Name = "lblRequiredDate";
            lblRequiredDate.Size = new Size(96, 17);
            lblRequiredDate.TabIndex = 35;
            lblRequiredDate.Text = "Required Date";
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(458, 198);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(121, 23);
            txtRequiredDate.TabIndex = 34;
            // 
            // lalQuantity
            // 
            lalQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalQuantity.Location = new Point(273, 104);
            lalQuantity.Name = "lalQuantity";
            lalQuantity.Size = new Size(62, 26);
            lalQuantity.TabIndex = 31;
            lalQuantity.Text = "Quantity";
            // 
            // lalMaterial
            // 
            lalMaterial.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterial.Location = new Point(24, 104);
            lalMaterial.Name = "lalMaterial";
            lalMaterial.Size = new Size(59, 26);
            lalMaterial.TabIndex = 24;
            lalMaterial.Text = "Material";
            // 
            // fpMaterialRequirement
            // 
            fpMaterialRequirement.AutoScroll = true;
            fpMaterialRequirement.BorderStyle = BorderStyle.Fixed3D;
            fpMaterialRequirement.Location = new Point(24, 134);
            fpMaterialRequirement.Name = "fpMaterialRequirement";
            fpMaterialRequirement.Size = new Size(359, 202);
            fpMaterialRequirement.TabIndex = 30;
            // 
            // btndeleteMaterialRequirement
            // 
            btndeleteMaterialRequirement.Location = new Point(141, 68);
            btndeleteMaterialRequirement.Name = "btndeleteMaterialRequirement";
            btndeleteMaterialRequirement.Size = new Size(111, 26);
            btndeleteMaterialRequirement.TabIndex = 29;
            btndeleteMaterialRequirement.Text = "Delete Material";
            btndeleteMaterialRequirement.UseVisualStyleBackColor = true;
            // 
            // btnADDMaterialRequirement
            // 
            btnADDMaterialRequirement.Location = new Point(24, 68);
            btnADDMaterialRequirement.Name = "btnADDMaterialRequirement";
            btnADDMaterialRequirement.Size = new Size(111, 26);
            btnADDMaterialRequirement.TabIndex = 28;
            btnADDMaterialRequirement.Text = "Add  Material";
            btnADDMaterialRequirement.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(431, 341);
            btnSubmitRequest.Margin = new Padding(2);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(112, 26);
            btnSubmitRequest.TabIndex = 27;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(547, 341);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 26);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lalMaterialRequirementSheet
            // 
            lalMaterialRequirementSheet.AutoSize = true;
            lalMaterialRequirementSheet.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterialRequirementSheet.Location = new Point(23, 12);
            lalMaterialRequirementSheet.Margin = new Padding(2, 0, 2, 0);
            lalMaterialRequirementSheet.Name = "lalMaterialRequirementSheet";
            lalMaterialRequirementSheet.Size = new Size(377, 35);
            lalMaterialRequirementSheet.TabIndex = 25;
            lalMaterialRequirementSheet.Text = "Material Requirement Sheet";
            // 
            // Material_Procurement
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 402);
            Controls.Add(cmbProductionSite);
            Controls.Add(lblDeliveryAddress);
            Controls.Add(lblRequiredDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(lalQuantity);
            Controls.Add(lalMaterial);
            Controls.Add(fpMaterialRequirement);
            Controls.Add(btndeleteMaterialRequirement);
            Controls.Add(btnADDMaterialRequirement);
            Controls.Add(btnSubmitRequest);
            Controls.Add(btnBack);
            Controls.Add(lalMaterialRequirementSheet);
            Name = "Material_Procurement";
            Text = "Material_Procurement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductionSite;
        private Label lblDeliveryAddress;
        private Label lblRequiredDate;
        private TextBox txtRequiredDate;
        private Label lalQuantity;
        private Label lalMaterial;
        private FlowLayoutPanel fpMaterialRequirement;
        private Button btndeleteMaterialRequirement;
        private Button btnADDMaterialRequirement;
        private Button btnSubmitRequest;
        private Button btnBack;
        private Label lalMaterialRequirementSheet;
    }
}