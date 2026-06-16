using ITP4915M_Group8_Project.customer;
using ITP4915M_Group8_Project.Staff.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class Product_page : Form
    {
        public Product_page()
        {
            InitializeComponent();
            LoadAllProduct("SELECT fID,fName,fprice,fQuantity,fType,fImgPath FROM furniture");
        }


        private void LoadAllProduct(string sql)
        {
            flpMainProduct.Controls.Clear();
            try
            {
                DataTable dt = DbConnect.Query(sql);

                // 循环每一行商品（数据库增删自动改变循环次数）
                foreach (DataRow row in dt.Rows)
                {
                    // 实例化单张商品卡片
                    ProductCard card = new ProductCard();

                    // 赋值数据库字段
                    card.FId = row["fID"].ToString();
                    card.PName = row["fName"].ToString();
                    card.PPrice = Convert.ToDecimal(row["fPrice"]);
                    card.PStock = Convert.ToInt32(row["fQuantity"]);
                    card.PType = row["fType"].ToString();

                    //

                    // 图片逻辑：如果存路径，读取本地图片
                    string imgPath = row["fImgPath"].ToString();
                    if (imgPath != null && imgPath.Length > 0)
                    {
                        card.PImage = Image.FromFile(imgPath);
                    }
                    else
                    {
                        card.PImage = Image.FromFile("../../../IMG/EmptyIMG.png");
                    }

                    card.CardBtnClick += (s, e) =>
                    {
                        string selectFid = card.FId;
                        ProductDetail detailWin = new ProductDetail(selectFid);
                        detailWin.ShowDialog();
                    };

                    flpMainProduct.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取商品失败：" + ex.Message);
            }
        }

        // 按名称升序
        private void btnSortName_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fPrice,fStock FROM furniture ORDER BY fName ASC";
            LoadAllProduct(sql);
        }

        // 按库存升序
        private void btnSortStock_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fPrice,fStock FROM furniture ORDER BY fStock ASC";
            LoadAllProduct(sql);
        }

        // 按价格升序
        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fPrice,fStock FROM furniture ORDER BY fPrice ASC";
            LoadAllProduct(sql);
        }
        private void frmBrowseProduct_Load(object sender, EventArgs e)
        {
            // 窗体打开默认按名称排序
            btnSortName_Click(null, null);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut bill = new CheckOut();
            bill.ShowDialog();
        }
    }

}