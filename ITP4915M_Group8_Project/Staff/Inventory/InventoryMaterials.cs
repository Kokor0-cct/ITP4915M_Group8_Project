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

namespace ITP4915M_Group8_Project.Staff.Inventory
{

    public partial class InventoryMaterials : Form
    {
        private string currentmaterialCode = "0";


        public InventoryMaterials()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        //------get data from database and show in datagridview------
        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM material";


            DataTable dt = DbConnect.Query(sql);


            dgvmInventoryControl.DataSource = dt;
        }
        //------get data from database and show in datagridview------


        private void dgvmInventoryControl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvmInventoryControl.Rows[e.RowIndex];

                if (row.IsNewRow)
                {
                    // 清空输入框
                    ClearTextBox();
                    currentmaterialCode = "0";
                    return;
                }
                txtMaterialName.Text = row.Cells["mName"].Value.ToString();
                txtMaterialQuantity.Text = row.Cells["mQuantity"].Value.ToString();
                txtMaterialUnit.Text = row.Cells["mUnit"].Value.ToString();

                currentmaterialCode = Convert.ToString(row.Cells["materialCode"].Value);
            }
        }



        private void btnmSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtmSearch.Text.Trim();


            string sql = "SELECT * FROM material WHERE mName LIKE @keyword";

            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvmInventoryControl.DataSource = dt;
        }

        private void btnmInsertFurniture_Click(object sender, EventArgs e)
        {
            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to insert this data？\n" +
                "Material Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string sql = @"INSERT INTO material (mName, mQuantity, mUnit)VALUES (@name, @quantity, @unit)";

            MySqlParameter[] parameters = {
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@unit", unit)};

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

        private void ClearTextBox()
        {
            txtMaterialName.Clear();
            txtMaterialQuantity.Clear();
            txtMaterialUnit.Clear();
        }

        private void btnmDeleteFurniture_Click(object sender, EventArgs e)
        {
            if (dgvmInventoryControl.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete！");
                return;
            }

            int materialCode = Convert.ToInt32(dgvmInventoryControl.SelectedRows[0].Cells["materialCode"].Value);


            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to delete this data？\n" +
                "\nMaterial Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM material WHERE materialCode = @materialCode";


            MySqlParameter[] parameters = {
        new MySqlParameter("@materialCode",materialCode)
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

        private void btnmRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM material";
            DataTable dt = DbConnect.Query(sql);
            dgvmInventoryControl.DataSource = dt;
            txtmSearch.Clear();
        }

        private void btnmUpdateFurniture_Click(object sender, EventArgs e)
        {
            if (currentmaterialCode == "0")
            {
                MessageBox.Show("Please select a row to update！");
                return;
            }

            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to update this data？\n" +
                "\nMaterial Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }


            string sql = @"UPDATE material SET mName = @name, mQuantity = @quantity, mUnit = @unit WHERE materialCode = @materialCode";

            MySqlParameter[] parameters = {
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@unit", unit),
        new MySqlParameter("@materialCode", currentmaterialCode)

    };

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Update successful！");
                LoadDataToGridView();
                ClearTextBox();
                currentmaterialCode = "0";
            }
            else
            {
                MessageBox.Show("Update failed！");
            }
        }

        private void btnmClearTextBox_Click(object sender, EventArgs e)
        {
            txtMaterialName.Clear();
            txtMaterialQuantity.Clear();
            txtMaterialUnit.Clear();
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryMenu menu = new InventoryMenu();
            menu.Show();
            this.Close();
        }
    }
}
