using System;
using System.Windows.Forms;
using System.Data;
using ITP4915M_Group8_Project.Staff.Inventory;

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
            //var orderSofa = new OrderSofa();
            //orderSofa.Show();
            // this.Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem as string;
            int quantity = (int)numUDProductQuantity.Value;

            var billForm = new bill();

            // 建立包含產品名稱和數量的資料物件
            // 取得選取項目的價格（若使用 DataSource 並設定 ValueMember 為 fPrice，SelectedValue 會取得價格）
            decimal selectedPrice = 0m;
            if (comboBox1.SelectedValue != null)
            {
                decimal.TryParse(comboBox1.SelectedValue.ToString(), out selectedPrice);
            }

            var orderData = new Dictionary<string, object>
    {
        { "ProductName", selected ?? "未選擇" },
        { "Quantity", quantity },
        { "UnitPrice", selectedPrice }
    };

            // 透過 Tag 傳遞完整資料
            billForm.Tag = orderData;

            // 直接更新 product name label
            var matches = billForm.Controls.Find("lalProductName", true);
            if (matches.Length > 0 && matches[0] is Label lbl)
            {
                lbl.Text = selected ?? "未選擇";
            }

            
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
            int quantity = (int)numUDProductQuantity.Value;

            // 方式1：更新畫面上某個顯示數量的 Label
            var matches = this.Controls.Find("lblQuantityDisplay", true);
            if (matches.Length > 0 && matches[0] is Label lbl)
            {
                lbl.Text = $"數量: {quantity}";
            }
            else
            {
                // 不彈訊息方塊，因為數量變動頻繁，會一直干擾使用者
                // 只寫在標題或狀態列較好
                this.Text = $"購買 - 數量: {quantity}";
            }
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        // 從資料庫載入家具 (fName, fPrice) 並綁定到 comboBox1
        private void LoadFurniture()
        {
            try
            {
                string sql = "SELECT fName, fPrice FROM furniture";
                DataTable dt = ITP4915M_Group8_Project.Staff.Inventory.DbConnect.Query(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBox1.DisplayMember = "fName";
                    comboBox1.ValueMember = "fPrice"; // price stored in SelectedValue
                    comboBox1.DataSource = dt;
                }
                else
                {
                    // 若沒有資料，清空並顯示預設項目
                    comboBox1.DataSource = null;
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(new object[] { "Sofa", "Chair" });
                    if (comboBox1.Items.Count > 0)
                        comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入家具資料失敗: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem as string;
            if (string.IsNullOrEmpty(selected))
                return;

            // 若表單中有名為 labelSelection 的 Label，更新它；否則顯示訊息方塊
            var matches = this.Controls.Find("labelSelection", true);
            if (matches.Length > 0 && matches[0] is Label lbl)
            {
                lbl.Text = $"已選: {selected}";
            }
            else
            {
                MessageBox.Show($"已選: {selected}", "選擇", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 
        }
    }
}
