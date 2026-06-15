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
        public int CurrentFId { get; set; }
        int ProdStock = 0;
        public ProductDetail(string selectFid)
        {
            InitializeComponent();

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
                MessageBox.Show("读取商品失败：" + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (numNumOfProduct.Value <= 0)
            {
                MessageBox.Show("请输入有效的购买数量！");
                return;
            }
            if (numNumOfProduct.Value > ProdStock)
            {
                MessageBox.Show("库存不足，无法加入购物车！");
                return;
            }

            CartItem item = new CartItem()
            {
                fID = CurrentFId,
                fName = lblTitle.Text,
                UnitPrice = decimal.Parse(lblPrice.Text.Replace("$ ", "")),
                fQuantity = (int)numNumOfProduct.Value
            };

            ShoppingCart.AddItem(item.fID, item.fName, item.TotalPrice, item.fQuantity);
            MessageBox.Show("成功加入购物车！");

            numNumOfProduct.Value = 0;

        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();  
        }
    }
}
