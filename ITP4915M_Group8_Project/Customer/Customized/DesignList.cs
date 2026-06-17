using ITP4915M_Group8_Project.Customer;
using ITP4915M_Group8_Project.Customer.Customized;
using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_Group8_Project.Customer.Customized
{
    public partial class DesignList : Form
    {

        string currentCFid = "0";
        public DesignList()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM customfurniture WHERE cUserID = @cUserID AND cfState = @cfState";
            string cUserID = UserSession.CustomerId;
            MySqlParameter[] parameters = {
                new MySqlParameter("@cUserID", cUserID),
                new MySqlParameter("@cfState", "Pending approval")
            };
            DataTable dt = DbConnect.Query(sql, parameters);
            dgvfInventoryControl.DataSource = dt;
        }


        private void dgvfInventoryControl_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvfInventoryControl.CurrentRow == null || dgvfInventoryControl.CurrentRow.Index < 0)
                return;
            DataGridViewRow row = dgvfInventoryControl.CurrentRow;


            txtFurnitureName.Text = Convert.ToString(row.Cells["cfName"].Value);
            txtFurnitureState.Text = Convert.ToString(row.Cells["cfState"].Value);
            txtFurnitureType.Text = Convert.ToString(row.Cells["fType"].Value);
            txtFurniturePrice.Text = Convert.ToString(row.Cells["cfprice"].Value);
            txtFurnitureDesc.Text = Convert.ToString(row.Cells["cfDesc"].Value);
            currentCFid = Convert.ToString(row.Cells["cfID"].Value);

        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            if (currentCFid == "0")
            {
                MessageBox.Show("Please select a row to update！");
                return;
            }

            string sql = @"UPDATE customfurniture SET cfState = @cfState WHERE cfID = @CFID";

            MySqlParameter[] parameters = {
            new MySqlParameter("@cfState", "Design completed"),
            new MySqlParameter("@CFID", currentCFid)
             };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Update successful！");
                LoadDataToGridView();
                currentCFid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！");
            }

        }

        private void btnNotAccepted_Click(object sender, EventArgs e)
        {
            if (currentCFid == "0")
            {
                MessageBox.Show("Please select a row to update！");
                return;
            }

            string sql = @"UPDATE customfurniture SET cfState = @cfState WHERE cfID = @CFID";

            MySqlParameter[] parameters = {
            new MySqlParameter("@cfState", "Design pending"),
            new MySqlParameter("@CFID", currentCFid)
             };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Update successful！");
                LoadDataToGridView();
                currentCFid = "0";
            }
            else
            {
                MessageBox.Show("Update failed！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentCFid == "0")
            {
                MessageBox.Show("Please select a row to Cancel！");
                return;
            }

            string sql = @"DELETE FROM customfurniture WHERE cfID = @CFID";

            MySqlParameter[] parameters = {
            new MySqlParameter("@CFID", currentCFid)
             };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Cancel successful！");
                LoadDataToGridView();
                currentCFid = "0";
            }
            else
            {
                MessageBox.Show("Cancel failed！");
            }
        }

        private void btnfRefresh_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}

