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
            cbofType.Items.Clear();
            cbofType.Items.Add("All");
            cbofType.Items.Add("Table");
            cbofType.Items.Add("Chair");
            cbofType.Items.Add("Sofa");
            cbofType.Items.Add("Wardrobe");
            cbofType.Items.Add("Shelf");
            cbofType.Items.Add("Bed");
            cbofType.SelectedIndex = 0;
            LoadAllProduct("SELECT fID,fName,fprice,fQuantity,fType,fImgPath FROM furniture");
        }


        private void LoadAllProduct(string sql)
        {
            flpMainProduct.Controls.Clear();
            try
            {
                DataTable dt = DbConnect.Query(sql);

                foreach (DataRow row in dt.Rows)
                {
                    ProductCard card = new ProductCard();

                    card.FId = row["fID"].ToString();
                    card.PName = row["fName"].ToString();
                    card.PPrice = Convert.ToDecimal(row["fPrice"]);
                    card.PStock = Convert.ToInt32(row["fQuantity"]);
                    card.PType = row["fType"].ToString();



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
                MessageBox.Show("Product loading failed：" + ex.Message);
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fType,fprice,fQuantity,fImgPath FROM furniture ORDER BY fName ASC";
            LoadAllProduct(sql);
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut bill = new CheckOut();
            bill.ShowDialog();
        }

        private void btnSortStock_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fType,fprice,fQuantity,fImgPath FROM furniture ORDER BY fQuantity ASC";
            LoadAllProduct(sql);
        }

        private void btnSortPrice_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT fId,fName,fType,fprice,fQuantity,fImgPath FROM furniture ORDER BY fprice ASC";
            LoadAllProduct(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbofType.SelectedItem == null) return;

            string selected = cbofType.SelectedItem.ToString();
            string sql = "SELECT fId,fName,fType,fprice,fQuantity,fImgPath FROM furniture";

            if (selected == "Table")
            {
                sql += " WHERE fType = 'FT01'";
            }
            else if (selected == "Chair")
            {
                sql += " WHERE fType = 'FT02'";
            }
            else if (selected == "Sofa")
            {
                sql += " WHERE fType = 'FT03'";
            }
            else if (selected == "Wardrobe")
            {
                sql += " WHERE fType = 'FT04'";
            }
            else if (selected == "Shelf")
            {
                sql += " WHERE fType = 'FT05'";
            }
            else if (selected == "Bed")
            {
                sql += " WHERE fType = 'FT06'";
            }

            LoadAllProduct(sql);
        }
    }

}