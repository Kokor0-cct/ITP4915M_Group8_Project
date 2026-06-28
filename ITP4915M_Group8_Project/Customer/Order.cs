using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using ScottPlot.Colormaps;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class Order : Form
    {
        private string currentOid = "0";
        private string currentStatus = "0";
        private string currentFid = "0";

        public Order()
        {
            InitializeComponent();


            rbAll.Checked = true;

            rbOrders.Checked = true;
            Refresh();
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {
            string customerId = UserSession.CustomerId;

            string sql = @"SELECT * FROM orders WHERE cUserID = @customerId ORDER BY orderID"; // It only gets records with the status "In Transit"

            MySqlParameter parameters = new MySqlParameter("@customerId", customerId);
            DataTable dt = DbConnect.Query(sql, parameters);


            dgvOrderControl.DataSource = dt;
        }

        // ---------UI Interaction---------
        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();
            string sql = (checkOrder() == "order") ? "SELECT * FROM orders WHERE cUserID = @customerId AND orderID LIKE @keyword ORDER BY orderID" : "SELECT * FROM customorders WHERE cUserID = @customerId AND corderID LIKE @keyword ORDER BY corderID";
            DataTable dt;

            if (checkStatus() != null) // A status is selected
            {
                sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId AND orderID LIKE @keyword AND statustype = @STATUS ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId AND corderID LIKE @keyword AND statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@customerId", UserSession.CustomerId),
                    new MySqlParameter("@keyword", "%" + keyword + "%"),
                    new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else
            { // A status is not selected / "all"
                MySqlParameter[] parameters = {
                    new MySqlParameter("@customerId", UserSession.CustomerId),
                    new MySqlParameter("@keyword", "%" + keyword + "%") };
                dt = DbConnect.Query(sql, parameters);
            }

            dgvOrderControl.DataSource = dt;
        }


        private void rbPending_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(1);
        }

        private void rbProduction_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(2);
        }

        private void rbTransit_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(3);
        }

        private void rbDelivered_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(4);
        }

        private void rbFailed_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(5);
        }

        private void rbCancel_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(6);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(0);
        }

        private void dgvOrderControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderControl.CurrentRow.Selected = true;
            if (e.RowIndex < 0) //If the selected row are the field names, skip all codes below
                return;

            string sql = "";
            MySqlParameter parameters = null;
            DataTable dt = null;
            String furnitureName = "";

            if (checkOrder() == "order")
            {
                //Get fName from furniture
                sql = @"SELECT fName FROM furniture WHERE fID = @FID";
                parameters = new MySqlParameter("@FID", dgvOrderControl.Rows[e.RowIndex].Cells["fId"].Value.ToString());
                dt = DbConnect.Query(sql, parameters);
                furnitureName = dt.Rows[0]["fname"].ToString();      //<-- Extract Furniture name from table
            }
            else
            {
                sql = @"SELECT cfName FROM customfurniture WHERE cfID = @CFID";
                parameters = new MySqlParameter("@CFID", dgvOrderControl.Rows[e.RowIndex].Cells["cfId"].Value.ToString());
                dt = DbConnect.Query(sql, parameters);
                furnitureName = dt.Rows[0]["cfname"].ToString();
            }

            //Get soName from shippingoption
            sql = @"SELECT soName FROM shippingoption WHERE soID = @SOID";
            parameters = new MySqlParameter("@SOID", dgvOrderControl.Rows[e.RowIndex].Cells["shippingType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String shippingName = dt.Rows[0]["soName"].ToString();      //<--Extract Shipping Type Name from table


            //Get statusDesc from status
            sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            parameters = new MySqlParameter("@STATUSCODE", dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table





            currentOid = (checkOrder() == "order") ? dgvOrderControl.Rows[e.RowIndex].Cells["orderID"].Value.ToString() : dgvOrderControl.Rows[e.RowIndex].Cells["corderID"].Value.ToString();
            currentStatus = dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString(); //Stores the selected statusType

            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content 
            txtQuantity.Text = dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();             //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content



            if (checkOrder() == "order")
            {
                currentFid = dgvOrderControl.Rows[e.RowIndex].Cells["fID"].Value.ToString(); //Stores the selected furnitureID

                txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oAmount"].Value.ToString();           //Amount cell content
                txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
                txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            }
            else
            {
                currentFid = dgvOrderControl.Rows[e.RowIndex].Cells["cfID"].Value.ToString(); //Stores the selected furnitureID

                txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["coAmount"].Value.ToString();           //Amount cell content
                txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
                txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliveryaddress"].Value.ToString();      //Delivery Address cell content
            }


            txtShipping.Text = shippingName;         //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
            txtStaffNote.Text = dgvOrderControl.Rows[e.RowIndex].Cells["StaffNote"].Value.ToString(); ;
        }

        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId AND orderID = @OID ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId AND corderID = @OID ORDER BY corderID";
            DataTable dt;
            if (checkStatus() != null)  // A status is selected
            {
                sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE orderID = @OID AND statustype = @STATUS ORDER BY orderID" : @"SELECT * FROM customorders WHERE corderID = @OID AND statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = { new MySqlParameter("@OID", currentOid), new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else    // A status is not selected / "all"
            {
                MySqlParameter[] parameters = { new MySqlParameter("@customerId", UserSession.CustomerId), new MySqlParameter("@OID", currentOid) };
                dt = DbConnect.Query(sql, parameters);
            }


            dgvOrderControl.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        // ---------Methods---------
        private void updateStatus(int status) // Used by Radio Buttons
        {
            DataTable dt;
            string sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId AND statusType = @STATUS ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId AND statusType = @STATUS ORDER BY corderID";

            string sqlstat = "";
            ClearTextBox();

            switch (status)
            {
                case 1:
                    sqlstat = "ST01";
                    break;
                case 2:
                    sqlstat = "ST03";
                    break;
                case 3:
                    sqlstat = "ST06";
                    break;
                case 4:
                    sqlstat = "ST07";
                    break;
                case 5:
                    sqlstat = "ST08";
                    break;
                case 6:
                    sqlstat = "ST010";
                    break;
                case 7:
                    sqlstat = "ST09";
                    break;
                case 8:
                    sqlstat = "ST11";
                    break;
                case 9:
                    sqlstat = "ST12";
                    break;
                case 10:
                    sqlstat = "ST13";
                    break;

                case 11:
                    sqlstat = "ST04";
                    break;
                case 12:
                    sqlstat = "ST05";
                    break;
                default:
                    sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId ORDER BY corderID";
                    MySqlParameter parameter = new MySqlParameter("@customerId", UserSession.CustomerId);
                    dt = DbConnect.Query(sql, parameter);
                    dgvOrderControl.DataSource = dt;
                    return;
            }
            MySqlParameter[] parameters = { new MySqlParameter("@customerId", UserSession.CustomerId), new MySqlParameter("@STATUS", sqlstat) };
            dt = DbConnect.Query(sql, parameters);
            dgvOrderControl.DataSource = dt;
        }
        private void ClearTextBox()
        {
            txtOrderID.Clear();
            txtFurniture.Clear();
            txtQuantity.Clear();
            txtUserID.Clear();
            txtAmount.Clear();
            txtDeliveryDate.Clear();
            txtAddress.Clear();
            txtShipping.Clear();
            txtStatus.Clear();
        }

        private String checkStatus()    // Used for generals
        {
            if (rbPending.Checked == true)
                return "ST01";
            else if (rbProduction.Checked == true)
                return "ST02";
            else if (rbTransit.Checked == true)
                return "ST03";
            else if (rbDelivered.Checked == true)
                return "ST04";
            else if (rbFailed.Checked == true)
                return "ST05";
            else if (rbCancel.Checked == true)
                return "ST06";
            else
                return null;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {

            if (currentOid == "0")
            {
                MessageBox.Show("Please select a row ！");
                return;
            }
            else if (currentStatus == "ST11")
            {
                MessageBox.Show("Your service application is in progress.");
                return;
            }
            else if (currentStatus == "ST12" || currentStatus == "ST13")
            {
                MessageBox.Show("Your service application has been completed.");
                return;
            }
            else if (currentStatus == "ST10")
            {
                MessageBox.Show("Your order has been cancelled.");
                return;
            }
            else if (currentStatus == "ST08")
            {
                MessageBox.Show("The order has expired.");
                return;
            }
            else if (currentStatus != "ST09")
            {
                MessageBox.Show("If you wish to cancel your order, please click \"Cancel Order\".");
                return;
            }
            else
            {
                CustomerService.After_sales_Request form = new CustomerService.After_sales_Request(currentOid, currentFid, checkOrder()== "order");
                form.ShowDialog();
            }

        }

        private void radCompleted_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(7);

        }

        private void radUnderreview_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(8);

        }

        private void radRefund_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(9);

        }

        private void radReplace_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(10);

        }

        private void rbOrders_CheckedChanged(object sender, EventArgs e)
        {
            updateTableView("Orders");

        }

        private void rbCustomOrders_CheckedChanged(object sender, EventArgs e)
        {
            updateTableView("Custom");
        }

        private void updateTableView(string orderType) // Used by Radio Buttons
        {
            DataTable dt;
            String sql = "";
            ClearTextBox();

            switch (orderType)
            {
                case "Orders":
                    sql = "SELECT * FROM orders";
                    break;
                case "Custom":
                    sql = "SELECT * FROM customOrders";
                    break;
            }
            dt = DbConnect.Query(sql);
            dgvOrderControl.DataSource = dt;
        }

        public String checkOrder()    // Used for generals
        {
            if (rbOrders.Checked == true)
                return "order";
            else if (rbCustomOrders.Checked == true)
                return "custom";
            else
                return null;
        }

        public void Refresh()
        {
            string sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId ORDER BY corderID";
            DataTable dt;
            if (checkStatus() != null) // A status is selected
            {
                sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE cUserID = @customerId AND statustype = @STATUS ORDER BY orderID" : @"SELECT * FROM customorders WHERE cUserID = @customerId AND statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = { new MySqlParameter("@customerId", UserSession.CustomerId), new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else    // A status is not selected / "all"
            {
                MySqlParameter parameter = new MySqlParameter("@customerId", UserSession.CustomerId);
                dt = DbConnect.Query(sql, parameter);
            }

            dgvOrderControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentOid == "0")
            {
                MessageBox.Show("Please select an order row first！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(currentStatus == "ST01" || currentStatus == "ST02" || currentStatus == "ST03" || currentStatus == "ST04" || currentStatus == "ST05"|| currentStatus == "ST06" ))
            {
                MessageBox.Show("This order cannot be cancelled due to its current status！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            DialogResult result = MessageBox.Show("Are you sure to cancel this order? This action cannot be undone.", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string oid = currentOid;
            string sssssql = "";
            MySqlParameter[] param = { new MySqlParameter("@oid", currentOid) };

            if (checkOrder() == "order")
            {

                 sssssql = "SELECT * FROM orders WHERE orderID = @oid";
              
            }
            else
            {
                 sssssql = "SELECT * FROM customorders WHERE corderID = @oid";
            }

            DataTable dtDetail = DbConnect.Query(sssssql, param);
            if (dtDetail.Rows.Count == 0)
            {
                MessageBox.Show("No order items found！");
                return;
            }



            decimal totalRefund = 0;
            foreach (DataRow row in dtDetail.Rows)
            {
                string fid = (checkOrder() == "order") ? row["fID"].ToString() : row["cfID"].ToString();
                decimal qty = Convert.ToDecimal(row["Quantity"]);
                decimal price = (checkOrder() == "order") ? Convert.ToDecimal(row["oAmount"].ToString()) : Convert.ToDecimal(row["coAmount"].ToString()); 
                totalRefund += price;

                if(checkOrder() == "order"){
                    string sql = @"UPDATE furniture SET fQuantity = fQuantity + @Quantity WHERE fID = @FID";
                    MySqlParameter[] parameters = {
                        new MySqlParameter("@Quantity", qty), 
                        new MySqlParameter("@FID", fid) };
                    DataTable dt = DbConnect.Query(sql, parameters);
                }
                else
                {
                    if (currentStatus == "ST01" || currentStatus == "ST02" || currentStatus == "ST03")
                    {
                        totalRefund = Convert.ToDecimal(row["coAmount"].ToString());

                        string sqlcustomcancel = @"SELECT * FROM customrequestmaterials WHERE cfrID = @CFID";
                        MySqlParameter[] parameters = {
                        new MySqlParameter("@CFID", fid) };
                        DataTable dt = DbConnect.Query(sqlcustomcancel, parameters);

                        foreach (DataRow rowMaterial in dt.Rows)
                        {
                            string materialId = rowMaterial["mID"].ToString();
                            decimal materialQty = Convert.ToDecimal(rowMaterial["pmqty"]);
                            MessageBox.Show("Material ID: " + materialId + ", Quantity: " + materialQty);
                            string sqlUpdateMaterial = @"UPDATE material SET mQuantity = mQuantity + @Quantity WHERE materialCode = @MaterialID";
                            MySqlParameter[] updateParameters = {
                                new MySqlParameter("@Quantity", materialQty),
                                new MySqlParameter("@MaterialID", materialId) };
                            DbConnect.Execute(sqlUpdateMaterial, updateParameters);
                        }

                    }




                }
            }




            if (checkOrder() == "order")
            {
                string sqlUpdateMaterial = @"UPDATE customers SET cBudget = cBudget + @totalRefund WHERE cUserID = @cUserID";
                MySqlParameter[] updateParameters = {
                                new MySqlParameter("@totalRefund", totalRefund),
                                new MySqlParameter("@cUserID", UserSession.CustomerId) };
                DbConnect.Execute(sqlUpdateMaterial, updateParameters);
            }
            else {
                string sqlUpdateMaterial = @"UPDATE customers SET cBudget = cBudget + @totalRefund WHERE cUserID = @cUserID";
                MySqlParameter[] updateParameters = {
                                new MySqlParameter("@totalRefund", totalRefund),
                                new MySqlParameter("@cUserID", UserSession.CustomerId) };
                DbConnect.Execute(sqlUpdateMaterial, updateParameters);
            }
        





                try
            {


                string sql = "";
                MySqlParameter[] parameters = null;

                if (checkOrder() == "order")
                {
                    sql = @"UPDATE orders SET statustype = 'ST10', StaffNote = CONCAT(StaffNote, ' [Cancelled by customer at ', NOW(), ']') WHERE orderID = @OrderID AND cUserID = @CustomerID";
                    parameters = new MySqlParameter[]
                    {
                new MySqlParameter("@OrderID", currentOid),
                new MySqlParameter("@CustomerID", UserSession.CustomerId)
                    };
                }
                else if (checkOrder() == "custom")
                {
                    sql = @"UPDATE customorders SET statustype = 'ST10', StaffNote = CONCAT(StaffNote, ' [Cancelled by customer at ', NOW(), ']') WHERE corderID = @OrderID AND cUserID = @CustomerID";
                    parameters = new MySqlParameter[]
                    {
                new MySqlParameter("@OrderID", currentOid),
                new MySqlParameter("@CustomerID", UserSession.CustomerId)
                    };
                }
                else
                {
                    MessageBox.Show("Unsupported order type！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int affectedRows = DbConnect.Execute(sql, parameters);
                if (affectedRows > 0)
                {
                    MessageBox.Show("Order cancelled successfully！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentOid = "0";
                    currentStatus = "0"; 
                    Refresh(); 
                }
                else
                {
                    MessageBox.Show("Failed to cancel order: No order found or permission denied！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdProduced_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(11);
        }

        private void rdWaitingforDelivery_CheckedChanged(object sender, EventArgs e)
        {
            updateStatus(12);
        }
    }
}
