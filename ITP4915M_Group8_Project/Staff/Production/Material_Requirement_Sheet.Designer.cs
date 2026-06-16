namespace ITP4915M_Group8_Project.Staff.Production
{
    partial class Material_Requirement_Sheet
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            numdMaterialRequirement = new NumericUpDown();
            cmbMaterialRequirement = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numdMaterialRequirement).BeginInit();
            SuspendLayout();
            // 
            // numdMaterialRequirement
            // 
            numdMaterialRequirement.Font = new Font("Microsoft JhengHei UI", 10F);
            numdMaterialRequirement.Location = new Point(240, -1);
            numdMaterialRequirement.Name = "numdMaterialRequirement";
            numdMaterialRequirement.Size = new Size(87, 24);
            numdMaterialRequirement.TabIndex = 1;
            numdMaterialRequirement.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbMaterialRequirement
            // 
            cmbMaterialRequirement.Font = new Font("Microsoft JhengHei UI", 10F);
            cmbMaterialRequirement.FormattingEnabled = true;
            cmbMaterialRequirement.ItemHeight = 17;
            cmbMaterialRequirement.Items.AddRange(new object[] { "bff", "safda" });
            cmbMaterialRequirement.Location = new Point(0, -1);
            cmbMaterialRequirement.Name = "cmbMaterialRequirement";
            cmbMaterialRequirement.Size = new Size(243, 25);
            cmbMaterialRequirement.TabIndex = 2;
            // 
            // Material_Requirement_Sheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numdMaterialRequirement);
            Controls.Add(cmbMaterialRequirement);
            Name = "Material_Requirement_Sheet";
            Size = new Size(326, 22);
            ((System.ComponentModel.ISupportInitialize)numdMaterialRequirement).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numdMaterialRequirement;
        private ComboBox cmbMaterialRequirement;
    }
}
