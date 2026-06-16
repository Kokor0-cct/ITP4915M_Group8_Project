using ITP4915M_Group8_Project.Customer;
using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
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

            lblTotalPrice.Text = ShoppingCart.GetTotalAmount().ToString("0.00");

            txtFirstName.Text = UserSession.CustomerName;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }




        private void button1_Click(object sender, EventArgs e)
        {   
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == ""|| txtPhonenum.Text == "")
            {
                MessageBox.Show("Please fill in the name！");
                return;
            }
   

            string address = txtAddress.Text;
            string cUserID = UserSession.CustomerId;
            int status = 1;
            int shipType = 0;
            int shipPrice ;
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd");



            if (rdbOrdinaryTransportat.Checked == true)
            {
                shipType = 1;
                shipPrice = 50;


            }
            else
            {
                shipType = 2;
                shipPrice = 150;

            }
            string sqlMaxId = "SELECT COALESCE(MAX(orderID), 0) FROM orders";
                int newOrderId = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) ;
                newOrderId++;


            foreach (CartItem item in ShoppingCart.Items)
                {
                    decimal itemSubTotal = item.GetTotalPrice() + shipPrice;
                    string insertSql = @"
                    INSERT INTO orders(orderID,fID,Quantity,cUserID,oTotalAmount,odeliverydate,odeliveryaddress,shippingType,statusType)
                    VALUES(@oid,@fid,@qty,@uid,@subtotal,@date,@addr,@ship,@stat)";

                    MySqlParameter[] para = {
                        new MySqlParameter("@oid",newOrderId),
                        new MySqlParameter("@fid",item.fID),
                        new MySqlParameter("@qty",item.fQuantity),
                        new MySqlParameter("@uid",cUserID),
                        new MySqlParameter("@subtotal",itemSubTotal),
                        new MySqlParameter("@date",dateStr),
                        new MySqlParameter("@addr",address),
                        new MySqlParameter("@ship",shipType),
                        new MySqlParameter("@stat",status)
                    };
                    DbConnect.Execute(insertSql, para);
                }

                ShoppingCart.Clear();
                MessageBox.Show($"Order successfully! Order Number：{newOrderId}");

                this.Close();
        }
        

        private void txtLastName_TextChanged(object sender, EventArgs e) { }
        private void lalProductName_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lalOrderName_Click(object sender, EventArgs e) { }
        private void lalAmount_Click(object sender, EventArgs e)
        {
        }
        private void totalPrice(object sender, EventArgs e) { }

        private void TotalPriceLib_Click(object sender, EventArgs e)
        {

        }

        private void TotalPriceLib2_Click(object sender, EventArgs e)
        {
            UpdateUnitPriceFromTag();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}