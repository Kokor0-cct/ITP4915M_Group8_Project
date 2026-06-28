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

namespace ITP4915M_Group8_Project.Staff
{
    public partial class ViewOrder : Form
    {
        private string currentOid = "0";
        private string role = "";

        public ViewOrder()
        {
            InitializeComponent();
            if (UserSession.CustomerId != null)
            {
                role = UserSession.CustomerId.ToString();
            }
            else
            {
                role = "Staff";
            }
            LoadDataToGridView();
            rbOrders.Checked = true;
            rbAll.Checked = true;
        }

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM orders ORDER BY orderID"; 


            DataTable dt = DbConnect.Query(sql);


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
            string sql = (checkOrder() == "order") ?"SELECT * FROM orders WHERE orderID LIKE @keyword ORDER BY orderID": "SELECT * FROM customorders WHERE corderID LIKE @keyword ORDER BY corderID";
            DataTable dt;

            if (checkStatus() != null) // A status is selected
            {
                sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE orderID LIKE @keyword AND statustype = @STATUS ORDER BY orderID": @"SELECT * FROM customorders WHERE corderID LIKE @keyword AND statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%"), new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else
            { // A status is not selected / "all"
                MySqlParameter parameters = new MySqlParameter("@keyword", "%" + keyword + "%");
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

            currentOid = (checkOrder() == "order") ?dgvOrderControl.Rows[e.RowIndex].Cells["orderID"].Value.ToString(): dgvOrderControl.Rows[e.RowIndex].Cells["corderID"].Value.ToString(); //Stores the selected orderID
            
            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content 
            txtQuantity.Text = dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();             //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content

            if (checkOrder() == "order")
            {
                txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oAmount"].Value.ToString();           //Amount cell content
                txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
                txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            }
            else
            {
                txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["coAmount"].Value.ToString();           //Amount cell content
                txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
                txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliveryaddress"].Value.ToString();      //Delivery Address cell content
            }
            
            
            txtShipping.Text = shippingName;         //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
        }

        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE orderID = @OID ORDER BY orderID" : @"SELECT * FROM customorders WHERE corderID = @OID ORDER BY corderID";
            DataTable dt;
            if (checkStatus() != null)  // A status is selected
            {
                sql = (checkOrder() == "order") ? @"SELECT * FROM orders WHERE orderID = @OID AND statustype = @STATUS ORDER BY orderID" : @"SELECT * FROM customorders WHERE corderID = @OID AND statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = { new MySqlParameter("@OID", currentOid), new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else    // A status is not selected / "all"
            {
                MySqlParameter parameter = new MySqlParameter("@OID", currentOid);
                dt = DbConnect.Query(sql, parameter);
            }

            dgvOrderControl.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = (checkOrder() == "order") ? "SELECT * FROM orders ORDER BY orderID" : "SELECT * FROM customorders ORDER BY corderID";
            DataTable dt;
            if (checkStatus() != null) // A status is selected
            {
                sql = (checkOrder() == "order") ?@"SELECT * FROM orders WHERE statustype = @STATUS ORDER BY orderID": @"SELECT * FROM customorders WHERE statustype = @STATUS ORDER BY corderID";
                MySqlParameter[] parameters = { new MySqlParameter("@STATUS", checkStatus()) };
                dt = DbConnect.Query(sql, parameters);
            }
            else    // A status is not selected / "all"
            {
                dt = DbConnect.Query(sql);
            }

            dgvOrderControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }

        // ---------Methods---------
        private void updateStatus(int status) // Used by Radio Buttons
        {
            DataTable dt;
            String sql = (checkOrder() == "order") ?@"SELECT * FROM orders WHERE statusType = @STATUS ORDER BY orderID": @"SELECT * FROM customorders WHERE statusType = @STATUS ORDER BY corderID";
            String sqlstat = "";
            ClearTextBox();

            switch (status)
            {
                case 1:
                    sqlstat = "ST01";
                    break;
                case 2:
                    sqlstat = "ST02";
                    break;
                case 3:
                    sqlstat = "ST03";
                    break;
                case 4:
                    sqlstat = "ST04";
                    break;
                case 5:
                    sqlstat = "ST05";
                    break;
                case 6:
                    sqlstat = "ST06";
                    break;
                default:
                    sql = (checkOrder() == "order") ? "SELECT * FROM orders ORDER BY orderID": "SELECT * FROM customorders ORDER BY corderID";
                    dt = DbConnect.Query(sql);
                    dgvOrderControl.DataSource = dt;
                    return;
            }
            MySqlParameter parameters = new MySqlParameter("@STATUS", sqlstat);
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

        private String checkOrder()    // Used for generals
        {
            if (rbOrders.Checked == true)
                return "order";
            else if (rbCustomOrders.Checked == true)
                return "custom";
            else
                return null;
        }

    }
}
