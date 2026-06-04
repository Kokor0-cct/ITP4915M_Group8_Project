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
            btnSalesService = new Button();
            btnSalesOrderEdit = new Button();
            btnSalesReport = new Button();
            btnInventoryManagement = new Button();
            btnInventoryMaterlalList = new Button();
            btnLogistic = new Button();
            btnDesign = new Button();
            btnProductionList = new Button();
            btnProductionMaterlalSheet = new Button();
            grpSales = new GroupBox();
            grpProduction = new GroupBox();
            grpInventory = new GroupBox();
            grpLogistics = new GroupBox();
            grpDesign = new GroupBox();
            lblWelcome = new Label();
            btnViewOrder = new Button();
            btnSignOut = new Button();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.BackColor = SystemColors.Control;
            lblback.BorderStyle = BorderStyle.FixedSingle;
            lblback.ForeColor = SystemColors.ActiveCaptionText;
            lblback.Location = new Point(53, 230);
            lblback.Margin = new Padding(5, 0, 5, 0);
            lblback.Name = "lblback";
            lblback.Size = new Size(1148, 436);
            lblback.TabIndex = 0;
            // 
            // btnSalesService
            // 
            btnSalesService.Location = new Point(145, 303);
            btnSalesService.Margin = new Padding(5, 4, 5, 4);
            btnSalesService.Name = "btnSalesService";
            btnSalesService.Size = new Size(118, 101);
            btnSalesService.TabIndex = 11;
            btnSalesService.Text = "Customer service";
            btnSalesService.UseVisualStyleBackColor = true;
            btnSalesService.Click += btnSalesService_Click;
            // 
            // btnSalesOrderEdit
            // 
            btnSalesOrderEdit.Location = new Point(311, 303);
            btnSalesOrderEdit.Margin = new Padding(5, 4, 5, 4);
            btnSalesOrderEdit.Name = "btnSalesOrderEdit";
            btnSalesOrderEdit.Size = new Size(134, 101);
            btnSalesOrderEdit.TabIndex = 12;
            btnSalesOrderEdit.Text = "Order information Edit";
            btnSalesOrderEdit.UseVisualStyleBackColor = true;
            btnSalesOrderEdit.Click += btnSalesOrderEdit_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(492, 303);
            btnSalesReport.Margin = new Padding(5, 4, 5, 4);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(118, 101);
            btnSalesReport.TabIndex = 13;
            btnSalesReport.Text = "Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.Location = new Point(173, 507);
            btnInventoryManagement.Margin = new Padding(5, 4, 5, 4);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(146, 101);
            btnInventoryManagement.TabIndex = 14;
            btnInventoryManagement.Text = "Inventory Management";
            btnInventoryManagement.UseVisualStyleBackColor = true;
            btnInventoryManagement.Click += btnInventoryManagement_Click;
            // 
            // btnInventoryMaterlalList
            // 
            btnInventoryMaterlalList.Location = new Point(366, 507);
            btnInventoryMaterlalList.Margin = new Padding(5, 4, 5, 4);
            btnInventoryMaterlalList.Name = "btnInventoryMaterlalList";
            btnInventoryMaterlalList.Size = new Size(159, 101);
            btnInventoryMaterlalList.TabIndex = 15;
            btnInventoryMaterlalList.Text = "Materlal Requirements List";
            btnInventoryMaterlalList.UseVisualStyleBackColor = true;
            // 
            // btnLogistic
            // 
            btnLogistic.Location = new Point(669, 507);
            btnLogistic.Margin = new Padding(5, 4, 5, 4);
            btnLogistic.Name = "btnLogistic";
            btnLogistic.Size = new Size(145, 101);
            btnLogistic.TabIndex = 16;
            btnLogistic.Text = "Logistics\n status\n modification";
            btnLogistic.UseVisualStyleBackColor = true;
            btnLogistic.Click += btnLogistic_Click;
            // 
            // btnDesign
            // 
            btnDesign.Location = new Point(965, 507);
            btnDesign.Margin = new Padding(5, 4, 5, 4);
            btnDesign.Name = "btnDesign";
            btnDesign.RightToLeft = RightToLeft.No;
            btnDesign.Size = new Size(118, 101);
            btnDesign.TabIndex = 17;
            btnDesign.Text = "Upload Design";
            btnDesign.UseVisualStyleBackColor = true;
            // 
            // btnProductionList
            // 
            btnProductionList.Location = new Point(743, 303);
            btnProductionList.Margin = new Padding(5, 4, 5, 4);
            btnProductionList.Name = "btnProductionList";
            btnProductionList.Size = new Size(118, 101);
            btnProductionList.TabIndex = 18;
            btnProductionList.Text = "Task List";
            btnProductionList.UseVisualStyleBackColor = true;
            // 
            // btnProductionMaterlalSheet
            // 
            btnProductionMaterlalSheet.Location = new Point(935, 303);
            btnProductionMaterlalSheet.Margin = new Padding(5, 4, 5, 4);
            btnProductionMaterlalSheet.Name = "btnProductionMaterlalSheet";
            btnProductionMaterlalSheet.Size = new Size(148, 101);
            btnProductionMaterlalSheet.TabIndex = 19;
            btnProductionMaterlalSheet.Text = "Materlal Requirement Sheet";
            btnProductionMaterlalSheet.UseVisualStyleBackColor = true;
            // 
            // grpSales
            // 
            grpSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSales.Location = new Point(97, 267);
            grpSales.Margin = new Padding(5, 4, 5, 4);
            grpSales.Name = "grpSales";
            grpSales.Padding = new Padding(5, 4, 5, 4);
            grpSales.Size = new Size(563, 165);
            grpSales.TabIndex = 20;
            grpSales.TabStop = false;
            grpSales.Text = "Sales Department";
            // 
            // grpProduction
            // 
            grpProduction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProduction.Location = new Point(696, 267);
            grpProduction.Margin = new Padding(5, 4, 5, 4);
            grpProduction.Name = "grpProduction";
            grpProduction.Padding = new Padding(5, 4, 5, 4);
            grpProduction.Size = new Size(457, 165);
            grpProduction.TabIndex = 21;
            grpProduction.TabStop = false;
            grpProduction.Text = "Production Department";
            // 
            // grpInventory
            // 
            grpInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInventory.Location = new Point(97, 471);
            grpInventory.Margin = new Padding(5, 4, 5, 4);
            grpInventory.Name = "grpInventory";
            grpInventory.Padding = new Padding(5, 4, 5, 4);
            grpInventory.Size = new Size(479, 165);
            grpInventory.TabIndex = 22;
            grpInventory.TabStop = false;
            grpInventory.Text = "Inventory Control Department";
            // 
            // grpLogistics
            // 
            grpLogistics.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogistics.Location = new Point(614, 471);
            grpLogistics.Margin = new Padding(5, 4, 5, 4);
            grpLogistics.Name = "grpLogistics";
            grpLogistics.Padding = new Padding(5, 4, 5, 4);
            grpLogistics.Size = new Size(255, 165);
            grpLogistics.TabIndex = 23;
            grpLogistics.TabStop = false;
            grpLogistics.Text = "Logistic Department";
            // 
            // grpDesign
            // 
            grpDesign.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDesign.Location = new Point(897, 471);
            grpDesign.Margin = new Padding(5, 4, 5, 4);
            grpDesign.Name = "grpDesign";
            grpDesign.Padding = new Padding(5, 4, 5, 4);
            grpDesign.Size = new Size(256, 165);
            grpDesign.TabIndex = 24;
            grpDesign.TabStop = false;
            grpDesign.Text = "Design Department";
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(53, 26);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(673, 26);
            lblWelcome.TabIndex = 25;
            lblWelcome.Text = "Hi, ";
            lblWelcome.Click += lblWelcome_Click_1;
            // 
            // btnViewOrder
            // 
            btnViewOrder.FlatStyle = FlatStyle.System;
            btnViewOrder.Location = new Point(53, 115);
            btnViewOrder.Margin = new Padding(5, 4, 5, 4);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(1149, 92);
            btnViewOrder.TabIndex = 26;
            btnViewOrder.Text = "View Orders";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(1084, 66);
            btnSignOut.Margin = new Padding(5, 4, 5, 4);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(118, 41);
            btnSignOut.TabIndex = 27;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 713);
            Controls.Add(btnSignOut);
            Controls.Add(btnViewOrder);
            Controls.Add(lblWelcome);
            Controls.Add(btnProductionMaterlalSheet);
            Controls.Add(btnProductionList);
            Controls.Add(btnDesign);
            Controls.Add(btnLogistic);
            Controls.Add(btnInventoryMaterlalList);
            Controls.Add(btnInventoryManagement);
            Controls.Add(btnSalesReport);
            Controls.Add(btnSalesOrderEdit);
            Controls.Add(btnSalesService);
            Controls.Add(grpSales);
            Controls.Add(grpProduction);
            Controls.Add(grpInventory);
            Controls.Add(grpLogistics);
            Controls.Add(grpDesign);
            Controls.Add(lblback);
            Margin = new Padding(8, 7, 8, 7);
            Name = "StaffMenu";
            Text = "StaffMenu";
            ResumeLayout(false);
        }

        #endregion

        private Label lblback;
        private Button btnSalesService;
        private Button btnSalesOrderEdit;
        private Button btnSalesReport;
        private Button btnInventoryManagement;
        private Button btnInventoryMaterlalList;
        private Button btnLogistic;
        private Button btnDesign;
        private Button btnProductionList;
        private Button btnProductionMaterlalSheet;
        private GroupBox grpSales;
        private GroupBox grpProduction;
        private GroupBox grpInventory;
        private GroupBox grpLogistics;
        private GroupBox grpDesign;
        private Label lblWelcome;
        private Button btnViewOrder;
        private Button btnSignOut;
    }
}