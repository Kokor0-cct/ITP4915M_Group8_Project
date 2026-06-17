namespace ITP4915M_Group8_Project.Customer.Customized
{
    partial class Tailor_made_Furniture
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
            btnBack = new Button();
            btnSubmit = new Button();
            cmbType = new ComboBox();
            txtDescription = new TextBox();
            lblType = new Label();
            lblSize = new Label();
            lblDescription = new Label();
            lblTitle = new Label();
            lblBack = new Label();
            lbldescSize = new Label();
            numHeigh = new NumericUpDown();
            numWidth = new NumericUpDown();
            numLength = new NumericUpDown();
            btnClear = new Button();
            lblBudget = new Label();
            numBudget = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numHeigh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBudget).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(41, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(660, 390);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(91, 38);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(152, 68);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 25);
            cmbType.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(152, 166);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(531, 143);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "Please enter your desired customized product information here.";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(103, 71);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 17);
            lblType.TabIndex = 4;
            lblType.Text = "Type :";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(103, 107);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(38, 17);
            lblSize.TabIndex = 5;
            lblSize.Text = "Size :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(65, 166);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 17);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 17);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "label4";
            // 
            // lblBack
            // 
            lblBack.BorderStyle = BorderStyle.Fixed3D;
            lblBack.Location = new Point(41, 47);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(710, 317);
            lblBack.TabIndex = 9;
            // 
            // lbldescSize
            // 
            lbldescSize.AutoSize = true;
            lbldescSize.Location = new Point(331, 107);
            lbldescSize.Name = "lbldescSize";
            lbldescSize.Size = new Size(162, 17);
            lbldescSize.TabIndex = 12;
            lbldescSize.Text = "(Length) x (width) x (heigh)";
            // 
            // numHeigh
            // 
            numHeigh.Location = new Point(271, 105);
            numHeigh.Name = "numHeigh";
            numHeigh.Size = new Size(54, 23);
            numHeigh.TabIndex = 13;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(211, 105);
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(54, 23);
            numWidth.TabIndex = 14;
            // 
            // numLength
            // 
            numLength.Location = new Point(152, 105);
            numLength.Name = "numLength";
            numLength.Size = new Size(53, 23);
            numLength.TabIndex = 15;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(639, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 24);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(84, 137);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(57, 17);
            lblBudget.TabIndex = 17;
            lblBudget.Text = "Budget :";
            // 
            // numBudget
            // 
            numBudget.Location = new Point(152, 137);
            numBudget.Name = "numBudget";
            numBudget.Size = new Size(113, 23);
            numBudget.TabIndex = 18;
            // 
            // Tailor_made_Furniture
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numBudget);
            Controls.Add(lblBudget);
            Controls.Add(btnClear);
            Controls.Add(numLength);
            Controls.Add(numWidth);
            Controls.Add(numHeigh);
            Controls.Add(lbldescSize);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblSize);
            Controls.Add(lblType);
            Controls.Add(txtDescription);
            Controls.Add(cmbType);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Controls.Add(lblBack);
            Name = "Tailor_made_Furniture";
            Text = "Tailor_made_Furniture";
            ((System.ComponentModel.ISupportInitialize)numHeigh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBudget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSubmit;
        private ComboBox cmbType;
        private TextBox txtDescription;
        private Label lblType;
        private Label lblSize;
        private Label lblDescription;
        private TextBox txtHeigh;
        private Label lblTitle;
        private Label lblBack;
        private TextBox txt;
        private TextBox txtWidth;
        private Label lbldescSize;
        private NumericUpDown numHeigh;
        private NumericUpDown numWidth;
        private NumericUpDown numLength;
        private Button btnClear;
        private Label lblBudget;
        private NumericUpDown numBudget;
    }
}