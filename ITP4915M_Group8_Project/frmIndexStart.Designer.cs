namespace ITP4915M_Group8_Project
{
    partial class frmIndexStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(1, -1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(261, 197);
            btnStart.TabIndex = 0;
            btnStart.Text = "Click to start the system";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // frmIndexStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 196);
            Controls.Add(btnStart);
            Name = "frmIndexStart";
            Text = "Manual Start";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
    }
}
