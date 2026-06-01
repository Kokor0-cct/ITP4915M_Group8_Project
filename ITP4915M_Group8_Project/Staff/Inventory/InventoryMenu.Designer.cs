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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labInvCon
            // 
            labInvCon.AutoSize = true;
            labInvCon.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            labInvCon.Location = new Point(289, 9);
            labInvCon.Name = "labInvCon";
            labInvCon.Size = new Size(210, 31);
            labInvCon.TabIndex = 0;
            labInvCon.Text = "Inventory Menu";
            // 
            // btnToFurniture
            // 
            btnToFurniture.Location = new Point(159, 113);
            btnToFurniture.Name = "btnToFurniture";
            btnToFurniture.Size = new Size(150, 52);
            btnToFurniture.TabIndex = 1;
            btnToFurniture.Text = "Inventory Furniture";
            btnToFurniture.UseVisualStyleBackColor = true;
            btnToFurniture.Click += btnToFurniture_Click;
            // 
            // btnToMaterial
            // 
            btnToMaterial.Location = new Point(159, 262);
            btnToMaterial.Name = "btnToMaterial";
            btnToMaterial.Size = new Size(150, 52);
            btnToMaterial.TabIndex = 2;
            btnToMaterial.Text = "Inventory Material";
            btnToMaterial.UseVisualStyleBackColor = true;
            btnToMaterial.Click += btnToMaterial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(100, 74);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 3;
            label1.Text = "Furniture";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(611, 93);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(100, 225);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 5;
            label3.Text = "Material ";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(90, 242);
            label4.Name = "label4";
            label4.Size = new Size(611, 93);
            label4.TabIndex = 6;
            // 
            // InventoryMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 449);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnToMaterial);
            Controls.Add(btnToFurniture);
            Controls.Add(labInvCon);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "InventoryMenu";
            Text = "Inventory Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labInvCon;
        private Button btnToFurniture;
        private Button btnToMaterial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}