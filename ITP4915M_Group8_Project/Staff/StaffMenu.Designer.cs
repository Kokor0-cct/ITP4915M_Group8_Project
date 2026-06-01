namespace ITP4915M_Group8_Project.Staff
{
    partial class StaffMenu
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
            lblback = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSalesDept = new Label();
            lblProductionDept = new Label();
            lblInventoryDept = new Label();
            lblLogisticDept = new Label();
            lblDesignDept = new Label();
            btnSalesService = new Button();
            btnSalesOrderEdit = new Button();
            btnSalesReport = new Button();
            btnInventoryManagement = new Button();
            btnInventoryMaterlalList = new Button();
            btnLogistic = new Button();
            btnDesign = new Button();
            btnProductionList = new Button();
            btnProductionMaterlalSheet = new Button();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.BackColor = SystemColors.Control;
            lblback.BorderStyle = BorderStyle.FixedSingle;
            lblback.ForeColor = SystemColors.ActiveCaptionText;
            lblback.Location = new Point(31, 87);
            lblback.Name = "lblback";
            lblback.Size = new Size(731, 323);
            lblback.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(59, 114);
            label1.Name = "label1";
            label1.Size = new Size(358, 122);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(440, 114);
            label2.Name = "label2";
            label2.Size = new Size(291, 122);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(59, 265);
            label3.Name = "label3";
            label3.Size = new Size(305, 122);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(388, 265);
            label4.Name = "label4";
            label4.Size = new Size(162, 122);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(568, 265);
            label5.Name = "label5";
            label5.Size = new Size(163, 122);
            label5.TabIndex = 5;
            // 
            // lblSalesDept
            // 
            lblSalesDept.AutoSize = true;
            lblSalesDept.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblSalesDept.Location = new Point(73, 106);
            lblSalesDept.Name = "lblSalesDept";
            lblSalesDept.Size = new Size(117, 17);
            lblSalesDept.TabIndex = 6;
            lblSalesDept.Text = "Sales Department";
            // 
            // lblProductionDept
            // 
            lblProductionDept.AutoSize = true;
            lblProductionDept.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblProductionDept.Location = new Point(460, 106);
            lblProductionDept.Name = "lblProductionDept";
            lblProductionDept.Size = new Size(154, 17);
            lblProductionDept.TabIndex = 7;
            lblProductionDept.Text = "Production Department";
            // 
            // lblInventoryDept
            // 
            lblInventoryDept.AutoSize = true;
            lblInventoryDept.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblInventoryDept.Location = new Point(75, 258);
            lblInventoryDept.Name = "lblInventoryDept";
            lblInventoryDept.Size = new Size(195, 17);
            lblInventoryDept.TabIndex = 8;
            lblInventoryDept.Text = "Inventory Control Department";
            // 
            // lblLogisticDept
            // 
            lblLogisticDept.AutoSize = true;
            lblLogisticDept.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblLogisticDept.Location = new Point(400, 258);
            lblLogisticDept.Name = "lblLogisticDept";
            lblLogisticDept.Size = new Size(132, 17);
            lblLogisticDept.TabIndex = 9;
            lblLogisticDept.Text = "Logistic department";
            // 
            // lblDesignDept
            // 
            lblDesignDept.AutoSize = true;
            lblDesignDept.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblDesignDept.ImageAlign = ContentAlignment.BottomLeft;
            lblDesignDept.Location = new Point(578, 258);
            lblDesignDept.Name = "lblDesignDept";
            lblDesignDept.Size = new Size(127, 17);
            lblDesignDept.TabIndex = 10;
            lblDesignDept.Text = "Design department";
            // 
            // btnSalesService
            // 
            btnSalesService.Location = new Point(89, 142);
            btnSalesService.Name = "btnSalesService";
            btnSalesService.Size = new Size(75, 75);
            btnSalesService.TabIndex = 11;
            btnSalesService.Text = "Customer service";
            btnSalesService.UseVisualStyleBackColor = true;
            btnSalesService.Click += btnSalesService_Click;
            // 
            // btnSalesOrderEdit
            // 
            btnSalesOrderEdit.Location = new Point(195, 142);
            btnSalesOrderEdit.Name = "btnSalesOrderEdit";
            btnSalesOrderEdit.Size = new Size(85, 75);
            btnSalesOrderEdit.TabIndex = 12;
            btnSalesOrderEdit.Text = "Order information Edit";
            btnSalesOrderEdit.UseVisualStyleBackColor = true;
            btnSalesOrderEdit.Click += btnSalesOrderEdit_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(310, 142);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(75, 75);
            btnSalesReport.TabIndex = 13;
            btnSalesReport.Text = "Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.Location = new Point(107, 292);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(93, 75);
            btnInventoryManagement.TabIndex = 14;
            btnInventoryManagement.Text = "Inventory Management";
            btnInventoryManagement.UseVisualStyleBackColor = true;
            btnInventoryManagement.Click += btnInventoryManagement_Click;
            // 
            // btnInventoryMaterlalList
            // 
            btnInventoryMaterlalList.Location = new Point(230, 292);
            btnInventoryMaterlalList.Name = "btnInventoryMaterlalList";
            btnInventoryMaterlalList.Size = new Size(101, 75);
            btnInventoryMaterlalList.TabIndex = 15;
            btnInventoryMaterlalList.Text = "Materlal Requirements List";
            btnInventoryMaterlalList.UseVisualStyleBackColor = true;
            // 
            // btnLogistic
            // 
            btnLogistic.Location = new Point(423, 292);
            btnLogistic.Name = "btnLogistic";
            btnLogistic.Size = new Size(92, 75);
            btnLogistic.TabIndex = 16;
            btnLogistic.Text = "Logistics\n status\n modification";
            btnLogistic.UseVisualStyleBackColor = true;
            btnLogistic.Click += btnLogistic_Click;
            // 
            // btnDesign
            // 
            btnDesign.Location = new Point(611, 292);
            btnDesign.Name = "btnDesign";
            btnDesign.RightToLeft = RightToLeft.No;
            btnDesign.Size = new Size(75, 75);
            btnDesign.TabIndex = 17;
            btnDesign.Text = "Upload Design";
            btnDesign.UseVisualStyleBackColor = true;
            // 
            // btnProductionList
            // 
            btnProductionList.Location = new Point(470, 142);
            btnProductionList.Name = "btnProductionList";
            btnProductionList.Size = new Size(75, 75);
            btnProductionList.TabIndex = 18;
            btnProductionList.Text = "Task List";
            btnProductionList.UseVisualStyleBackColor = true;
            // 
            // btnProductionMaterlalSheet
            // 
            btnProductionMaterlalSheet.Location = new Point(592, 142);
            btnProductionMaterlalSheet.Name = "btnProductionMaterlalSheet";
            btnProductionMaterlalSheet.Size = new Size(94, 75);
            btnProductionMaterlalSheet.TabIndex = 19;
            btnProductionMaterlalSheet.Text = "Materlal Requirement Sheet";
            btnProductionMaterlalSheet.UseVisualStyleBackColor = true;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductionMaterlalSheet);
            Controls.Add(btnProductionList);
            Controls.Add(btnDesign);
            Controls.Add(btnLogistic);
            Controls.Add(btnInventoryMaterlalList);
            Controls.Add(btnInventoryManagement);
            Controls.Add(btnSalesReport);
            Controls.Add(btnSalesOrderEdit);
            Controls.Add(btnSalesService);
            Controls.Add(lblDesignDept);
            Controls.Add(lblLogisticDept);
            Controls.Add(lblInventoryDept);
            Controls.Add(lblProductionDept);
            Controls.Add(lblSalesDept);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblback);
            Name = "StaffMenu";
            Text = "StaffMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblback;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSalesDept;
        private Label lblProductionDept;
        private Label lblInventoryDept;
        private Label lblLogisticDept;
        private Label lblDesignDept;
        private Button btnSalesService;
        private Button btnSalesOrderEdit;
        private Button btnSalesReport;
        private Button btnInventoryManagement;
        private Button btnInventoryMaterlalList;
        private Button btnLogistic;
        private Button btnDesign;
        private Button btnProductionList;
        private Button btnProductionMaterlalSheet;
    }
}