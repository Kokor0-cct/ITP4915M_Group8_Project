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
            SuspendLayout();
            // 
            // flpMainProduct
            // 
            flpMainProduct.AutoScroll = true;
            flpMainProduct.Location = new Point(52, 87);
            flpMainProduct.Name = "flpMainProduct";
            flpMainProduct.Size = new Size(956, 406);
            flpMainProduct.TabIndex = 0;
            // 
            // Product_page
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 588);
            Controls.Add(flpMainProduct);
            Name = "Product_page";
            Text = "Product_page";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMainProduct;
    }
}