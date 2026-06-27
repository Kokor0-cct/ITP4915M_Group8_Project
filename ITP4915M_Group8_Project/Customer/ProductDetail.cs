using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class ProductDetail : Form
    {
        int ProdStock = 0;
        string CurrentFId;
        public ProductDetail(string selectFid)
        {
            InitializeComponent();
            CurrentFId = selectFid;
            LoadDetail("SELECT * FROM furniture WHERE fID = '" + selectFid + "'");

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }
        private void LoadDetail(string sql)
        {
            try
            {
                DataTable dt = DbConnect.Query(sql);

                lblTitle.Text = dt.Rows[0]["fName"].ToString();
                lblProductDESC.Text = dt.Rows[0]["fDesc"].ToString();
                lblPrice.Text = "$ " + dt.Rows[0]["fprice"].ToString();
                lblStock.Text = "Stock : " + dt.Rows[0]["fQuantity"].ToString();
                ProdStock = Convert.ToInt32(dt.Rows[0]["fQuantity"]);


                string imgPath = dt.Rows[0]["fImgPath"].ToString();
                if (imgPath != null && imgPath.Length > 0)
                {
                    picProduct.Image = Image.FromFile(imgPath);
                }
                else
                {
                    picProduct.Image = Image.FromFile("../../../IMG/EmptyIMG.png");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Product loading failed：" + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (numNumOfProduct.Value <= 0)
            {
                MessageBox.Show("Please enter a valid purchase quantity.");
                return;
            }
            if (numNumOfProduct.Value > ProdStock)
            {
                MessageBox.Show("Insufficient stock, cannot add to cart！");
                return;
            }
            if (ShoppingCart.Items.Any(item => item.fID == CurrentFId))
            {
                MessageBox.Show("This product is already in the cart. Please adjust the quantity in the shopping cart.");
                return;
            }

            CartItem item = new CartItem()
            {
                fID = CurrentFId,
                fName = lblTitle.Text,
                UnitPrice = decimal.Parse(lblPrice.Text.Replace("$ ", "")),
                fQuantity = (int)numNumOfProduct.Value
            };

            ShoppingCart.AddItem(item.fID, item.fName, item.UnitPrice, item.fQuantity);
            MessageBox.Show("Successfully added to cart!");

            numNumOfProduct.Value = 0;
            this.Close();

        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();  
        }
    }
}
