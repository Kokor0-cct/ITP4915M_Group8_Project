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
            label1 = new Label();
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
            btnSubmitRequest.Location = new Point(350, 350);
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
            btnADDMaterialRequirement.Location = new Point(12, 86);
            btnADDMaterialRequirement.Name = "btnADDMaterialRequirement";
            btnADDMaterialRequirement.Size = new Size(111, 26);
            btnADDMaterialRequirement.TabIndex = 14;
            btnADDMaterialRequirement.Text = "Add  Material";
            btnADDMaterialRequirement.UseVisualStyleBackColor = true;
            btnADDMaterialRequirement.Click += btnADDMaterialRequirement_Click;
            // 
            // btndeleteMaterialRequirement
            // 
            btndeleteMaterialRequirement.Location = new Point(144, 86);
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
            fpMaterialRequirement.Location = new Point(12, 148);
            fpMaterialRequirement.Name = "fpMaterialRequirement";
            fpMaterialRequirement.Size = new Size(350, 197);
            fpMaterialRequirement.TabIndex = 16;
            // 
            // lalMaterial
            // 
            lalMaterial.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalMaterial.Location = new Point(12, 119);
            lalMaterial.Name = "lalMaterial";
            lalMaterial.Size = new Size(59, 26);
            lalMaterial.TabIndex = 0;
            lalMaterial.Text = "Material";
            // 
            // lalQuantity
            // 
            lalQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lalQuantity.Location = new Point(260, 119);
            lalQuantity.Name = "lalQuantity";
            lalQuantity.Size = new Size(56, 26);
            lalQuantity.TabIndex = 17;
            lalQuantity.Text = "Quantity";
            // 
            // cmbLevel
            // 
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(392, 148);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(121, 25);
            cmbLevel.TabIndex = 18;
            cmbLevel.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(7, 145);
            label1.Name = "label1";
            label1.Size = new Size(359, 203);
            label1.TabIndex = 0;
            // 
            // FMaterialRequirementSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 402);
            Controls.Add(cmbLevel);
            Controls.Add(lalQuantity);
            Controls.Add(lalMaterial);
            Controls.Add(fpMaterialRequirement);
            Controls.Add(btndeleteMaterialRequirement);
            Controls.Add(btnADDMaterialRequirement);
            Controls.Add(btnSubmitRequest);
            Controls.Add(btnBack);
            Controls.Add(lalMaterialRequirementSheet);
            Controls.Add(label1);
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
        private Label label1;
    }
}
