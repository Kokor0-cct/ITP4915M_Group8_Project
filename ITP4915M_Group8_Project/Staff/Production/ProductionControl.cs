using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_Group8_Project.Staff.Production
{
    public partial class Production_Control : Form
    {

        private string currentOid = "0";

        public Production_Control()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM customorders WHERE statusType = 'ST02' or statusType = 'ST03' or statusType = 'ST04' ORDER BY corderID"; // It only gets records with the status "In Transit"


            DataTable dt = DbConnect.Query(sql);


            dgvOrderControl.DataSource = dt;
        }

        //------search the textboxes text item in database------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();


            string sql = @"SELECT * FROM customorders WHERE corderID LIKE @keyword AND (statusType = 'ST02' or statusType = 'ST03' or statusType = 'ST04') ORDER BY corderID";


            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvOrderControl.DataSource = dt;
        }

        //------Refresh form to show database data ------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customorders WHERE statusType = 'ST02' or statusType = 'ST03' or statusType = 'ST04' ORDER BY corderID";
            DataTable dt = DbConnect.Query(sql);
            dgvOrderControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }
        //------Refresh form to show database data ------

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentOid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to accept this order for production? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE customorders SET statusType = 'ST03' WHERE corderID = @OID";

            MySqlParameter parameters = new MySqlParameter("@OID", currentOid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Order Accepted！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentOid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }
        private void btnCompleteProduction_Click(object sender, EventArgs e)
        {
            if (currentOid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to complete production for this order? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE customorders SET statusType = 'ST04' WHERE statusType = 'ST03' AND corderID = @corderID";

            MySqlParameter parameters = new MySqlParameter("@corderID", currentOid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Production completed！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentOid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }

        private void btnReadyForDelivery_Click(object sender, EventArgs e)
        {
            if (currentOid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Is the order ready for delivery? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            DateTime parsedDate = DateTime.ParseExact(txtDeliveryDate.Text.Trim(), "yyyy/M/d", CultureInfo.InvariantCulture); // Format the date
            Staff.Logistic.CreateNewShippingRequest Form = new Staff.Logistic.CreateNewShippingRequest();
            Form.collectShippingDetails(currentOid, parsedDate, txtAddress.Text.Trim());
            Form.ShowDialog();
            if (Form.inserted == false)
            {
                MessageBox.Show("Collection Address not inserted, update order cancelled", "Collection Address not inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            string sql = @"UPDATE customorders SET statusType = 'ST05' WHERE statusType = 'ST04' AND corderID = @corderID";

            MySqlParameter parameters = new MySqlParameter("@corderID", currentOid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Production completed！", "Update Successful");
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
            try {
                dgvOrderControl.CurrentRow.Selected = true;
                if (e.RowIndex < 0) //If the selected row are the field names, skip all codes below
                    return;
            }catch(Exception ex)
            {
                return; //Clicked on the fields but the table is empty
            }

            //Get cfName from customfurniture
            string sql = @"SELECT cfName FROM customfurniture WHERE cfID = @FID";
            MySqlParameter parameters = new MySqlParameter("@FID", dgvOrderControl.Rows[e.RowIndex].Cells["cfID"].Value.ToString());
            DataTable dt = DbConnect.Query(sql, parameters);
            String furnitureName = dt.Rows[0]["cfName"].ToString();      //<-- Extract Furniture name from table

            //Get soName from shippingoption
            sql = @"SELECT soName FROM shippingoption WHERE soId = @SOID";
            parameters = new MySqlParameter("@SOID", dgvOrderControl.Rows[e.RowIndex].Cells["shippingType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String shippingName = dt.Rows[0]["soName"].ToString();      //<--Extract Shipping Type Name from table

            //Get statusDesc from status
            sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            parameters = new MySqlParameter("@STATUSCODE", dgvOrderControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table

            currentOid = dgvOrderControl.Rows[e.RowIndex].Cells["corderID"].Value.ToString(); //Stores the selected orderID
            txtOrderID.Text = currentOid;                       //Order ID cell content
            txtFurniture.Text = furnitureName;                 //Furniture ID cell content 
            txtQuantity.Text = dgvOrderControl.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();             //Quantity cell content
            txtUserID.Text = dgvOrderControl.Rows[e.RowIndex].Cells["cUserID"].Value.ToString();                //UserID cell content
            txtAmount.Text = dgvOrderControl.Rows[e.RowIndex].Cells["coAmount"].Value.ToString();           //Amount cell content
            txtDeliveryDate.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliverydate"].Value.ToString().Split(' ')[0];    //Delivery Date cell content
            txtAddress.Text = dgvOrderControl.Rows[e.RowIndex].Cells["codeliveryaddress"].Value.ToString();      //Delivery Address cell content
            txtShipping.Text = shippingName;         //Shipping Type cell content    
            txtStatus.Text = statusName;             //Status Type cell content      
        }


        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customorders WHERE corderID = @OID AND statusType = 'ST02' ORDER BY corderID";
            MySqlParameter parameters = new MySqlParameter("@OID", currentOid);
            DataTable dt = DbConnect.Query(sql, parameters);
            dgvOrderControl.DataSource = dt;
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        
    }
}
