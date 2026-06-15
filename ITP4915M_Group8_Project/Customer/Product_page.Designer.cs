namespace ITP4915M_Group8_Project.Customer
{
    partial class Product_page
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
            flpMainProduct = new FlowLayoutPanel();
            btnCheckOut = new Button();
            SuspendLayout();
            // 
            // flpMainProduct
            // 
            flpMainProduct.AutoScroll = true;
            flpMainProduct.Location = new Point(97, 98);
            flpMainProduct.Name = "flpMainProduct";
            flpMainProduct.Size = new Size(846, 406);
            flpMainProduct.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(913, 512);
            btnCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(126, 42);
            btnCheckOut.TabIndex = 23;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // Product_page
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 581);
            Controls.Add(btnCheckOut);
            Controls.Add(flpMainProduct);
            Name = "Product_page";
            Text = "Product_page";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMainProduct;
        private Button btnCheckOut;
    }
}