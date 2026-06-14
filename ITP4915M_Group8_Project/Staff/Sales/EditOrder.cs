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
            btnUpdate.Enabled = false;
            nudQuantity.Enabled = false;
            txtDeliveryDate.Enabled = false;
            txtAddress.Enabled = false;
            cbShipping.Enabled = false;
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
            nudQuantity.Maximum = (int)dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value; //Set the maximum value to be the current quantity --> Cannot add more items, because by logic: If you want more items, just create another order      
            nudQuantity.Value = (int)dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value;  //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content
            txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["oAmount"].Value.ToString();           //Amount cell content
            txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
            txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["odeliveryaddress"].Value.ToString();      //Delivery Address cell content
            cbShipping.SelectedIndex = ConvertSOIndex((string) dgvOrderControl.Rows[e.RowIndex].Cells["shippingType"].Value);   //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
            
            //---Activate the buttons for editing---
            btnUpdate.Enabled = true;
            nudQuantity.Enabled = true;
            txtDeliveryDate.Enabled = true;
            txtAddress.Enabled = true;
            cbShipping.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //---Update Proceed---
            string tool_sql = "";
            int rows = 0;
            string main_sql = @"SELECT * FROM orders WHERE orderID = @OID AND fid = @FID";
            DataTable main_dt;
            DataTable tool_dt;
            MySqlParameter[] parameters = { new MySqlParameter("@OID", currentOid), new MySqlParameter("@FID", currentfid) };
            main_dt = DbConnect.Query(main_sql, parameters);

            //---Extract the data for comparison---
            int old_quantity = (int) main_dt.Rows[0]["Quantity"];
            String old_date = main_dt.Rows[0]["odeliverydate"].ToString().Split(' ')[0];
            String old_address = main_dt.Rows[0]["odeliveryaddress"].ToString();
            String old_shippingType_typeID = (string) main_dt.Rows[0]["shippingType"]; // 'ST**'

            int new_quantity = (int) nudQuantity.Value;
            String new_date = txtDeliveryDate.Text.Trim();
            String new_address = txtAddress.Text.Trim();
            int new_shippingType_index = cbShipping.SelectedIndex;  // Selected index of shipping type
            String new_shippingType_String = cbShipping.SelectedItem.ToString();

            //---Field Empty Handler---
            if (new_quantity == 0)
            {
                DialogResult dialogresult = MessageBox.Show("Quantity cannot be 0! \nDo you wish to cancel this record?", "Cancel Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.Yes)
                {
                    //---Cancelling a record---
                    dialogresult = MessageBox.Show("Are you sure you want to cancel this record? \n(Your choice is Irreversible!)", "CANCEL RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        tool_sql = @"UPDATE orders SET statusType = 'ST06' WHERE orderID = @OID AND fID = @FID";
                        tool_dt = DbConnect.Query(tool_sql, parameters);
                        MessageBox.Show("Record has been canceled.", "Record Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh_Click(sender, e);

                        String furniture_sql = @"SELECT fprice FROM furniture WHERE fid = @FID";
                        MySqlParameter furniture_parameter = new MySqlParameter("@FID", currentfid);
                        DataTable furniture_dt = DbConnect.Query(furniture_sql, furniture_parameter);
                        Decimal fprice = (decimal)furniture_dt.Rows[0]["fprice"]; // <-- Extract the furniture price for calculation

                        Decimal refund_price = fprice * old_quantity;

                        MessageBox.Show("An amount of $" + refund_price + " required for refunding to customer " + main_dt.Rows[0]["cUserID"].ToString() + "\nPlease note down!", "Refund Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                return;
            }
            else if (new_date == null)
            {
                MessageBox.Show("Delivery Date cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (new_address == null)
            {
                MessageBox.Show("Delivery Address cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (new_shippingType_index == 0)
            {
                MessageBox.Show("Please select a Shipping Type!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //---No changes were made---
            if (new_quantity == old_quantity && new_date == old_date && new_address == old_address && new_shippingType_index == ConvertSOIndex(old_shippingType_typeID))
            {
                MessageBox.Show("No changes were made!", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //---No Empty fields, update proceeds---

                //---Invalid Date---
                try
                {
                    DateTime parsedDate = DateTime.ParseExact(new_date, "M/dd/yyyy", CultureInfo.InvariantCulture);
                    
                    //---Date has passed---
                    if (parsedDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Delivery Date has passed!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delivery Date Invalid! \nFormat: {M/dd/yyyy}", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //---Confirmation---
                String confirmationMessage = "Do you wish to make these changes?";
                if (new_quantity != old_quantity)
                    confirmationMessage += "\nQuantity: " + old_quantity + " --> " + new_quantity;
                if (new_date != old_date)
                    confirmationMessage += "\nDate: " + old_date + " --> " + new_date;
                if (new_address != old_address)
                    confirmationMessage += "\nAddress: " + old_address + " --> " + new_address;
                if (new_shippingType_index != ConvertSOIndex(old_shippingType_typeID))
                {
                    // Extract the soName from shippingOption
                    String shippingOption_sql = @"SELECT soName FROM shippingOption WHERE soId = @SOID";
                    MySqlParameter shippingOption_parameter = new MySqlParameter("@SOID", old_shippingType_typeID);
                    DataTable shippingOption_dt = DbConnect.Query(shippingOption_sql, shippingOption_parameter);
                    String SOName = (string) shippingOption_dt.Rows[0]["soName"];

                    confirmationMessage += "\nShipping Option: " + SOName + " --> " + new_shippingType_String;
                }
                    

                DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Update Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.No)
                    return;

                // ---Updating Quantity---
                if (new_quantity != old_quantity)
                {                     
                    String furniture_sql = @"SELECT fprice FROM furniture WHERE fid = @FID";
                    MySqlParameter furniture_parameter = new MySqlParameter("@FID", currentfid);
                    DataTable furniture_dt = DbConnect.Query(furniture_sql, furniture_parameter);
                    Decimal fprice = (decimal) furniture_dt.Rows[0]["fprice"]; // <-- Extract the furniture price for calculation
                    
                    Decimal new_price = fprice * new_quantity; // Order Price
                    Decimal refund_price = fprice * old_quantity - new_price;

                    //---Updating the Order---
                    tool_sql = @"UPDATE orders SET Quantity = @Q, oAmount = @A WHERE orderID = @OID AND fid = @FID";
                    MySqlParameter[] Qparameters = { new MySqlParameter("@Q", new_quantity), new MySqlParameter("@A", new_price), new MySqlParameter("@OID", currentOid), new MySqlParameter("@FID", currentfid) };
                    tool_dt = DbConnect.Query(tool_sql, Qparameters);

                    MessageBox.Show("An amount of $" + refund_price + " required for refunding to customer " + main_dt.Rows[0]["cUserID"].ToString()+"\nPlease note down!", "Refund Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                // ---Updating Delivery Date---
                if (new_date != old_date)
                {
                    DateTime parsedDate = DateTime.ParseExact(new_date, "M/dd/yyyy", CultureInfo.InvariantCulture); // Format the date

                    tool_sql = @"UPDATE orders SET odeliverydate = @DATE WHERE orderID = @OID";
                    MySqlParameter[] Dparameters = { new MySqlParameter("@DATE", parsedDate), new MySqlParameter("@OID", currentOid) };
                    tool_dt = DbConnect.Query(tool_sql, Dparameters);
                }

                // ---Updating Delivery Address---
                if (new_address != old_address)
                {
                    tool_sql = @"UPDATE orders SET odeliveryaddress = @ADD WHERE orderID = @OID";
                    MySqlParameter[] Aparameters = { new MySqlParameter("@ADD", new_address), new MySqlParameter("@OID", currentOid) };
                    tool_dt = DbConnect.Query(tool_sql, Aparameters);
                }

                // ---Updating Shipping Type---
                if (new_shippingType_index != ConvertSOIndex(old_shippingType_typeID))
                {
                    // Extract the soId from shippingOption
                    String shippingOption_sql = @"SELECT soId FROM shippingOption WHERE soName = @SONAME";
                    MySqlParameter shippingOption_parameter = new MySqlParameter("@SONAME", new_shippingType_String);
                    DataTable shippingOption_dt = DbConnect.Query(shippingOption_sql, shippingOption_parameter);
                    String SOtype = (string) shippingOption_dt.Rows[0]["soId"];

                    tool_sql = @"UPDATE orders SET shippingType = @TYPE WHERE orderID = @OID";
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
            btnUpdate.Enabled = false;
            nudQuantity.Enabled = false;
            txtDeliveryDate.Enabled = false;
            txtAddress.Enabled = false;
            cbShipping.Enabled = false;
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
