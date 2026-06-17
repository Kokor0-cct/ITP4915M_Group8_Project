namespace ITP4915M_Group8_Project.Customer.Customized
{
    partial class DesignList
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
            btnfRefresh = new Button();
            btnNotAccepted = new Button();
            lblFurnitureDesc = new Label();
            btnapprove = new Button();
            btnCancel = new Button();
            txtFurnitureDesc = new TextBox();
            txtFurniturePrice = new TextBox();
            txtFurnitureType = new TextBox();
            txtFurnitureState = new TextBox();
            txtFurnitureName = new TextBox();
            lblFurnitureType = new Label();
            lblFurniturePrice = new Label();
            lblFurnitureState = new Label();
            lblFurniturName = new Label();
            dgvfInventoryControl = new DataGridView();
            lblInventoryFurnitureTitle = new Label();
            lblback = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).BeginInit();
            SuspendLayout();
            // 
            // llBack
            // 
            llBack.AutoSize = true;
            llBack.Location = new Point(12, 9);
            llBack.Name = "llBack";
            llBack.Size = new Size(49, 17);
            llBack.TabIndex = 89;
            llBack.TabStop = true;
            llBack.Text = "< Back";
            // 
            // btnfRefresh
            // 
            btnfRefresh.Location = new Point(474, 411);
            btnfRefresh.Name = "btnfRefresh";
            btnfRefresh.Size = new Size(131, 29);
            btnfRefresh.TabIndex = 87;
            btnfRefresh.Text = "Refresh";
            btnfRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNotAccepted
            // 
            btnNotAccepted.Location = new Point(228, 351);
            btnNotAccepted.Name = "btnNotAccepted";
            btnNotAccepted.Size = new Size(144, 31);
            btnNotAccepted.TabIndex = 86;
            btnNotAccepted.Text = "Not Accepted";
            btnNotAccepted.UseVisualStyleBackColor = true;
            btnNotAccepted.Click += btnNotAccepted_Click;
            // 
            // lblFurnitureDesc
            // 
            lblFurnitureDesc.AutoSize = true;
            lblFurnitureDesc.Location = new Point(291, 314);
            lblFurnitureDesc.Name = "lblFurnitureDesc";
            lblFurnitureDesc.Size = new Size(81, 17);
            lblFurnitureDesc.TabIndex = 84;
            lblFurnitureDesc.Text = "Description :";
            // 
            // btnapprove
            // 
            btnapprove.Location = new Point(69, 351);
            btnapprove.Name = "btnapprove";
            btnapprove.Size = new Size(144, 31);
            btnapprove.TabIndex = 83;
            btnapprove.Text = "Approve Design";
            btnapprove.UseVisualStyleBackColor = true;
            btnapprove.Click += btnapprove_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(611, 411);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 29);
            btnCancel.TabIndex = 82;
            btnCancel.Text = "Cancel Furniture";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFurnitureDesc
            // 
            txtFurnitureDesc.Location = new Point(378, 311);
            txtFurnitureDesc.Multiline = true;
            txtFurnitureDesc.Name = "txtFurnitureDesc";
            txtFurnitureDesc.Size = new Size(353, 71);
            txtFurnitureDesc.TabIndex = 80;
            // 
            // txtFurniturePrice
            // 
            txtFurniturePrice.Location = new Point(173, 311);
            txtFurniturePrice.Name = "txtFurniturePrice";
            txtFurniturePrice.Size = new Size(112, 23);
            txtFurniturePrice.TabIndex = 79;
            // 
            // txtFurnitureType
            // 
            txtFurnitureType.Location = new Point(687, 273);
            txtFurnitureType.Name = "txtFurnitureType";
            txtFurnitureType.Size = new Size(44, 23);
            txtFurnitureType.TabIndex = 78;
            // 
            // txtFurnitureState
            // 
            txtFurnitureState.Location = new Point(498, 273);
            txtFurnitureState.Name = "txtFurnitureState";
            txtFurnitureState.Size = new Size(80, 23);
            txtFurnitureState.TabIndex = 77;
            // 
            // txtFurnitureName
            // 
            txtFurnitureName.Location = new Point(176, 273);
            txtFurnitureName.Name = "txtFurnitureName";
            txtFurnitureName.Size = new Size(211, 23);
            txtFurnitureName.TabIndex = 76;
            // 
            // lblFurnitureType
            // 
            lblFurnitureType.AutoSize = true;
            lblFurnitureType.Location = new Point(586, 276);
            lblFurnitureType.Name = "lblFurnitureType";
            lblFurnitureType.Size = new Size(102, 17);
            lblFurnitureType.TabIndex = 74;
            lblFurnitureType.Text = "Furniture Type : ";
            // 
            // lblFurniturePrice
            // 
            lblFurniturePrice.AutoSize = true;
            lblFurniturePrice.Location = new Point(69, 314);
            lblFurniturePrice.Name = "lblFurniturePrice";
            lblFurniturePrice.Size = new Size(98, 17);
            lblFurniturePrice.TabIndex = 73;
            lblFurniturePrice.Text = "Furniture Price :";
            // 
            // lblFurnitureState
            // 
            lblFurnitureState.AutoSize = true;
            lblFurnitureState.Location = new Point(393, 276);
            lblFurnitureState.Name = "lblFurnitureState";
            lblFurnitureState.Size = new Size(99, 17);
            lblFurnitureState.TabIndex = 72;
            lblFurnitureState.Text = "Furniture State :";
            // 
            // lblFurniturName
            // 
            lblFurniturName.AutoSize = true;
            lblFurniturName.Location = new Point(69, 276);
            lblFurniturName.Name = "lblFurniturName";
            lblFurniturName.Size = new Size(101, 17);
            lblFurniturName.TabIndex = 71;
            lblFurniturName.Text = "Furniture Name:";
            // 
            // dgvfInventoryControl
            // 
            dgvfInventoryControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfInventoryControl.Location = new Point(69, 79);
            dgvfInventoryControl.MultiSelect = false;
            dgvfInventoryControl.Name = "dgvfInventoryControl";
            dgvfInventoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfInventoryControl.Size = new Size(664, 169);
            dgvfInventoryControl.TabIndex = 70;
            // 
            // lblInventoryFurnitureTitle
            // 
            lblInventoryFurnitureTitle.AutoSize = true;
            lblInventoryFurnitureTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblInventoryFurnitureTitle.Location = new Point(291, 9);
            lblInventoryFurnitureTitle.Name = "lblInventoryFurnitureTitle";
            lblInventoryFurnitureTitle.Size = new Size(210, 31);
            lblInventoryFurnitureTitle.TabIndex = 68;
            lblInventoryFurnitureTitle.Text = "Tailor-made List";
            // 
            // lblback
            // 
            lblback.BorderStyle = BorderStyle.Fixed3D;
            lblback.Location = new Point(58, 262);
            lblback.Name = "lblback";
            lblback.Size = new Size(684, 136);
            lblback.TabIndex = 85;
            // 
            // DesignList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llBack);
            Controls.Add(btnfRefresh);
            Controls.Add(btnNotAccepted);
            Controls.Add(lblFurnitureDesc);
            Controls.Add(btnapprove);
            Controls.Add(btnCancel);
            Controls.Add(txtFurnitureDesc);
            Controls.Add(txtFurniturePrice);
            Controls.Add(txtFurnitureType);
            Controls.Add(txtFurnitureState);
            Controls.Add(txtFurnitureName);
            Controls.Add(lblFurnitureType);
            Controls.Add(lblFurniturePrice);
            Controls.Add(lblFurnitureState);
            Controls.Add(lblFurniturName);
            Controls.Add(dgvfInventoryControl);
            Controls.Add(lblInventoryFurnitureTitle);
            Controls.Add(lblback);
            Name = "DesignList";
            Text = "DesignList";
            ((System.ComponentModel.ISupportInitialize)dgvfInventoryControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llBack;
        private Button btnfClearTextBox;
        private Button btnfRefresh;
        private Button btnNotAccepted;
        private Label lblFurnitureDesc;
        private Button btnapprove;
        private Button btnCancel;
        private Button btnfSearch;
        private TextBox txtFurnitureDesc;
        private TextBox txtFurniturePrice;
        private TextBox txtFurnitureType;
        private TextBox txtFurnitureState;
        private TextBox txtFurnitureName;
        private TextBox txtfSearch;
        private Label lblFurnitureType;
        private Label lblFurniturePrice;
        private Label lblFurnitureState;
        private Label lblFurniturName;
        private DataGridView dgvfInventoryControl;
        private Label lblfSearch;
        private Label lblInventoryFurnitureTitle;
        private Label lblback;
    }
}