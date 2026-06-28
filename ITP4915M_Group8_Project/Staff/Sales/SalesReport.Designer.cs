
namespace ITP4915M_Group8_Project.Staff.Sales
{
    partial class SalesReport
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
            llBack = new LinkLabel();
            dvgSalesReport = new DataGridView();
            lblInventoryFurnitureTitle = new Label();
            lblback = new Label();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            lblstarttime = new Label();
            lblEndTime = new Label();
            label1 = new Label();
            btnGenerateDaay = new Button();
            btnGenerateMon = new Button();
            lblTotalAmount = new Label();
            txtAmount = new TextBox();
            dtpMonth = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dvgSalesReport).BeginInit();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(12, 23);
            llBack.Name = "llBack";
            llBack.Size = new Size(49, 17);
            llBack.TabIndex = 102;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // dvgSalesReport
            // 
            dvgSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSalesReport.Location = new Point(58, 88);
            dvgSalesReport.MultiSelect = false;
            dvgSalesReport.Name = "dvgSalesReport";
            dvgSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgSalesReport.Size = new Size(620, 169);
            dvgSalesReport.TabIndex = 92;
            dvgSalesReport.CellContentClick += dvgSalesReport_CellContentClick;
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(255, 9);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(158, 31);
            lblInventoryFurnitureTitle.TabIndex = 90;
            lblInventoryFurnitureTitle.Text = "SalesReport";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(41, 271);
            lblback.Name = "lblback";
            lblback.Size = new Size(650, 123);
            lblback.TabIndex = 100;
            // 
            // dateEnd
            // 
            dateEnd.Checked = false;
            dateEnd.Location = new Point(210, 302);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(140, 23);
            dateEnd.TabIndex = 107;
            // 
            // dateStart
            // 
            dateStart.Location = new Point(61, 302);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(140, 23);
            dateStart.TabIndex = 108;
            // 
            // lblstarttime
            // 
            lblstarttime.AutoSize = true;
            lblstarttime.Location = new Point(462, 284);
            lblstarttime.Name = "lblstarttime";
            lblstarttime.Size = new Size(67, 17);
            lblstarttime.TabIndex = 109;
            lblstarttime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(207, 282);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(62, 17);
            lblEndTime.TabIndex = 110;
            lblEndTime.Text = "End Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 282);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 112;
            label1.Text = "Start Time";
            // 
            // btnGenerateDaay
            // 
            btnGenerateDaay.Location = new Point(356, 302);
            btnGenerateDaay.Name = "btnGenerateDaay";
            btnGenerateDaay.Size = new Size(75, 23);
            btnGenerateDaay.TabIndex = 116;
            btnGenerateDaay.Text = "Generate";
            btnGenerateDaay.UseVisualStyleBackColor = true;
            btnGenerateDaay.Click += btnGenerateDaay_Click;
            // 
            // btnGenerateMon
            // 
            btnGenerateMon.Location = new Point(589, 302);
            btnGenerateMon.Name = "btnGenerateMon";
            btnGenerateMon.Size = new Size(75, 23);
            btnGenerateMon.TabIndex = 117;
            btnGenerateMon.Text = "Generate";
            btnGenerateMon.UseVisualStyleBackColor = true;
            btnGenerateMon.Click += btnGenerateMon_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(61, 339);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(93, 17);
            lblTotalAmount.TabIndex = 119;
            lblTotalAmount.Text = "Total Amount :";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(160, 331);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(289, 32);
            txtAmount.TabIndex = 118;
            // 
            // dtpMonth
            // 
            dtpMonth.Checked = false;
            dtpMonth.Location = new Point(462, 304);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(121, 23);
            dtpMonth.TabIndex = 120;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(dtpMonth);
            Controls.Add(lblTotalAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnGenerateMon);
            Controls.Add(btnGenerateDaay);
            Controls.Add(label1);
            Controls.Add(lblEndTime);
            Controls.Add(lblstarttime);
            Controls.Add(dateStart);
            Controls.Add(dateEnd);
            Controls.Add(llBack);
            Controls.Add(dvgSalesReport);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Name = "SalesReport";
            Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)dvgSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private DataGridView dvgSalesReport;
        private Label lblInventoryFurnitureTitle;
        private Label lblback;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label lblstarttime;
        private Label lblEndTime;
        private Label label1;
        private Button btnGenerateDaay;
        private Button btnGenerateMon;
        private Label lblTotalAmount;
        private TextBox txtAmount;
        private DateTimePicker dtpMonth;
    }
}