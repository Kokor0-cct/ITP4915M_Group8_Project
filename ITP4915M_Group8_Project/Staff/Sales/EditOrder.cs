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

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class EditOrder : Form
    {
        private string currentOid = "0";

        public EditOrder()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM orders WHERE statustype = 1 or statustype = 2 ORDER BY orderID "; // It only gets records with the status "In Transit"


            DataTable dt = DbConnect.Query(sql);


            dgvOrderControl.DataSource = dt;
        }

        // ---------UI Interaction---------

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffMenu menu = new StaffMenu();
            menu.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();
            string sql = "SELECT * FROM orders WHERE orderID LIKE @keyword AND (statustype = 1 or statustype = 2) ORDER BY orderID";
            DataTable dt;
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };
            dt = DbConnect.Query(sql, parameters);

            dgvOrderControl.DataSource = dt;
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
            MySqlParameter parameter = new MySqlParameter("@OID", currentOid);
            dt = DbConnect.Query(sql, parameter);

            dgvOrderControl.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM orders ORDER BY orderID";
            DataTable dt;
            sql = @"SELECT * FROM orders WHERE statustype = 1 or statustype = 2 ORDER BY orderID";
            dt = DbConnect.Query(sql);

            dgvOrderControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }

        // ---------Methods---------
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


    }
}
