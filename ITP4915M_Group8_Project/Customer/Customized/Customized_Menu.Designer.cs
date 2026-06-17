namespace ITP4915M_Group8_Project.Customer.Customized
{
    partial class Customized_Menu
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
            lblCustomized = new Label();
            lblBack = new Label();
            btnCustomized = new Button();
            btnDesignList = new Button();
            SuspendLayout();
            // 
            // lblCustomized
            // 
            lblCustomized.AutoSize = true;
            lblCustomized.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCustomized.Location = new Point(12, 9);
            lblCustomized.Name = "lblCustomized";
            lblCustomized.Size = new Size(130, 27);
            lblCustomized.TabIndex = 0;
            lblCustomized.Text = "Customized";
            // 
            // lblBack
            // 
            lblBack.BorderStyle = BorderStyle.Fixed3D;
            lblBack.Location = new Point(12, 47);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(202, 269);
            lblBack.TabIndex = 1;
            // 
            // btnCustomized
            // 
            btnCustomized.Location = new Point(52, 82);
            btnCustomized.Name = "btnCustomized";
            btnCustomized.Size = new Size(132, 71);
            btnCustomized.TabIndex = 2;
            btnCustomized.Text = "Tailor-made Furniture";
            btnCustomized.UseVisualStyleBackColor = true;
            btnCustomized.Click += btnCustomized_Click;
            // 
            // btnDesignList
            // 
            btnDesignList.Location = new Point(52, 209);
            btnDesignList.Name = "btnDesignList";
            btnDesignList.Size = new Size(132, 71);
            btnDesignList.TabIndex = 3;
            btnDesignList.Text = "Tailor-made List";
            btnDesignList.UseVisualStyleBackColor = true;
            btnDesignList.Click += btnDesignList_Click;
            // 
            // Customized_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 355);
            Controls.Add(btnDesignList);
            Controls.Add(btnCustomized);
            Controls.Add(lblBack);
            Controls.Add(lblCustomized);
            Name = "Customized_Menu";
            Text = "Customized_Menu1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomized;
        private Label lblBack;
        private Button btnCustomized;
        private Button btnDesignList;
    }
}