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

namespace ITP4915M_Group8_Project.Customer
{
    public partial class customOrder : Form
    {
        private string currentOid = "0";
        private string currentStatus = "0";
        private string currentFid = "0";

        public customOrder()
        {
            InitializeComponent();
            LoadDataToGridView();
            rbAll.Checked = true;
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
            string sql = "SELECT * FROM orders WHERE cUserID = @customerId AND orderID LIKE @keyword ORDER BY orderID";
            DataTable dt;

            if (checkStatus() != null) // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE cUserID = @customerId AND orderID LIKE @keyword AND statustype = @STATUS ORDER BY orderID";
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

            //Get fName from furniture
            string sql = @"SELECT fName FROM furniture WHERE fID = @FID";
            MySqlParameter[] parameters = {
                new MySqlParameter("@FID", dgvOrderControl.Rows[e.RowIndex].Cells["fId"].Value.ToString()) };
            DataTable dt = DbConnect.Query(sql, parameters);
            string furnitureName = dt.Rows[0]["fname"].ToString();      //<-- Extract Furniture name from table

            //Get soName from shippingoption
            sql = @"SELECT soName FROM shippingoption WHERE soID = @SOID";
            parameters = new MySqlParameter[] { new MySqlParameter("@SOID", dgvOrderControl.Rows[e.RowIndex].Cells["shippingType"].Value.ToString()) };
            dt = DbConnect.Query(sql, parameters);
            string shippingName = dt.Rows[0]["soName"].ToString();      //<--Extract Shipping Type Name from table

            //Get statusDesc from status
            sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            parameters = new MySqlParameter[] { new MySqlParameter("@STATUSCODE", dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString()) };
            dt = DbConnect.Query(sql, parameters);
            string statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table



            currentOid = dgvOrderControl.Rows[e.RowIndex].Cells["orderID"].Value.ToString(); //Stores the selected orderID
            currentFid = dgvOrderControl.Rows[e.RowIndex].Cells["fID"].Value.ToString(); //Stores the selected furnitureID
            currentStatus = dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString(); //Stores the selected statusType
            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content 
            txtQuantity.Text = dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();             //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content
            txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oAmount"].Value.ToString();           //Amount cell content
            txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
            txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            txtShipping.Text = shippingName;         //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
            txtStaffNote.Text = dgvOrderControl.Rows[e.RowIndex].Cells["StaffNote"].Value.ToString(); ;
        }

        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM orders WHERE cUserID = @customerId AND orderID = @OID ORDER BY orderID";
            DataTable dt;
            if (checkStatus() != null)  // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE orderID = @OID AND statustype = @STATUS ORDER BY orderID";
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
            string sql = @"SELECT * FROM orders WHERE cUserID = @customerId ORDER BY orderID";
            DataTable dt;
            if (checkStatus() != null) // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE cUserID = @customerId AND statustype = @STATUS ORDER BY orderID";
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

        // ---------Methods---------
        private void updateStatus(int status) // Used by Radio Buttons
        {
            DataTable dt;
            string sql = @"SELECT * FROM orders WHERE cUserID = @customerId AND statusType = @STATUS ORDER BY orderID";

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
                default:
                    sql = "SELECT * FROM orders WHERE cUserID = @customerId ORDER BY orderID";
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
                CustomerService.After_sales_Request form = new CustomerService.After_sales_Request(currentOid, currentFid);
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
    }
}
