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
            btnCustomerSupport = new Button();
            btnreplacerequest = new Button();
            grpProduction = new GroupBox();
            grpInventory = new GroupBox();
            grpLogistics = new GroupBox();
            grpDesign = new GroupBox();
            lblWelcome = new Label();
            btnViewOrder = new Button();
            btnSignOut = new Button();
            grpSales.SuspendLayout();
            grpProduction.SuspendLayout();
            grpInventory.SuspendLayout();
            grpLogistics.SuspendLayout();
            SuspendLayout();
            // 
            // lblback
            // 
            lblback.BackColor = SystemColors.Control;
            lblback.BorderStyle = BorderStyle.FixedSingle;
            lblback.ForeColor = SystemColors.ActiveCaptionText;
            lblback.Location = new Point(34, 169);
            lblback.Name = "lblback";
            lblback.Size = new Size(731, 323);
            lblback.TabIndex = 0;
            // 
            // btnSalesService
            // 
            btnSalesService.Location = new Point(21, 27);
            btnSalesService.Name = "btnSalesService";
            btnSalesService.Size = new Size(75, 75);
            btnSalesService.TabIndex = 11;
            btnSalesService.Text = "Customer service";
            btnSalesService.UseVisualStyleBackColor = true;
            btnSalesService.Click += btnSalesService_Click;
            // 
            // btnSalesOrderEdit
            // 
            btnSalesOrderEdit.Location = new Point(111, 24);
            btnSalesOrderEdit.Name = "btnSalesOrderEdit";
            btnSalesOrderEdit.Size = new Size(85, 75);
            btnSalesOrderEdit.TabIndex = 12;
            btnSalesOrderEdit.Text = "Order information Edit";
            btnSalesOrderEdit.UseVisualStyleBackColor = true;
            btnSalesOrderEdit.Click += btnSalesOrderEdit_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(292, 24);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(75, 75);
            btnSalesReport.TabIndex = 13;
            btnSalesReport.Text = "Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.Location = new Point(21, 27);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(93, 75);
            btnInventoryManagement.TabIndex = 14;
            btnInventoryManagement.Text = "Inventory Management";
            btnInventoryManagement.UseVisualStyleBackColor = true;
            btnInventoryManagement.Click += btnInventoryManagement_Click;
            // 
            // btnInventoryMaterlalList
            // 
            btnInventoryMaterlalList.Location = new Point(136, 28);
            btnInventoryMaterlalList.Name = "btnInventoryMaterlalList";
            btnInventoryMaterlalList.Size = new Size(101, 75);
            btnInventoryMaterlalList.TabIndex = 15;
            btnInventoryMaterlalList.Text = "Materlal Requirements List";
            btnInventoryMaterlalList.UseVisualStyleBackColor = true;
            btnInventoryMaterlalList.Click += btnInventoryMaterlalList_Click;
            // 
            // btnLogistic
            // 
            btnLogistic.Location = new Point(23, 27);
            btnLogistic.Name = "btnLogistic";
            btnLogistic.Size = new Size(116, 75);
            btnLogistic.TabIndex = 16;
            btnLogistic.Text = "Logistics\n status\n Modification";
            btnLogistic.UseVisualStyleBackColor = true;
            btnLogistic.Click += btnLogistic_Click;
            // 
            // btnDesign
            // 
            btnDesign.Location = new Point(614, 375);
            btnDesign.Name = "btnDesign";
            btnDesign.RightToLeft = RightToLeft.No;
            btnDesign.Size = new Size(75, 75);
            btnDesign.TabIndex = 17;
            btnDesign.Text = "Upload Design";
            btnDesign.UseVisualStyleBackColor = true;
            btnDesign.Click += btnDesign_Click;
            // 
            // btnProductionList
            // 
            btnProductionList.Location = new Point(12, 27);
            btnProductionList.Name = "btnProductionList";
            btnProductionList.Size = new Size(75, 75);
            btnProductionList.TabIndex = 18;
            btnProductionList.Text = "Task List";
            btnProductionList.UseVisualStyleBackColor = true;
            btnProductionList.Click += btnProductionList_Click;
            // 
            // btnProductionMaterlalSheet
            // 
            btnProductionMaterlalSheet.Location = new Point(119, 28);
            btnProductionMaterlalSheet.Name = "btnProductionMaterlalSheet";
            btnProductionMaterlalSheet.Size = new Size(94, 75);
            btnProductionMaterlalSheet.TabIndex = 19;
            btnProductionMaterlalSheet.Text = "Material Requirement Sheet";
            btnProductionMaterlalSheet.UseVisualStyleBackColor = true;
            btnProductionMaterlalSheet.Click += btnProductionMaterlalSheet_Click;
            // 
            // grpSales
            // 
            grpSales.Controls.Add(btnCustomerSupport);
            grpSales.Controls.Add(btnreplacerequest);
            grpSales.Controls.Add(btnSalesReport);
            grpSales.Controls.Add(btnSalesOrderEdit);
            grpSales.Controls.Add(btnSalesService);
            grpSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSales.Location = new Point(62, 197);
            grpSales.Name = "grpSales";
            grpSales.Size = new Size(478, 122);
            grpSales.TabIndex = 20;
            grpSales.TabStop = false;
            grpSales.Text = "Sales Department";
            // 
            // btnCustomerSupport
            // 
            btnCustomerSupport.Location = new Point(384, 24);
            btnCustomerSupport.Name = "btnCustomerSupport";
            btnCustomerSupport.Size = new Size(75, 75);
            btnCustomerSupport.TabIndex = 29;
            btnCustomerSupport.Text = "Customer Support";
            btnCustomerSupport.UseVisualStyleBackColor = true;
            btnCustomerSupport.Click += btnCustomerSupport_Click;
            // 
            // btnreplacerequest
            // 
            btnreplacerequest.Location = new Point(211, 24);
            btnreplacerequest.Name = "btnreplacerequest";
            btnreplacerequest.Size = new Size(75, 75);
            btnreplacerequest.TabIndex = 28;
            btnreplacerequest.Text = "Replace Request List";
            btnreplacerequest.UseVisualStyleBackColor = true;
            btnreplacerequest.Click += btnreplacerequest_Click;
            // 
            // grpProduction
            // 
            grpProduction.Controls.Add(btnProductionMaterlalSheet);
            grpProduction.Controls.Add(btnProductionList);
            grpProduction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProduction.Location = new Point(327, 348);
            grpProduction.Name = "grpProduction";
            grpProduction.Size = new Size(219, 122);
            grpProduction.TabIndex = 21;
            grpProduction.TabStop = false;
            grpProduction.Text = "Production Department";
            // 
            // grpInventory
            // 
            grpInventory.Controls.Add(btnInventoryManagement);
            grpInventory.Controls.Add(btnInventoryMaterlalList);
            grpInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInventory.Location = new Point(62, 348);
            grpInventory.Name = "grpInventory";
            grpInventory.Size = new Size(247, 122);
            grpInventory.TabIndex = 22;
            grpInventory.TabStop = false;
            grpInventory.Text = "Inventory Control Department";
            // 
            // grpLogistics
            // 
            grpLogistics.Controls.Add(btnLogistic);
            grpLogistics.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogistics.Location = new Point(572, 197);
            grpLogistics.Name = "grpLogistics";
            grpLogistics.Size = new Size(162, 122);
            grpLogistics.TabIndex = 23;
            grpLogistics.TabStop = false;
            grpLogistics.Text = "Logistic Department";
            // 
            // grpDesign
            // 
            grpDesign.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDesign.Location = new Point(571, 348);
            grpDesign.Name = "grpDesign";
            grpDesign.Size = new Size(163, 122);
            grpDesign.TabIndex = 24;
            grpDesign.TabStop = false;
            grpDesign.Text = "Design Department";
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(34, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(428, 19);
            lblWelcome.TabIndex = 25;
            lblWelcome.Text = "Hi, ";
            // 
            // btnViewOrder
            // 
            btnViewOrder.FlatStyle = FlatStyle.System;
            btnViewOrder.Location = new Point(34, 85);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(731, 68);
            btnViewOrder.TabIndex = 26;
            btnViewOrder.Text = "View Orders";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(690, 49);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(75, 29);
            btnSignOut.TabIndex = 27;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(btnSignOut);
            Controls.Add(grpProduction);
            Controls.Add(btnViewOrder);
            Controls.Add(lblWelcome);
            Controls.Add(btnDesign);
            Controls.Add(grpSales);
            Controls.Add(grpInventory);
            Controls.Add(grpLogistics);
            Controls.Add(grpDesign);
            Controls.Add(lblback);
            Margin = new Padding(5);
            Name = "StaffMenu";
            Text = "StaffMenu";
            grpSales.ResumeLayout(false);
            grpProduction.ResumeLayout(false);
            grpInventory.ResumeLayout(false);
            grpLogistics.ResumeLayout(false);
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
        private Button btnreplacerequest;
        private Button btnCustomerSupport;
    }
}