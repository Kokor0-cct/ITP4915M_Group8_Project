using ITP4915M_Group8_Project.Customer;

using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_Group8_Project.customer
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();

            // 從資料庫載入家具清單（fName, fPrice）到 ComboBox
            LoadFurniture();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void btnAddToShopingCar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || numUDProductQuantity.Value == 0)
            {
                MessageBox.Show("Please select an item and enter the quantity!");
                return;
            }

            // 2. 获取选中的商品信息（从 ComboBox 自动拿）
            DataRowView row = (DataRowView)comboBox1.SelectedItem;

            int productId = Convert.ToInt32(row["fId"]);        // 商品ID
            string productName = row["fName"].ToString();      // 商品名
            decimal price = Convert.ToDecimal(row["fPrice"]);  // 单价
            int qty = (int)numUDProductQuantity.Value;                // 数量

            // 3. 加入购物车（用我之前给你的全局购物车）
            ShoppingCart.AddItem(productId, productName, price, qty);

            // 4. 提示成功
            MessageBox.Show($"Already joined：{productName} × {qty}");

            // 5. 清空选择（可选）
            comboBox1.SelectedIndex = -1;
            numUDProductQuantity.Value = 0;

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
           
            var billForm = new bill();

            

            billForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // var orderSofa = new OrderSofa();
            //orderSofa.Show();
            //this.Close();
        }

        private void btnPoductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox combo && combo.SelectedIndex >= 0 && combo.SelectedItem != null)
            {
                var selected = combo.SelectedItem.ToString();
                if (string.Equals(selected, "Chair", StringComparison.OrdinalIgnoreCase))
                {
                    // var oderChair = new OderChair();
                    // oderChair.Show();
                    // this.Close();
                }
                else if (string.Equals(selected, "Sofa", StringComparison.OrdinalIgnoreCase))
                {
                    //var orderSofa = new OrderSofa();
                    // orderSofa.Show();
                    //this.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void numUDProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        // 從資料庫載入家具 (fName, fPrice) 並綁定到 comboBox1
        private void LoadFurniture()
        {
            try
            {
                string sql = "SELECT fId, fName, fPrice FROM furniture";
                DataTable dt = DbConnect.Query(sql);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("There are no products in the database!");
                    return;
                }

                comboBox1.DataSource = null;          
                comboBox1.DataSource = dt;            
                comboBox1.DisplayMember = "fName";     
                comboBox1.ValueMember = "fId";        

       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read failed：" + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 
        }

        
    }
}
