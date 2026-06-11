using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System.Data;
using System.Globalization;

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class EditOrder : Form
    {
        private string currentOid = "0";
        private string currentfid = "0";

        public EditOrder()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM orders WHERE statustype = 'ST01' or statustype = 'ST02' ORDER BY orderID "; // It only gets records with the status "In Transit"


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
            string sql = "SELECT * FROM orders WHERE orderID LIKE @keyword AND (statustype = 'ST01' or statustype = 'ST02') ORDER BY orderID";
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
            currentfid = dgvOrderControl.Rows[e.RowIndex].Cells["fId"].Value.ToString();
            string sql = @"SELECT fName FROM furniture WHERE fID = @FID";
            MySqlParameter parameters = new MySqlParameter("@FID", currentfid);
            DataTable dt = DbConnect.Query(sql, parameters);
            String furnitureName = dt.Rows[0]["fname"].ToString();      //<-- Extract Furniture name from table

            //Get statusDesc from status
            sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            parameters = new MySqlParameter("@STATUSCODE", dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table

            currentOid = dgvOrderControl.Rows[e.RowIndex].Cells["orderID"].Value.ToString(); //Stores the selected orderID
            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content         

            nudQuantity.Maximum = (int)dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value;
            nudQuantity.Value = (int)dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value;                 //Quantity cell content
            

            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content
            txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oAmount"].Value.ToString();           //Amount cell content
            txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString();    //Delivery Date cell content
            txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            cbShipping.SelectedIndex = ConvertSOIndex((string) dgvOrderControl.Rows[e.RowIndex].Cells["shippingType"].Value);   //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tool_sql = "";
            int rows = 0;
            string main_sql = @"SELECT * FROM orders WHERE orderID = @OID AND fid = @FID";
            DataTable main_dt;
            DataTable tool_dt;
            MySqlParameter[] parameters = { new MySqlParameter("@OID", currentOid), new MySqlParameter("@FID", currentfid) };
            main_dt = DbConnect.Query(main_sql, parameters);


            //---Field Empty Handler---
            if (nudQuantity.Value == 0)
            {
                MessageBox.Show("Quantity cannot be 0! \nDo you wish to cancel this record?", "Cancel Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else if (txtDeliveryDate.Text.Trim() == null)
            {
                MessageBox.Show("Delivery Date cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtAddress.Text.Trim() == null)
            {
                MessageBox.Show("Delivery Address cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbShipping.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a Shipping Type!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudQuantity.Value == (int) main_dt.Rows[0]["Quantity"] && txtDeliveryDate.Text.Trim() == main_dt.Rows[0]["odeliverydate"].ToString() && txtAddress.Text.Trim() == main_dt.Rows[0]["odeliveryaddress"].ToString() && cbShipping.SelectedIndex == (int) main_dt.Rows[0]["shippingType"])
            {
                MessageBox.Show("No changes were made!", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // ---No Empty fields, update proceeds---

                // ---Updating Quantity---
                if (nudQuantity.Value != (int)main_dt.Rows[0]["Quantity"])
                { 
                    int quantity = (int) nudQuantity.Value;
                    
                    String furniture_sql = @"SELECT fprice FROM furniture WHERE fid = @FID";
                    MySqlParameter furniture_parameter = new MySqlParameter("@FID", currentfid);
                    DataTable furniture_dt = DbConnect.Query(furniture_sql, furniture_parameter);
                    Decimal fprice = (decimal) furniture_dt.Rows[0]["fprice"]; // <-- Extract the furniture price for calculation
                    
                    Decimal price = fprice * quantity; // Order Price

                    tool_sql = @"UPDATE orders SET Quantity = @Q, oAmount = @A WHERE orderID = @OID AND fid = @FID";
                    MySqlParameter[] Qparameters = { new MySqlParameter("@Q", quantity), new MySqlParameter("@A", price), new MySqlParameter("@OID", currentOid), new MySqlParameter("@FID", currentfid) };
                    tool_dt = DbConnect.Query(tool_sql, Qparameters);
                }

                // ---Updating Delivery Date---
                if (txtDeliveryDate.Text.Trim() != main_dt.Rows[0]["odeliverydate"].ToString())
                {
                    String dateString = txtDeliveryDate.Text.Trim();
                    DateTime parsedDate = DateTime.ParseExact(dateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                    tool_sql = @"UPDATE order SET odeliverydate = @DATE WHERE orderID = @OID";
                    MySqlParameter[] Dparameters = { new MySqlParameter("@DATE", parsedDate.ToString("yyyy-mm-dd")), new MySqlParameter("@OID", currentOid) };
                    tool_dt = DbConnect.Query(tool_sql, Dparameters);
                }

                // ---Updating Delivery Address---
                if (txtAddress.Text.Trim() != main_dt.Rows[0]["odeliveryaddress"].ToString())
                {
                    tool_sql = @"UPDATE order SET odeliveryaddress = @ADD WHERE orderID = @OID";
                    MySqlParameter[] Aparameters = { new MySqlParameter("@ADD", txtAddress.Text.Trim()), new MySqlParameter("@OID", currentOid) };
                    tool_dt = DbConnect.Query(tool_sql, Aparameters);
                }

                // ---Updating Shipping Type---
                if (cbShipping.SelectedIndex != ConvertSOIndex((string) main_dt.Rows[0]["shippingType"]))
                {
                    // Extract the soId from shippingOption
                    String shippingOption_sql = @"SELECT soId FROM shippingOption WHERE soName = @SONAME";
                    MySqlParameter shippingOption_parameter = new MySqlParameter("@SONAME", cbShipping.SelectedIndex.ToString());
                    DataTable shippingOption_dt = DbConnect.Query(shippingOption_sql, shippingOption_parameter);
                    String SOtype = (string) shippingOption_dt.Rows[0]["soId"];

                    tool_sql = @"UPDATE order SET shippingType = @TYPE WHERE orderID = @OID";
                    MySqlParameter[] Sparameters = { new MySqlParameter("@TYPE", SOtype), new MySqlParameter("@OID", currentOid) };
                    tool_dt = DbConnect.Query(tool_sql, Sparameters);
                }

                MessageBox.Show("Update Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
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
            sql = @"SELECT * FROM orders WHERE statustype = 'ST01' or statustype = 'ST02' ORDER BY orderID";
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
            nudQuantity.Value = 0;
            nudQuantity.Maximum = 0;
            txtUserID.Clear();
            txtAmount.Clear();
            txtDeliveryDate.Clear();
            txtAddress.Clear();
            cbShipping.SelectedIndex = 0;
            txtStatus.Clear();
        }

        private int ConvertSOIndex(String shippingOptionString)
        {
            int shippingIndex = 0;
            if (shippingOptionString.Equals("SO01"))
                shippingIndex = 1;
            else if (shippingOptionString.Equals("SO02"))
                shippingIndex = 2;
            return shippingIndex;
        }
    }
}
