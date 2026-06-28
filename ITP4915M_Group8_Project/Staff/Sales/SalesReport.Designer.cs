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
            btnfSearch = new Button();
            txtfSearch = new TextBox();
            dgvfInventoryControl = new DataGridView();
            lblfSearch = new Label();
            lblInventoryFurnitureTitle = new Label();
            lblback = new Label();
            txtStaffNote = new TextBox();
            lblStaffNote = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lblstarttime = new Label();
            lblEndTime = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            btnGenerateDaay = new Button();
            btnGenerateMon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).BeginInit();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(70, 21);
            llBack.Name = "llBack";
            llBack.Size = new Size(49, 17);
            llBack.TabIndex = 102;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            // 
            // btnfSearch
            // 
            btnfSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnfSearch.Location = new Point(292, 57);
            btnfSearch.Name = "btnfSearch";
            btnfSearch.Size = new Size(75, 26);
            btnfSearch.TabIndex = 97;
            btnfSearch.Text = "Search";
            btnfSearch.UseVisualStyleBackColor = true;
            // 
            // txtfSearch
            // 
            txtfSearch.Location = new Point(186, 59);
            txtfSearch.Name = "txtfSearch";
            txtfSearch.Size = new Size(100, 23);
            txtfSearch.TabIndex = 94;
            // 
            // dgvfInventoryControl
            // 
            dgvfInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfInventoryControl.Location = new Point(58, 88);
            dgvfInventoryControl.MultiSelect = false;
            dgvfInventoryControl.Name = "dgvfInventoryControl";
            dgvfInventoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfInventoryControl.Size = new Size(519, 169);
            dgvfInventoryControl.TabIndex = 92;
            // 
            // lblfSearch
            // 
            lblfSearch.AutoSize = true;
            lblfSearch.Location = new Point(70, 62);
            lblfSearch.Name = "lblfSearch";
            lblfSearch.Size = new Size(105, 17);
            lblfSearch.TabIndex = 91;
            lblfSearch.Text = "Search Sales ID :";
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(268, 21);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(263, 31);
            lblInventoryFurnitureTitle.TabIndex = 90;
            lblInventoryFurnitureTitle.Text = "Replace Request List";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(58, 271);
            lblback.Name = "lblback";
            lblback.Size = new Size(519, 83);
            lblback.TabIndex = 100;
            // 
            // txtStaffNote
            // 
            txtStaffNote.Location = new Point(157, 284);
            txtStaffNote.Multiline = true;
            txtStaffNote.Name = "txtStaffNote";
            txtStaffNote.Size = new Size(370, 47);
            txtStaffNote.TabIndex = 104;
            // 
            // lblStaffNote
            // 
            lblStaffNote.AutoSize = true;
            lblStaffNote.Location = new Point(81, 284);
            lblStaffNote.Name = "lblStaffNote";
            lblStaffNote.Size = new Size(70, 17);
            lblStaffNote.TabIndex = 105;
            lblStaffNote.Text = "StaffNote :";
            // 
            // formsPlot1
            // 
            formsPlot1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            formsPlot1.Location = new Point(614, 152);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(289, 259);
            formsPlot1.TabIndex = 106;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(763, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 23);
            dateTimePicker1.TabIndex = 107;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(614, 123);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(140, 23);
            dateTimePicker2.TabIndex = 108;
            // 
            // lblstarttime
            // 
            lblstarttime.AutoSize = true;
            lblstarttime.Location = new Point(984, 103);
            lblstarttime.Name = "lblstarttime";
            lblstarttime.Size = new Size(67, 17);
            lblstarttime.TabIndex = 109;
            lblstarttime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(760, 103);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(62, 17);
            lblEndTime.TabIndex = 110;
            lblEndTime.Text = "End Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(611, 103);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 112;
            label1.Text = "Start Time";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(583, 88);
            label2.Name = "label2";
            label2.Size = new Size(674, 332);
            label2.TabIndex = 113;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox1.Location = new Point(984, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 114;
            // 
            // formsPlot2
            // 
            formsPlot2.AutoValidate = AutoValidate.EnableAllowFocusChange;
            formsPlot2.Location = new Point(955, 152);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(289, 259);
            formsPlot2.TabIndex = 115;
            // 
            // btnGenerateDaay
            // 
            btnGenerateDaay.Location = new Point(828, 97);
            btnGenerateDaay.Name = "btnGenerateDaay";
            btnGenerateDaay.Size = new Size(75, 23);
            btnGenerateDaay.TabIndex = 116;
            btnGenerateDaay.Text = "Generate";
            btnGenerateDaay.UseVisualStyleBackColor = true;
            // 
            // btnGenerateMon
            // 
            btnGenerateMon.Location = new Point(1149, 121);
            btnGenerateMon.Name = "btnGenerateMon";
            btnGenerateMon.Size = new Size(75, 23);
            btnGenerateMon.TabIndex = 117;
            btnGenerateMon.Text = "Generate";
            btnGenerateMon.UseVisualStyleBackColor = true;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 450);
            Controls.Add(btnGenerateMon);
            Controls.Add(btnGenerateDaay);
            Controls.Add(formsPlot2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lblEndTime);
            Controls.Add(lblstarttime);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(formsPlot1);
            Controls.Add(lblStaffNote);
            Controls.Add(txtStaffNote);
            Controls.Add(llBack);
            Controls.Add(btnfSearch);
            Controls.Add(txtfSearch);
            Controls.Add(dgvfInventoryControl);
            Controls.Add(lblfSearch);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Controls.Add(label2);
            Name = "SalesReport";
            Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private Button btnfSearch;
        private TextBox txtfSearch;
        private DataGridView dgvfInventoryControl;
        private Label lblfSearch;
        private Label lblInventoryFurnitureTitle;
        private Label lblback;
        private TextBox txtStaffNote;
        private Label lblStaffNote;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lblstarttime;
        private Label lblEndTime;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Button btnGenerateDaay;
        private Button btnGenerateMon;
    }
}