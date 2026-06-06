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

namespace ITP4915M_Group8_Project.Staff.Logistic
{
    public partial class Logistics_Control : Form
    {

        private string currentOid = "0";
        private Boolean showDelivered = false;

        public Logistics_Control()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM orders WHERE statusType = 2 ORDER BY orderID"; // It only gets records with the status "In Transit"


            DataTable dt = DbConnect.Query(sql);


            dgvOrderControl.DataSource = dt;
        }

        private void chkDelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelivered.Checked == true)
                showDelivered = true;
            else
                showDelivered = false;
            btnRefresh_Click(sender, e);
        }

        //------search the textboxes text item in database------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();


            string sql = (showDelivered == false) ? @"SELECT * FROM orders WHERE orderID LIKE @keyword AND statusType = 2 ORDER BY orderID" :
                @"SELECT * FROM orders WHERE orderID LIKE @keyword AND (statusType = 2 OR statusType = 3) ORDER BY statusType, orderID";


            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvOrderControl.DataSource = dt;
        }

        //------Refresh form to show database data ------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = (showDelivered == false) ? "SELECT * FROM orders WHERE statusType = 2 ORDER BY orderID" :
                "SELECT * FROM orders WHERE (statusType = 2 OR statusType = 3) ORDER BY statusType, orderID";
            DataTable dt = DbConnect.Query(sql);
            dgvOrderControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }
        //------Refresh form to show database data ------

        private void btnCompleteDelivery_Click(object sender, EventArgs e)
        {
            if (currentOid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to complete delivery for this data? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE orders SET statusType = 3 WHERE statusType = 2 AND orderID = @orderID";

            MySqlParameter parameters = new MySqlParameter("@orderID", currentOid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Delivery completed！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentOid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }

        //------Clear TextBox  ------
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
        }//------Clear TextBox  ------

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

            if (dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString() != "2")
                btnCompleteDelivery.Enabled = false;
            else
                btnCompleteDelivery.Enabled = true;

        }


        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {


            string sql = (showDelivered == false) ? "SELECT * FROM orders WHERE orderID = @OID AND statusType = 2 ORDER BY orderID" :
                "SELECT * FROM orders WHERE orderID = @OID AND (statusType = 2 OR statusType = 3) ORDER BY statusType, orderID";
            MySqlParameter parameters = new MySqlParameter("@OID", currentOid);
            DataTable dt = DbConnect.Query(sql, parameters);
            dgvOrderControl.DataSource = dt;
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffMenu menu = new StaffMenu();
            menu.Show();
            this.Close();
        }
    }
}
