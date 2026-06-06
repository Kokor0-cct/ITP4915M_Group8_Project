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

        public ViewOrder()
        {
            InitializeComponent();
            LoadDataToGridView();
            rbAll.Checked = true;
        }

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM orders ORDER BY orderID"; // It only gets records with the status "In Transit"


            DataTable dt = DbConnect.Query(sql);


            dgvOrderControl.DataSource = dt;
        }

        // ---------UI Interaction---------
        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffMenu form = new StaffMenu();
            form.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();
            string sql = "SELECT * FROM orders WHERE orderID LIKE @keyword ORDER BY orderID";
            DataTable dt;

            if (checkStatus() != null) // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE orderID LIKE @keyword AND statustype = @STATUS ORDER BY orderID";
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

            //Get fName from furniture
            string sql = @"SELECT fName FROM furniture WHERE fID = @FID";
            MySqlParameter parameters = new MySqlParameter("@FID", dgvOrderControl.Rows[e.RowIndex].Cells["fId"].Value.ToString());
            DataTable dt = DbConnect.Query(sql, parameters);
            String furnitureName = dt.Rows[0]["fname"].ToString();      //<-- Extract Furniture name from table

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

            currentOid = dgvOrderControl.Rows[e.RowIndex].Cells["orderID"].Value.ToString(); //Stores the selected orderID
            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content 
            txtQuantity.Text = dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();             //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content
            txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oTotalAmount"].Value.ToString();           //Amount cell content
            txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString();    //Delivery Date cell content
            txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            txtShipping.Text = shippingName;         //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
        }

        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM orders WHERE orderID = @OID ORDER BY orderID";
            DataTable dt;
            if (checkStatus() != null)  // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE orderID = @OID AND statustype = @STATUS ORDER BY orderID";
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
            string sql = @"SELECT * FROM orders ORDER BY orderID";
            DataTable dt;
            if (checkStatus() != null) // A status is selected
            {
                sql = @"SELECT * FROM orders WHERE statustype = @STATUS ORDER BY orderID";
                MySqlParameter[] parameters = { new MySqlParameter("@OID", currentOid), new MySqlParameter("@STATUS", checkStatus()) };
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
            String sql = @"SELECT * FROM orders WHERE statusType = @STATUS ORDER BY orderID";
            String sqlstat = "";
            ClearTextBox();

            switch (status)
            {
                case 1:
                    sqlstat = "1";
                    break;
                case 2:
                    sqlstat = "2";
                    break;
                case 3:
                    sqlstat = "3";
                    break;
                case 4:
                    sqlstat = "4";
                    break;
                case 5:
                    sqlstat = "5";
                    break;
                case 6:
                    sqlstat = "6";
                    break;
                default:
                    sql = "SELECT * FROM orders ORDER BY orderID";
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
                return "1";
            else if (rbProduction.Checked == true)
                return "2";
            else if (rbTransit.Checked == true)
                return "3";
            else if (rbDelivered.Checked == true)
                return "4";
            else if (rbFailed.Checked == true)
                return "5";
            else if (rbCancel.Checked == true)
                return "6";
            else
                return null;
        }
    }
}
