namespace ITP4915M_Group8_Project.Staff.Logistic
{
    partial class CreateNewShippingRequest
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
            cmbAddress = new ComboBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbAddress
            // 
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(89, 88);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(220, 23);
            cmbAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(309, 15);
            label1.TabIndex = 1;
            label1.Text = "Please enter a collection address for the shipping request.";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(40, 140);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(274, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateNewShippingRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 206);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(cmbAddress);
            Name = "CreateNewShippingRequest";
            Text = "CreateNewShippingRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAddress;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
    }
}