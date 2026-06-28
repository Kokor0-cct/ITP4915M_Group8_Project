using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_Group8_Project.Customer.Customized
{
    public partial class cf_bill : Form
    {
        string Pname = "";
        decimal Uprice = 0;
        decimal Qty = 0;
        string cfID = "";
        public cf_bill(string cfId, decimal quantity, decimal price, string name)
        {
            InitializeComponent();
            LoadPage(cfId, quantity, price, name);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPage(string cfId, decimal quantity, decimal price, string name)
        {
            txtFirstName.Text = UserSession.CustomerName;
            txtPhonenum.Text = UserSession.CustomerPhone;
            txtAddress.Text = UserSession.CustomerAddress;

            MessageBox.Show($"cfId: {cfId}, Quantity: {quantity}, Price: {price}, Name: {name}");

            Pname = name;
            Uprice = price;
            Qty = quantity;
            cfID = cfId;

            txtPname.Text = Pname;
            txtUnitPrice.Text = Uprice.ToString();
            txtQty.Text = Qty.ToString();  
            lblTotalPrice.Text += " $"+(Uprice * Qty+50).ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            string sqlm = "SELECT * FROM material"; 

            if (txtFirstName.Text == "" || txtAddress.Text == "" || txtPhonenum.Text == "")
            {
                MessageBox.Show("Please fill in the name！");
                return;
            }
            if (dateChoose.Value < DateTime.Now.AddDays(3))
            {
                MessageBox.Show("Please select a valid delivery date！");
                return;
            }

            string address = txtAddress.Text;
            string cUserID = UserSession.CustomerId;
            string status = "ST02";
            string shipType = "";
            int shipPrice;
            string Createdate = DateTime.Now.ToString("yyyy-MM-dd");
            string deliverydate = dateChoose.Value.ToString("yyyy-MM-dd");



            if (rdbOrdinaryTransportat.Checked == true)
            {
                shipType = "SO01";
                shipPrice = 50;



            }
            else
            {
                shipType = "SO02";
                shipPrice = 150;

            }
            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(corderID,3) AS UNSIGNED)) FROM customorders;;";
            int maxOrderid = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
            string newOrderId = $"CO{maxOrderid:D6}";


            
            decimal itemSubTotal =(Qty* Uprice) + shipPrice;
            string insertSql = @"
                INSERT INTO customorders(corderID,cfID,Quantity,cUserID,coAmount,codeliverydate,coCreateDate,codeliveryaddress,shippingType,statusType)
                VALUES(@oid,@fid,@qty,@uid,@subtotal,@date,@createdate,@addr,@ship,@stat)";

            MySqlParameter[] para = {
                    new MySqlParameter("@oid",newOrderId),
                    new MySqlParameter("@fid",cfID),
                    new MySqlParameter("@qty",Qty),
                    new MySqlParameter("@uid",cUserID),
                    new MySqlParameter("@subtotal",itemSubTotal),
                    new MySqlParameter("@date",deliverydate),
                    new MySqlParameter("@createdate",Createdate),
                    new MySqlParameter("@addr",address),
                    new MySqlParameter("@ship",shipType),
                    new MySqlParameter("@stat",status)
                };
            DbConnect.Execute(insertSql, para);

            string updateSql = @"UPDATE customers SET cBudget= cBudget - @subtotal WHERE cUserID=@cid";
            MySqlParameter[] para2 = {
                    
                    new MySqlParameter("@subtotal",itemSubTotal),
                    new MySqlParameter("@cid",cUserID)
                };


            MessageBox.Show($"Order successfully! Order Number：{newOrderId}");

            this.Close();
        }
        private void rdbOrdinaryTransportat_CheckedChanged(object sender, EventArgs e)
        {
            int shipPrice = 0;

            if (rdbOrdinaryTransportat.Checked == true)
            {
                shipPrice = 50;



            }
            else if (rdbOrdinaryTransportat.Checked == false)
            {
                shipPrice = 150;

            }

            lblTotalPrice.Text = "Total Amount: $" + ((Uprice * Qty) + shipPrice).ToString("0.00");
        }

        private bool CheckMaterialStockEnough()
        {
            try
            {
                string sql = @"
                    SELECT m.materialCode, m.mQuantity, cm.pmqty 
                    FROM furniturematerials cm
                    JOIN material m ON cm.materialCode = m.materialCode
                    WHERE cm.cfID = @cfID";

                MySqlParameter[] para = { new MySqlParameter("@cfID", cfID) };
                DataTable dt = DbConnect.GetDataTable(sql, para); // 需确保DbConnect有查询DataTable的方法

                foreach (DataRow row in dt.Rows)
                {
                    decimal stock = Convert.ToDecimal(row["mStock"]); // 物料当前库存
                    decimal requiredPerUnit = Convert.ToDecimal(row["requiredQty"]); // 单套产品所需物料数量
                    decimal totalRequired = requiredPerUnit * Qty; // 订单总需求数量

                    // 校验库存是否充足
                    if (stock < totalRequired)
                    {
                        string materialId = row["materialID"].ToString();
                        MessageBox.Show($"Material {materialId} stock insufficient! Need: {totalRequired}, Current: {stock}");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check material stock failed: {ex.Message}");
                return false;
            }
        }
    }
}
