namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class InventoryMenu
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
            labInvCon = new Label();
            btnToFurniture = new Button();
            btnToMaterial = new Button();
            SuspendLayout();
            // 
            // labInvCon
            // 
            labInvCon.AutoSize = true;
            labInvCon.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            labInvCon.Location = new Point(58, 19);
            labInvCon.Name = "labInvCon";
            labInvCon.Size = new Size(154, 22);
            labInvCon.TabIndex = 0;
            labInvCon.Text = "Inventory Control";
            // 
            // btnToFurniture
            // 
            btnToFurniture.Location = new Point(62, 74);
            btnToFurniture.Name = "btnToFurniture";
            btnToFurniture.Size = new Size(150, 23);
            btnToFurniture.TabIndex = 1;
            btnToFurniture.Text = "InventoryFurniture";
            btnToFurniture.UseVisualStyleBackColor = true;
            btnToFurniture.Click += btnToFurniture_Click;
            // 
            // btnToMaterial
            // 
            btnToMaterial.Location = new Point(62, 133);
            btnToMaterial.Name = "btnToMaterial";
            btnToMaterial.Size = new Size(150, 23);
            btnToMaterial.TabIndex = 2;
            btnToMaterial.Text = "InventoryMaterial";
            btnToMaterial.UseVisualStyleBackColor = true;
            // 
            // InventoryMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 242);
            Controls.Add(btnToMaterial);
            Controls.Add(btnToFurniture);
            Controls.Add(labInvCon);
            Name = "InventoryMenu";
            Text = "InventoryMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labInvCon;
        private Button btnToFurniture;
        private Button btnToMaterial;
    }
}