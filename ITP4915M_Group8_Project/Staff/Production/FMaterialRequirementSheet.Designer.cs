namespace ITP4915M_Group8_Project.Staff.Production
{
    partial class FMaterialRequirementSheet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lalMaterialRequirementSheet = new Label();
            btnBack = new Button();
            btnSubmitRequest = new Button();
            btnADDMaterialRequirement = new Button();
            btndeleteMaterialRequirement = new Button();
            fpMaterialRequirement = new FlowLayoutPanel();
            lalMaterial = new Label();
            lalQuantity = new Label();
            cmbLevel = new ComboBox();
            lblUrgencyLevel = new Label();
            lblRequiredDate = new Label();
            lblDeliveryAddress = new Label();
            cmbProductionSite = new ComboBox();
            dateRequired = new DateTimePicker();
            SuspendLayout();
            // 
            // lalMaterialRequirementSheet
            // 
            lalMaterialRequirementSheet.AutoSize = true;
            lalMaterialRequirementSheet.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterialRequirementSheet.Location = new Point(11, 20);
            lalMaterialRequirementSheet.Margin = new Padding(2, 0, 2, 0);
            lalMaterialRequirementSheet.Name = "lalMaterialRequirementSheet";
            lalMaterialRequirementSheet.Size = new Size(377, 35);
            lalMaterialRequirementSheet.TabIndex = 0;
            lalMaterialRequirementSheet.Text = "Material Requirement Sheet";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(481, 350);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 26);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(365, 350);
            btnSubmitRequest.Margin = new Padding(2);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(112, 26);
            btnSubmitRequest.TabIndex = 11;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnADDMaterialRequirement
            // 
            btnADDMaterialRequirement.Location = new Point(12, 76);
            btnADDMaterialRequirement.Name = "btnADDMaterialRequirement";
            btnADDMaterialRequirement.Size = new Size(111, 26);
            btnADDMaterialRequirement.TabIndex = 14;
            btnADDMaterialRequirement.Text = "Add  Material";
            btnADDMaterialRequirement.UseVisualStyleBackColor = true;
            btnADDMaterialRequirement.Click += btnADDMaterialRequirement_Click;
            // 
            // btndeleteMaterialRequirement
            // 
            btndeleteMaterialRequirement.Location = new Point(129, 76);
            btndeleteMaterialRequirement.Name = "btndeleteMaterialRequirement";
            btndeleteMaterialRequirement.Size = new Size(111, 26);
            btndeleteMaterialRequirement.TabIndex = 15;
            btndeleteMaterialRequirement.Text = "Delete Material";
            btndeleteMaterialRequirement.UseVisualStyleBackColor = true;
            btndeleteMaterialRequirement.Click += btndeleteMaterialRequirement_Click;
            // 
            // fpMaterialRequirement
            // 
            fpMaterialRequirement.AutoScroll = true;
            fpMaterialRequirement.BorderStyle = BorderStyle.Fixed3D;
            fpMaterialRequirement.Location = new Point(12, 142);
            fpMaterialRequirement.Name = "fpMaterialRequirement";
            fpMaterialRequirement.Size = new Size(359, 202);
            fpMaterialRequirement.TabIndex = 16;
            // 
            // lalMaterial
            // 
            lalMaterial.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterial.Location = new Point(12, 112);
            lalMaterial.Name = "lalMaterial";
            lalMaterial.Size = new Size(59, 26);
            lalMaterial.TabIndex = 0;
            lalMaterial.Text = "Material";
            // 
            // lalQuantity
            // 
            lalQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalQuantity.Location = new Point(261, 112);
            lalQuantity.Name = "lalQuantity";
            lalQuantity.Size = new Size(62, 26);
            lalQuantity.TabIndex = 17;
            lalQuantity.Text = "Quantity";
            // 
            // cmbLevel
            // 
            cmbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(392, 148);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(121, 25);
            cmbLevel.TabIndex = 18;
            // 
            // lblUrgencyLevel
            // 
            lblUrgencyLevel.AutoSize = true;
            lblUrgencyLevel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblUrgencyLevel.Location = new Point(392, 126);
            lblUrgencyLevel.Name = "lblUrgencyLevel";
            lblUrgencyLevel.Size = new Size(94, 17);
            lblUrgencyLevel.TabIndex = 19;
            lblUrgencyLevel.Text = "Urgency Level";
            // 
            // lblRequiredDate
            // 
            lblRequiredDate.AutoSize = true;
            lblRequiredDate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblRequiredDate.Location = new Point(392, 185);
            lblRequiredDate.Name = "lblRequiredDate";
            lblRequiredDate.Size = new Size(96, 17);
            lblRequiredDate.TabIndex = 21;
            lblRequiredDate.Text = "Required Date";
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblDeliveryAddress.Location = new Point(392, 247);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(112, 17);
            lblDeliveryAddress.TabIndex = 22;
            lblDeliveryAddress.Text = "Delivery Address";
            // 
            // cmbProductionSite
            // 
            cmbProductionSite.FormattingEnabled = true;
            cmbProductionSite.Location = new Point(392, 270);
            cmbProductionSite.Name = "cmbProductionSite";
            cmbProductionSite.Size = new Size(121, 25);
            cmbProductionSite.TabIndex = 23;
            // 
            // dateRequired
            // 
            dateRequired.Location = new Point(392, 205);
            dateRequired.Name = "dateRequired";
            dateRequired.Size = new Size(121, 23);
            dateRequired.TabIndex = 24;
            // 
            // FMaterialRequirementSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 402);
            Controls.Add(dateRequired);
            Controls.Add(cmbProductionSite);
            Controls.Add(lblDeliveryAddress);
            Controls.Add(lblRequiredDate);
            Controls.Add(lblUrgencyLevel);
            Controls.Add(cmbLevel);
            Controls.Add(lalQuantity);
            Controls.Add(lalMaterial);
            Controls.Add(fpMaterialRequirement);
            Controls.Add(btndeleteMaterialRequirement);
            Controls.Add(btnADDMaterialRequirement);
            Controls.Add(btnSubmitRequest);
            Controls.Add(btnBack);
            Controls.Add(lalMaterialRequirementSheet);
            Margin = new Padding(2);
            Name = "FMaterialRequirementSheet";
            Text = "Material Requirement Sheet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lalMaterialRequirementSheet;
        private Button btnBack;
        private Button btnSubmitRequest;
        private Button btnADDMaterialRequirement;
        private Button btndeleteMaterialRequirement;
        private FlowLayoutPanel fpMaterialRequirement;
        private Label lalMaterial;
        private Label lalQuantity;
        private ComboBox cmbLevel;
        private Label lblUrgencyLevel;
        private Label lblRequiredDate;
        private Label lblDeliveryAddress;
        private ComboBox cmbProductionSite;
        private DateTimePicker dateRequired;
    }
}
