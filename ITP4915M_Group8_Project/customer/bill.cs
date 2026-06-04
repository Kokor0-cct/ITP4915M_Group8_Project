using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.customer
{
    public partial class bill : Form
    {
        private int currentQuantity;
        private string currentProductName;
        private decimal unitPrice;

        public bill()
        {
            InitializeComponent();
            this.Load += Bill_Load;
        }

        // 由 Tag 或 orderData 更新 unitPrice 欄位
        private void UpdateUnitPriceFromTag()
        {
            if (this.Tag is Dictionary<string, object> orderData)
            {
                if (orderData.TryGetValue("UnitPrice", out var up) && decimal.TryParse(up?.ToString(), out var decPrice))
                {
                    unitPrice = decPrice;
                }
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            if (this.Tag is Dictionary<string, object> orderData)
            {
                currentProductName = orderData["ProductName"]?.ToString() ?? "";
                currentQuantity = Convert.ToInt32(orderData["Quantity"]);
                unitPrice = Convert.ToDecimal(orderData["UnitPrice"]);

                // 顯示產品名稱
                if (lalProductName != null)
                    lalProductName.Text = currentProductName;

                // 顯示數量（假設 label6 是用來顯示數量的）
                if (label6 != null)
                    label6.Text = $"Quantity: {currentQuantity}";

                // 計算並顯示總價
                UpdateTotalPrice();
            }
        }

        // 點擊數量標籤時修改數量
        private void label6_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "請輸入新數量", "修改數量", currentQuantity.ToString());
            if (int.TryParse(input, out int newQty) && newQty > 0)
            {
                currentQuantity = newQty;
                label6.Text = $"Quantity: {currentQuantity}";
                UpdateTotalPrice();
            }
            else if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("請輸入有效的正整數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 更新總價顯示
        private void UpdateTotalPrice()
        {
            decimal total = unitPrice * currentQuantity;

            // 更新 lalAmount (總金額的 Label)
            if (lalAmount != null)
                lalAmount.Text = $"${total:N2}";
            else
                MessageBox.Show("找不到 lalAmount 控制項", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 確認訂單按鈕（這裡沒有庫存更新，單純完成訂單）
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"訂單確認\n產品：{currentProductName}\n數量：{currentQuantity}\n總價：${unitPrice * currentQuantity:N2}",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("購買成功！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // 其他原有的空事件保留即可
        private void txtLastName_TextChanged(object sender, EventArgs e) { }
        private void lalProductName_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lalOrderName_Click(object sender, EventArgs e) { }
        private void lalAmount_Click(object sender, EventArgs e)
        {
            // 現在這個是總金額的 Label
        }
        private void totalPrice(object sender, EventArgs e) { }

        private void TotalPriceLib_Click(object sender, EventArgs e)
        {

        }

        private void TotalPriceLib2_Click(object sender, EventArgs e)
        {
            UpdateUnitPriceFromTag();
        }
    }
}