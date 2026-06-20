using ITP4915M_Group8_Project.customer;
using ITP4915M_Group8_Project.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class ShoppingCart_Page : Form
    {

        string fid;

        public ShoppingCart_Page()
        {
            InitializeComponent();
            ShoppingCart_Page_Load();
        }



        private void ShoppingCart_Page_Load()
        {
            dgvShoppingCart.DataSource = null;
            dgvShoppingCart.DataSource = ShoppingCart.Items;
            lblTotalPrice.Text = "Total Amount: $" + ShoppingCart.GetTotalAmount().ToString("0.00");

        }

        private void dgvShoppingCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShoppingCart.CurrentRow == null || dgvShoppingCart.CurrentRow.Index < 0)
                return;
            DataGridViewRow row = dgvShoppingCart.CurrentRow;

            txtName.Text = Convert.ToString(row.Cells["fName"].Value);
            numQty.Value = Convert.ToDecimal(row.Cells["fQuantity"].Value);
            fid = Convert.ToString(row.Cells["fID"].Value);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.CurrentRow == null || dgvShoppingCart.CurrentRow.Index < 0 || string.IsNullOrEmpty(fid))
            {
                MessageBox.Show("Please select an item to update."); return;
            }
            int qty = Convert.ToInt32(numQty.Value);
            if (ShoppingCart.UpdateItem(fid, qty))
            {
                MessageBox.Show("Item updated successfully.");
                ShoppingCart_Page_Load();
            }
            else
            {
                MessageBox.Show("Failed to update item.");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut from = new CheckOut();
            from.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShoppingCart.DeleteItem(fid);
            ShoppingCart_Page_Load();
        }
    }
}
