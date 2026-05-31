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
    public partial class InventoryFurniture : Form

    {
        private int currentFid = 0;


        public InventoryFurniture()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------
        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM furniture";


            DataTable dt = DbConnect.Query(sql);


            dgvfInventoryControl.DataSource = dt;
        }
        //------get data from database and show in datagridview------


        //------search the textboxes text item in database------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtfSearch.Text.Trim();


            string sql = "SELECT * FROM furniture WHERE fName LIKE @keyword";

            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvfInventoryControl.DataSource = dt;
        }
        //------search the textboxes text item in database------



        //------Refresh form to show database data ------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM furniture";
            DataTable dt = DbConnect.Query(sql);
            dgvfInventoryControl.DataSource = dt;
            txtfSearch.Clear();
        }
        //------Refresh form to show database data ------


        //------Insert Furniture  to  database  ------
        private void btnInsertFurniture_Click(object sender, EventArgs e)
        {
            string name = txtFurnitureName.Text.Trim();
            string quantity = txtFurnitureQuantity.Text.Trim();
            string type = txtFurnitureType.Text.Trim();
            string price = txtFurniturePrice.Text.Trim();
            string desc = txtFurnitureDesc.Text.Trim();

            DialogResult result = MessageBox.Show("Are you sure you want to insert this data？\n" +
                "Furniture Name : " + name + "\n" +
                "Furniture Quantity : " + quantity + "\n" +
                "Furniture Type : " + type + "\n" +
                "Furniture Price : " + price + "\n" +
                "Furniture Description : " + desc + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string sql = @"INSERT INTO furniture (fName, fQuantity, fType, fPrice, fDesc)VALUES (@name, @quantity, @type, @price, @desc)";

            MySqlParameter[] parameters = {
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@type", type),
        new MySqlParameter("@price", price),
        new MySqlParameter("@desc", desc)};

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Added successfully！");
                LoadDataToGridView();
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Failed to add！");
            }
        }
        //------Insert Furniture  to  database  ------

        //------Delete Furniture  in  database  ------

        private void btnDeleteFurniture_Click(object sender, EventArgs e)
        {

            if (dgvfInventoryControl.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete！");
                return;
            }

            int fid = Convert.ToInt32(dgvfInventoryControl.SelectedRows[0].Cells["fID"].Value);


            string name = txtFurnitureName.Text.Trim();
            string quantity = txtFurnitureQuantity.Text.Trim();
            string type = txtFurnitureType.Text.Trim();
            string price = txtFurniturePrice.Text.Trim();
            string desc = txtFurnitureDesc.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to delete this data？\n" +
                "\nFurniture Name : " + name + "\n" +
                "Furniture Quantity : " + quantity + "\n" +
                "Furniture Type : " + type + "\n" +
                "Furniture Price : " + price + "\n" +
                "Furniture Description : " + desc + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM furniture WHERE fID = @fID";


            MySqlParameter[] parameters = {
        new MySqlParameter("@fID", fid)
    };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Deleted successfully！");
                LoadDataToGridView();
            }
            else
            {
                MessageBox.Show("Failed to delete！");
            }
        }
        //------Delete Furniture  in  database  ------

        //------Update Furniture  in  database  ------
        private void dgvInventoryControl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvfInventoryControl.Rows[e.RowIndex];

                if (row.IsNewRow)
                {
                    // 清空输入框
                    ClearTextBox();
                    currentFid = 0;
                    return;
                }
                txtFurnitureName.Text = row.Cells["fName"].Value.ToString();
                txtFurnitureQuantity.Text = row.Cells["fQuantity"].Value.ToString();
                txtFurnitureType.Text = row.Cells["fType"].Value.ToString();
                txtFurniturePrice.Text = row.Cells["fPrice"].Value.ToString();
                txtFurnitureDesc.Text = row.Cells["fDesc"].Value.ToString();

                currentFid = Convert.ToInt32(row.Cells["FID"].Value);
            }
        }

        private void btnUpdateFurniture_Click(object sender, EventArgs e)
        {
            if (currentFid == 0)
            {
                MessageBox.Show("Please select a row to update！");
                return;
            }

            string name = txtFurnitureName.Text.Trim();
            string quantity = txtFurnitureQuantity.Text.Trim();
            string type = txtFurnitureType.Text.Trim();
            string price = txtFurniturePrice.Text.Trim();
            string desc = txtFurnitureDesc.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to update this data？\n" +
                "\nFurniture Name : " + name + "\n" +
                "Furniture Quantity : " + quantity + "\n" +
                "Furniture Type : " + type + "\n" +
                "Furniture Price : " + price + "\n" +
                "Furniture Description : " + desc + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            
            if (result != DialogResult.Yes)
            {
                return;
            }
            

            string sql = @"UPDATE furniture SET fName = @name, fQuantity = @quantity, fType = @type, fPrice = @price, fDesc = @desc WHERE FID = @FID";

            MySqlParameter[] parameters = {
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@type", type),
        new MySqlParameter("@price", price),
        new MySqlParameter("@desc", desc),
        new MySqlParameter("@FID", currentFid)
    };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Update successful！");
                LoadDataToGridView();
                ClearTextBox();
                currentFid = 0;
            }
            else
            {
                MessageBox.Show("Update failed！");
            }
        }
        //------Update Furniture  in  database  ------

        //------Clear TextBox  ------
        private void ClearTextBox()
        {
            txtFurnitureName.Clear();
            txtFurnitureQuantity.Clear();
            txtFurnitureType.Clear();
            txtFurniturePrice.Clear();
            txtFurnitureDesc.Clear();
        }//------Clear TextBox  ------

        private void btnClearTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
