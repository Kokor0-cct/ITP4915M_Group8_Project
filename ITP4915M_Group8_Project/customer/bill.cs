using ITP4915M_Group8_Project.Customer;
using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace ITP4915M_Group8_Project.customer
{
    public partial class CheckOut : Form
    {
        private int currentQuantity;
        private string currentProductName;
        private decimal unitPrice;

        public CheckOut()
        {
            InitializeComponent();
            this.Load += Bill_Load;
        }

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
            dgvCartList.DataSource = null;
            dgvCartList.DataSource = ShoppingCart.Items;
            txtPhonenum.Text = UserSession.CustomerPhone;
            txtAddress.Text = UserSession.CustomerAddress;

            lblTotalPrice.Text = "Total Amount : $" + ShoppingCart.GetTotalAmount().ToString("0.00");

            txtFirstName.Text = UserSession.CustomerName;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            String sql = @"SELECT cBudget FROM customers WHERE cUserID = @cid";
            MySqlParameter parameter = new MySqlParameter("@cid", UserSession.CustomerId); // Extract the customer ID from the session
            DataTable dt = DbConnect.Query(sql, parameter);
            int Budget = Convert.ToInt32(dt.Rows[0]["cBudget"]);

            string shipType = "";
            int shipPrice = 0;

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

            if (txtFirstName.Text == ""|| txtAddress.Text == "" || txtPhonenum.Text == "")
            {
                MessageBox.Show("Please fill in the name！");
                return;
            }
            else if (dateChoose.Value < DateTime.Now.AddDays(2))
            {
                MessageBox.Show("The shipping date must be two days later.");
                return;
            }
            else if (ShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Your shopping cart is empty.");
                return;
            }else if (Budget < ShoppingCart.GetTotalAmount()+ shipPrice)
            {
                MessageBox.Show("Your budget is not enough.");
                return;
            }

                string address = txtAddress.Text;
            string cUserID = UserSession.CustomerId;
            string status = "ST01";
            string deliverydate = dateChoose.Value.ToString("yyyy-MM-dd");


 
            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(orderID,2)AS UNSIGNED)) FROM orders;";
            int maxOrderid = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) +1;
            string newOrderId = $"O{maxOrderid:D7}";

            sql = "UPDATE customers SET cBudget = cBudget - @oAmount WHERE cUserID  = @cid;";
            MySqlParameter[] customer = {
                        new MySqlParameter("@oAmount", ShoppingCart.GetTotalAmount()+shipPrice),
                        new MySqlParameter("@cid", UserSession.CustomerId)
                    };
            DbConnect.Execute(sql, customer);


            foreach (CartItem item in ShoppingCart.Items)
            {
                decimal itemSubTotal = item.GetTotalPrice() + shipPrice;
                string insertSql = @"
                    INSERT INTO orders(orderID,fID,Quantity,cUserID,oAmount,odeliverydate,odeliveryaddress,shippingType ,statusType )
                    VALUES(@oid,@fid,@qty,@uid,@subtotal,@date,@addr,@ship,@stat)";


                MySqlParameter[] para = {
                        new MySqlParameter("@oid",newOrderId),
                        new MySqlParameter("@fid",item.fID),
                        new MySqlParameter("@qty",item.fQuantity),
                        new MySqlParameter("@uid",cUserID),
                        new MySqlParameter("@subtotal",itemSubTotal),
                        new MySqlParameter("@date",deliverydate),
                        new MySqlParameter("@addr",address),
                        new MySqlParameter("@ship",shipType),
                        new MySqlParameter("@stat",status)
                    };
                DbConnect.Execute(insertSql, para);


                string sqlStock = "SELECT fQuantity FROM furniture WHERE fID = @fid;";
                MySqlParameter[] Stock = {
                        new MySqlParameter("@fid",item.fID),
                    };
              
                int newStock = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlStock, Stock)) - item.fQuantity;
                string updateStockSql = "UPDATE furniture SET fQuantity = @newStock WHERE fID = @fid;";
                MySqlParameter[] UpdateStock = {
                        new MySqlParameter("@newStock", newStock),
                        new MySqlParameter("@fid",item.fID)
                    };
                
                DbConnect.Execute(updateStockSql, UpdateStock);
            }

            ShoppingCart.Clear();

            MessageBox.Show($"Order successfully! Order Number：{newOrderId}");

            this.Close();
        }


        private void TotalPriceLib2_Click(object sender, EventArgs e)
        {
            UpdateUnitPriceFromTag();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void rdbOrdinaryTransportat_CheckedChanged(object sender, EventArgs e)
        {
            int shipPrice= 0;

            if (rdbOrdinaryTransportat.Checked == true)
            {
                shipPrice = 50;



            }
            else if (rdbOrdinaryTransportat.Checked == false)
            {
                shipPrice = 150;

            }

            lblTotalPrice.Text ="Total Amount: $" + (ShoppingCart.GetTotalAmount()+shipPrice).ToString("0.00");
        }
    }
}