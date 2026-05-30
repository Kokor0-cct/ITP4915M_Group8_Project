namespace ITP4915M_Group8_Project.Staff.Inventory
{
    partial class InventoryControl
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
            labInvCon = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labInvCon
            // 
            labInvCon.AutoSize = true;
            labInvCon.Font = new Font("Microsoft YaHei UI", 35F, FontStyle.Bold);
            labInvCon.Location = new Point(356, -1);
            labInvCon.Name = "labInvCon";
            labInvCon.Size = new Size(445, 62);
            labInvCon.TabIndex = 0;
            labInvCon.Text = "Inventory Control";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1147, 247);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 461);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1147, 247);
            dataGridView2.TabIndex = 2;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 802);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(labInvCon);
            Name = "InventoryControl";
            Text = "InventoryMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labInvCon;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}