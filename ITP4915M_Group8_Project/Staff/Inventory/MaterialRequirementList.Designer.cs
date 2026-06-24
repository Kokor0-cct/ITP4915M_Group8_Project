namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class MaterialRequirementList
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
            lblTitle = new Label();
            dgvMaterialRequestControl = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnCompleteRequest = new Button();
            lblMRID = new Label();
            lblMaterial = new Label();
            lblQuantity = new Label();
            lblUser = new Label();
            lblCreatuibDate = new Label();
            lblRequiredDate = new Label();
            lblUrgencyLevel = new Label();
            txtMRID = new TextBox();
            txtFurniture = new TextBox();
            txtQuantity = new TextBox();
            txtUserID = new TextBox();
            txtUrgencyLevel = new TextBox();
            txtCreationDate = new TextBox();
            txtRequiredDate = new TextBox();
            btnFindSimilar = new Button();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblStatusType = new Label();
            txtStatus = new TextBox();
            llBack = new LinkLabel();
            btnAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialRequestControl).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(412, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Material Requirement List";
            // 
            // dgvMaterialRequestControl
            // 
            dgvMaterialRequestControl.AllowUserToAddRows = false;
            dgvMaterialRequestControl.AllowUserToDeleteRows = false;
            dgvMaterialRequestControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialRequestControl.Location = new Point(77, 93);
            dgvMaterialRequestControl.MultiSelect = false;
            dgvMaterialRequestControl.Name = "dgvMaterialRequestControl";
            dgvMaterialRequestControl.ReadOnly = true;
            dgvMaterialRequestControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialRequestControl.Size = new Size(944, 149);
            dgvMaterialRequestControl.TabIndex = 3;
            dgvMaterialRequestControl.CellClick += dgvOrderControl_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(77, 66);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 15);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search MRID :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(175, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(353, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 24);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(616, 432);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 26);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCompleteRequest
            // 
            btnCompleteRequest.Location = new Point(890, 432);
            btnCompleteRequest.Name = "btnCompleteRequest";
            btnCompleteRequest.Size = new Size(131, 26);
            btnCompleteRequest.TabIndex = 24;
            btnCompleteRequest.Text = "Complete Request";
            btnCompleteRequest.UseVisualStyleBackColor = true;
            btnCompleteRequest.Click += btnCompleteProduction_Click;
            // 
            // lblMRID
            // 
            lblMRID.AutoSize = true;
            lblMRID.Location = new Point(91, 272);
            lblMRID.Name = "lblMRID";
            lblMRID.Size = new Size(112, 15);
            lblMRID.TabIndex = 25;
            lblMRID.Text = "Material Request ID:";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(14, 54);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(88, 15);
            lblMaterial.TabIndex = 26;
            lblMaterial.Text = "Material Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(324, 54);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 27;
            lblQuantity.Text = "Quantity:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(91, 331);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 28;
            lblUser.Text = "User ID:";
            // 
            // lblCreatuibDate
            // 
            lblCreatuibDate.AutoSize = true;
            lblCreatuibDate.Location = new Point(324, 24);
            lblCreatuibDate.Name = "lblCreatuibDate";
            lblCreatuibDate.Size = new Size(82, 15);
            lblCreatuibDate.TabIndex = 29;
            lblCreatuibDate.Text = "Creation Date:";
            // 
            // lblRequiredDate
            // 
            lblRequiredDate.AutoSize = true;
            lblRequiredDate.Location = new Point(14, 111);
            lblRequiredDate.Name = "lblRequiredDate";
            lblRequiredDate.Size = new Size(84, 15);
            lblRequiredDate.TabIndex = 30;
            lblRequiredDate.Text = "Required Date:";
            // 
            // lblUrgencyLevel
            // 
            lblUrgencyLevel.AutoSize = true;
            lblUrgencyLevel.Location = new Point(324, 111);
            lblUrgencyLevel.Name = "lblUrgencyLevel";
            lblUrgencyLevel.Size = new Size(84, 15);
            lblUrgencyLevel.TabIndex = 31;
            lblUrgencyLevel.Text = "Urgency Level:";
            // 
            // txtMRID
            // 
            txtMRID.Location = new Point(132, 21);
            txtMRID.Name = "txtMRID";
            txtMRID.ReadOnly = true;
            txtMRID.Size = new Size(162, 23);
            txtMRID.TabIndex = 34;
            // 
            // txtFurniture
            // 
            txtFurniture.Location = new Point(132, 50);
            txtFurniture.Name = "txtFurniture";
            txtFurniture.ReadOnly = true;
            txtFurniture.Size = new Size(162, 23);
            txtFurniture.TabIndex = 35;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(412, 50);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(172, 23);
            txtQuantity.TabIndex = 36;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(132, 80);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(162, 23);
            txtUserID.TabIndex = 37;
            // 
            // txtUrgencyLevel
            // 
            txtUrgencyLevel.Location = new Point(412, 108);
            txtUrgencyLevel.Name = "txtUrgencyLevel";
            txtUrgencyLevel.ReadOnly = true;
            txtUrgencyLevel.Size = new Size(172, 23);
            txtUrgencyLevel.TabIndex = 38;
            // 
            // txtCreationDate
            // 
            txtCreationDate.Location = new Point(412, 21);
            txtCreationDate.Name = "txtCreationDate";
            txtCreationDate.ReadOnly = true;
            txtCreationDate.Size = new Size(172, 23);
            txtCreationDate.TabIndex = 41;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(132, 109);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.ReadOnly = true;
            txtRequiredDate.Size = new Size(162, 23);
            txtRequiredDate.TabIndex = 42;
            // 
            // btnFindSimilar
            // 
            btnFindSimilar.Location = new Point(638, 21);
            btnFindSimilar.Name = "btnFindSimilar";
            btnFindSimilar.Size = new Size(129, 23);
            btnFindSimilar.TabIndex = 44;
            btnFindSimilar.Text = "Find Related Records";
            btnFindSimilar.UseVisualStyleBackColor = true;
            btnFindSimilar.Click += btnFindSimilar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(btnFindSimilar);
            groupBox1.Controls.Add(lblStatusType);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtMRID);
            groupBox1.Controls.Add(txtFurniture);
            groupBox1.Controls.Add(txtRequiredDate);
            groupBox1.Controls.Add(lblMaterial);
            groupBox1.Controls.Add(txtCreationDate);
            groupBox1.Controls.Add(lblCreatuibDate);
            groupBox1.Controls.Add(txtUrgencyLevel);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblUrgencyLevel);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(lblRequiredDate);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(77, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 178);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(132, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(162, 23);
            txtAddress.TabIndex = 71;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 141);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 70;
            lblAddress.Text = "Address:";
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(590, 152);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(42, 15);
            lblStatusType.TabIndex = 69;
            lblStatusType.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(638, 149);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(129, 23);
            txtStatus.TabIndex = 68;
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(77, 19);
            llBack.Name = "llBack";
            llBack.Size = new Size(91, 15);
            llBack.TabIndex = 67;
            llBack.TabStop = true;
            llBack.Text = "< Back to Menu";
            llBack.LinkClicked += llBack_LinkClicked;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(753, 432);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(131, 26);
            btnAccept.TabIndex = 68;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // MaterialRequirementList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 514);
            Controls.Add(btnAccept);
            Controls.Add(llBack);
            Controls.Add(lblUser);
            Controls.Add(lblMRID);
            Controls.Add(btnCompleteRequest);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvMaterialRequestControl);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Name = "MaterialRequirementList";
            Text = "Material Requirement List";
            ((System.ComponentModel.ISupportInitialize)dgvMaterialRequestControl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvMaterialRequestControl;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCompleteRequest;
        private Label lblMRID;
        private Label lblMaterial;
        private Label lblQuantity;
        private Label lblUser;
        private Label lblCreatuibDate;
        private Label lblRequiredDate;
        private Label lblUrgencyLevel;
        private TextBox txtMRID;
        private TextBox txtFurniture;
        private TextBox txtQuantity;
        private TextBox txtUserID;
        private TextBox txtUrgencyLevel;
        private TextBox txtCreationDate;
        private TextBox txtRequiredDate;
        private Button btnFindSimilar;
        private GroupBox groupBox1;
        private LinkLabel llBack;
        private TextBox txtStatus;
        private Label lblStatusType;
        private Button btnAccept;
        private TextBox txtAddress;
        private Label lblAddress;
    }
}