using ITP4915M_Group8_Project.Staff.Inventory;
using Microsoft.VisualBasic;
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

        private string currentsrid = "0";
        private string currentItemid = "0";

        public Logistics_Control()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------

        private void LoadDataToGridView()
        {

            string sql = rbCheck("SELECT * FROM shippingrequest ");


            DataTable dt = DbConnect.Query(sql);


            dgvLogisticsControl.DataSource = dt;
        }

        //------search the textboxes text item in database------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            ClearTextBox();
            string keyword = txtSearch.Text.Trim();


            string sql = @"SELECT * FROM shippingrequest WHERE SRID LIKE @keyword ";


            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvLogisticsControl.DataSource = dt;
        }

        //------Refresh form to show database data ------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = rbCheck("SELECT * FROM shippingrequest ");
            DataTable dt = DbConnect.Query(sql);
            dgvLogisticsControl.DataSource = dt;
            txtSearch.Clear();
            ClearTextBox();
        }
        //------Refresh form to show database data ------

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentsrid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to accept this delivery? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE shippingrequest SET statusType = 'ST06' WHERE  srID = @SRID";

            MySqlParameter parameters = new MySqlParameter("@SRID", currentsrid);

            int rows = DbConnect.Execute(sql, parameters);
            int other_rows = updateStatusOther(currentItemid, "ST06");

            if (rows > 0 && other_rows == 1)
            {
                MessageBox.Show("Delivery Accepted！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentsrid = "0";
                currentItemid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }

        private void btnCompleteDelivery_Click(object sender, EventArgs e)
        {
            if (currentsrid == "0")
            {
                MessageBox.Show("Please select a row to complete!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to complete this delivery? \n(Your choice is irreversible)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = @"UPDATE shippingrequest SET statusType = 'ST07' WHERE  srID = @SRID";

            MySqlParameter parameters = new MySqlParameter("@SRID", currentsrid);

            int rows = DbConnect.Execute(sql, parameters);
            int other_rows = updateStatusOther(currentItemid, "ST07");

            if (rows > 0 && other_rows == 1)
            {
                MessageBox.Show("Delivery completed！", "Update Successful");
                LoadDataToGridView();
                ClearTextBox();
                currentsrid = "0";
                currentItemid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！", "Update Unsuccessful");
            }
        }

        //------Clear TextBox  ------
        private void ClearTextBox()
        {
            txtSRID.Clear();
            txtIID.Clear();
            txtItemType.Clear();
            txtCreatedDate.Clear();
            txtCollectionAddress.Clear();
            txtDeliveryDate.Clear();
            txtDeliveryAddress.Clear();
            txtStatus.Clear();
        }//------Clear TextBox  ------

        private void dgvOrderControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                dgvLogisticsControl.CurrentRow.Selected = true;
                if (e.RowIndex < 0) //If the selected row are the field names, skip all codes below
                    return;
            }catch(Exception ex)
            {
                return; //Clicked on the fields but the table is empty
            }

            //Get statusDesc from status
            string sql = @"SELECT statusDesc FROM status WHERE statusCode = @STATUSCODE";
            MySqlParameter parameters = new MySqlParameter("@STATUSCODE", dgvLogisticsControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString());
            DataTable dt = DbConnect.Query(sql, parameters);
            String statusName = dt.Rows[0]["statusDesc"].ToString();    //<-- Extract Status Type Name from table

            currentsrid = dgvLogisticsControl.Rows[e.RowIndex].Cells["SRID"].Value.ToString(); 
            txtSRID.Text = currentsrid;                       

            currentItemid = dgvLogisticsControl.Rows[e.RowIndex].Cells["IID"].Value.ToString();
            txtIID.Text = currentItemid;
            if (currentItemid.StartsWith("O"))
                txtItemType.Text = "Order";
            else if (currentItemid.StartsWith("CO"))
                txtItemType.Text = "Custom Order";
            else if (currentItemid.StartsWith("MR"))
                txtItemType.Text = "Material";
            else
                txtItemType.Text = "Invalid Data Type";

            txtCreatedDate.Text = dgvLogisticsControl.Rows[e.RowIndex].Cells["createDate"].Value.ToString().Split(' ')[0];               //Created Date cell content
            txtDeliveryDate.Text = dgvLogisticsControl.Rows[e.RowIndex].Cells["deliveryDate"].Value.ToString().Split(' ')[0];            //Delivery Date cell content
            txtCollectionAddress.Text = dgvLogisticsControl.Rows[e.RowIndex].Cells["collectAddress"].Value.ToString();     //Collection Address cell content 
            txtDeliveryAddress.Text = dgvLogisticsControl.Rows[e.RowIndex].Cells["deliveryAddress"].Value.ToString();      //Delivery Address cell content 
            txtStatus.Text = statusName;             //Status Type cell content      

            if (dgvLogisticsControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString() == "ST06")
                btnCompleteDelivery.Enabled = true;
            else
                btnCompleteDelivery.Enabled = false;
            if (dgvLogisticsControl.Rows[e.RowIndex].Cells["statusType"].Value.ToString() == "ST05")
                btnAccept.Enabled = true;
            else
                btnAccept.Enabled = false;

        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void rbOrder_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox();
            LoadDataToGridView();
        }

        private void rbCO_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox();
            LoadDataToGridView();
        }

        private void rbMaterial_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox();
            LoadDataToGridView();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox();
            LoadDataToGridView();
        }

        public string rbCheck(string sql)
        {
            if (rbAll.Checked)
            {
                sql += "ORDER BY deliveryDate";
                return sql;
            }
            else
            {
                sql += "WHERE IID LIKE ";
                if (rbOrder.Checked)
                {
                    sql += "'O%'";
                }
                else if(rbCO.Checked)
                {
                    sql += "'CO%'";
                }else if (rbMaterial.Checked)
                {
                    sql += "'MR%'";
                }
                sql += " ORDER BY deliveryDate";
                return sql;
            }
        }

        public int updateStatusOther(String ItemID, string statusID)
        {
            String sql = "";
            if (ItemID.StartsWith("O"))
            {
                sql = @"UPDATE orders SET statusType = @STATUS WHERE orderID = @ID";
            }
            else if (ItemID.StartsWith("CO"))
            {
                sql = @"UPDATE customorders SET statusType = @STATUS WHERE corderID = @ID";
            }
            else if (ItemID.StartsWith("MR"))
            {
                sql = @"UPDATE materialRequest SET statusType = @STATUS WHERE mrID = @ID";
            }
            MySqlParameter[] parameters = { new MySqlParameter("@STATUS", statusID), new MySqlParameter("@ID", ItemID) } ;
            int rows = DbConnect.Execute(sql, parameters);
            if (rows > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
