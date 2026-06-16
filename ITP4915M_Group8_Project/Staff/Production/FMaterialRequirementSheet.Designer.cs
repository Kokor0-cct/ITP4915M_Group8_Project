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
            SuspendLayout();
            // 
            // lalMaterialRequirementSheet
            // 
            lalMaterialRequirementSheet.AutoSize = true;
            lalMaterialRequirementSheet.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterialRequirementSheet.Location = new Point(11, 18);
            lalMaterialRequirementSheet.Margin = new Padding(2, 0, 2, 0);
            lalMaterialRequirementSheet.Name = "lalMaterialRequirementSheet";
            lalMaterialRequirementSheet.Size = new Size(377, 35);
            lalMaterialRequirementSheet.TabIndex = 0;
            lalMaterialRequirementSheet.Text = "Material Requirement Sheet";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(481, 309);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(350, 309);
            btnSubmitRequest.Margin = new Padding(2);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(112, 23);
            btnSubmitRequest.TabIndex = 11;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // btnADDMaterialRequirement
            // 
            btnADDMaterialRequirement.Location = new Point(12, 76);
            btnADDMaterialRequirement.Name = "btnADDMaterialRequirement";
            btnADDMaterialRequirement.Size = new Size(111, 23);
            btnADDMaterialRequirement.TabIndex = 14;
            btnADDMaterialRequirement.Text = "Add  Material";
            btnADDMaterialRequirement.UseVisualStyleBackColor = true;
            btnADDMaterialRequirement.Click += btnADDMaterialRequirement_Click;
            // 
            // btndeleteMaterialRequirement
            // 
            btndeleteMaterialRequirement.Location = new Point(144, 76);
            btndeleteMaterialRequirement.Name = "btndeleteMaterialRequirement";
            btndeleteMaterialRequirement.Size = new Size(111, 23);
            btndeleteMaterialRequirement.TabIndex = 15;
            btndeleteMaterialRequirement.Text = "Delete Material";
            btndeleteMaterialRequirement.UseVisualStyleBackColor = true;
            btndeleteMaterialRequirement.Click += btndeleteMaterialRequirement_Click;
            // 
            // fpMaterialRequirement
            // 
            fpMaterialRequirement.AutoScroll = true;
            fpMaterialRequirement.Location = new Point(12, 131);
            fpMaterialRequirement.Name = "fpMaterialRequirement";
            fpMaterialRequirement.Size = new Size(350, 141);
            fpMaterialRequirement.TabIndex = 16;
            // 
            // lalMaterial
            // 
            lalMaterial.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterial.Location = new Point(12, 105);
            lalMaterial.Name = "lalMaterial";
            lalMaterial.Size = new Size(59, 23);
            lalMaterial.TabIndex = 0;
            lalMaterial.Text = "Material";
            // 
            // lalQuantity
            // 
            lalQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalQuantity.Location = new Point(260, 105);
            lalQuantity.Name = "lalQuantity";
            lalQuantity.Size = new Size(56, 23);
            lalQuantity.TabIndex = 17;
            lalQuantity.Text = "Quantity";
            // 
            // FMaterialRequirementSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 355);
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
    }
}
