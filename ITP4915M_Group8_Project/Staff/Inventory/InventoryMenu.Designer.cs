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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            llBack = new LinkLabel();
            btnpurchase = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labInvCon
            // 
            labInvCon.AutoSize = true;
            labInvCon.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            labInvCon.Location = new Point(93, 32);
            labInvCon.Name = "labInvCon";
            labInvCon.Size = new Size(210, 31);
            labInvCon.TabIndex = 0;
            labInvCon.Text = "Inventory Menu";
            // 
            // btnToFurniture
            // 
            btnToFurniture.Font = new Font("Segoe UI", 9F);
            btnToFurniture.Location = new Point(60, 28);
            btnToFurniture.Name = "btnToFurniture";
            btnToFurniture.Size = new Size(150, 52);
            btnToFurniture.TabIndex = 1;
            btnToFurniture.Text = "Inventory Furniture";
            btnToFurniture.UseVisualStyleBackColor = true;
            btnToFurniture.Click += btnToFurniture_Click;
            // 
            // btnToMaterial
            // 
            btnToMaterial.Font = new Font("Segoe UI", 9F);
            btnToMaterial.Location = new Point(20, 28);
            btnToMaterial.Name = "btnToMaterial";
            btnToMaterial.Size = new Size(150, 52);
            btnToMaterial.TabIndex = 2;
            btnToMaterial.Text = "Inventory Material";
            btnToMaterial.UseVisualStyleBackColor = true;
            btnToMaterial.Click += btnToMaterial_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnToFurniture);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(67, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Furniture";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnpurchase);
            groupBox2.Controls.Add(btnToMaterial);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Material";
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(231, 359);
            llBack.Name = "llBack";
            llBack.Size = new Size(102, 17);
            llBack.TabIndex = 9;
            llBack.TabStop = true;
            llBack.Text = "< Back to Menu";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // btnpurchase
            // 
            btnpurchase.Font = new Font("Segoe UI", 9F);
            btnpurchase.Location = new Point(176, 28);
            btnpurchase.Name = "btnpurchase";
            btnpurchase.Size = new Size(150, 52);
            btnpurchase.TabIndex = 2;
            btnpurchase.Text = "Material Purchase";
            btnpurchase.UseVisualStyleBackColor = true;
            btnpurchase.Click += btnpurchase_Click;
            // 
            // InventoryMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 386);
            Controls.Add(llBack);
            Controls.Add(labInvCon);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "InventoryMenu";
            Text = "Inventory Menu";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labInvCon;
        private Button btnToFurniture;
        private Button btnToMaterial;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private LinkLabel llBack;
        private Button btnpurchase;
    }
}