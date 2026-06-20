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

namespace ITP4915M_Group8_Project.Staff.Inventory
{
    public partial class MaterialRequirementList : Form
    {

        private string currentMRid = "0";

        public MaterialRequirementList()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM materialrequest";


            DataTable dt = DbConnect.Query(sql);


            dgvMaterialRequestControl.DataSource = dt;
        }

        //------search the textboxes text item in database------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();


            string sql = @"SELECT * FROM materialrequest WHERE mrID LIKE @keyword";


            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvMaterialRequestControl.DataSource = dt;
        }

        //------Refresh form to show database data ------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM materialrequest";
            DataTable dt = DbConnect.Query(sql);
            dgvMaterialRequestControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }
        //------Refresh form to show database data ------

        private void btnCompleteProduction_Click(object sender, EventArgs e)
        {
            if (currentMRid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to complete the material request? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE materialrequest SET statusType = 'ST08' WHERE statusType = 'ST07' AND mrID = @mrID";

            MySqlParameter parameters = new MySqlParameter("@mrID", currentMRid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Material Request completed！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentMRid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }

        //------Clear TextBox  ------
        private void ClearTextBox()
        {
            txtMRID.Clear();
            txtFurniture.Clear();
            txtQuantity.Clear();
            txtUserID.Clear();
            txtCreationDate.Clear();
            txtRequiredDate.Clear();
            txtUrgencyLevel.Clear();
            txtStatus.Clear();
        }//------Clear TextBox  ------

        private void dgvOrderControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                dgvMaterialRequestControl.CurrentRow.Selected = true;
                if (e.RowIndex < 0) //If the selected row are the field names, skip all codes below
                    return;
            //}catch(NullReferenceException ex)
            //{
                
            //}
            

            //Get mName from Material
            string sql = @"SELECT mName FROM material WHERE materialCode = @MID";
            MySqlParameter parameters = new MySqlParameter("@MID", dgvMaterialRequestControl.Rows[e.RowIndex].Cells["materialCode"].Value.ToString());
            DataTable dt = DbConnect.Query(sql, parameters);
            String materialName = dt.Rows[0]["mName"].ToString();      //<-- Extract Furniture name from table

            //Get statusDesc from status
            sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            parameters = new MySqlParameter("@STATUSCODE", dgvMaterialRequestControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString());
            dt = DbConnect.Query(sql, parameters);
            String statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table

            currentMRid = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["mrID"].Value.ToString(); //Stores the selected orderID
            txtMRID.Text = currentMRid;                       //Material Request ID cell content
            txtFurniture.Text = materialName;                 //Material name ID cell content 
            txtQuantity.Text = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["mrQuantity"].Value.ToString();          //Quantity cell content
            txtUserID.Text = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["sUserID"].Value.ToString();               //UserID cell content
            txtCreationDate.Text = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["createDate"].Value.ToString();      // cell content
            txtRequiredDate.Text = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["RequiredDate"].Value.ToString();    //RequiredDate cell content
            txtUrgencyLevel.Text = dgvMaterialRequestControl.Rows[e.RowIndex].Cells["UrgencyLevel"].Value.ToString();    //Urgencylvl cell content  
            txtStatus.Text = statusName;             //Status Type cell content      

            if (dgvMaterialRequestControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString() == "ST01")
                btnAccept.Enabled = true;
            else
                btnAccept.Enabled = false;

            if (dgvMaterialRequestControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString() != "ST07")
                btnCompleteRequest.Enabled = false;
            else
                btnCompleteRequest.Enabled = true;
        }


        // Find the records with matching OrderID
        private void btnFindSimilar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM materialrequest WHERE mrID = @MRID";
            MySqlParameter parameters = new MySqlParameter("@MRID", currentMRid);
            DataTable dt = DbConnect.Query(sql, parameters);
            dgvMaterialRequestControl.DataSource = dt;
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffMenu menu = new StaffMenu();
            menu.Show();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentMRid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to ACCEPT the material request? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE materialrequest SET statusType = 'ST07' WHERE statusType = 'ST01' AND mrID = @mrID";

            MySqlParameter parameters = new MySqlParameter("@mrID", currentMRid);

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Material Request Accepted！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentMRid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }
    }
}
