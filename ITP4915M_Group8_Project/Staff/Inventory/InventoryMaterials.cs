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
                txtPricePerUnit.Text = row.Cells["PerUnitPrice"].Value.ToString();
                txtsupplier.Text = row.Cells["supplier"].Value.ToString();

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
            if (MessageBox.Show("Are you sure you want to insert this data？", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(materialCode,2) AS UNSIGNED)) FROM material;";
            int maxMcode = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
            string newMcode = $"M{maxMcode:D4}";


            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();
            int PricePerUnit = int.Parse(txtPricePerUnit.Text.Trim());
            string supplier = txtsupplier.Text.Trim();

            string sql = @"SELECT mName FROM material WHERE mName LIKE @name";
            MySqlParameter parameter = new MySqlParameter("@name", name);
            DataTable dt = DbConnect.Query(sql, parameter);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Material is already in the table! \nReenter a name for a new material");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to insert this data？\n" +
                "Material Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n" +
                "Price Per Unit : " + PricePerUnit + "\n" +
                "Supplier : " + supplier + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }


            sql = @"INSERT INTO material (materialCode, mName, mQuantity, mUnit, PerUnitPrice, supplier)VALUES (@materialCode, @name, @quantity, @unit, @pricePerUnit, @supplier)";

            MySqlParameter[] parameters = {
        new MySqlParameter("@materialCode", newMcode),
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@unit", unit),
        new MySqlParameter("@pricePerUnit", PricePerUnit),
        new MySqlParameter("@supplier", supplier)
    };

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
            if(MessageBox.Show("Are you sure you want to delete this data？", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (dgvmInventoryControl.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete！");
                return;
            }

            string materialCode = Convert.ToString(dgvmInventoryControl.SelectedRows[0].Cells["materialCode"].Value);


            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();
            int PricePerUnit = int.Parse(txtPricePerUnit.Text.Trim());
            string supplier = txtsupplier.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to delete this data？\n" +
                "\nMaterial Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n" +
                "Price Per Unit : " + PricePerUnit + "\n" +
                "Supplier : " + supplier + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);
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
            if(MessageBox.Show("Are you sure you want to update this data？", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }   

            if (currentmaterialCode == "0")
            {
                MessageBox.Show("Please select a row to update！");
                return;
            }

            string name = txtMaterialName.Text.Trim();
            string quantity = txtMaterialQuantity.Text.Trim();
            string unit = txtMaterialUnit.Text.Trim();
            int PricePerUnit = int.Parse(txtPricePerUnit.Text.Trim());
            string supplier = txtsupplier.Text.Trim();


            DialogResult result = MessageBox.Show("Are you sure you want to update this data？\n" +
                "\nMaterial Name : " + name + "\n" +
                "Material Quantity : " + quantity + "\n" +
                "Material Unit : " + unit + "\n" +
                "Price Per Unit : " + PricePerUnit + "\n" +
                "Supplier : " + supplier + "\n\n", "Are you sure?", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }


            string sql = @"UPDATE material SET mName = @name, mQuantity = @quantity, mUnit = @unit, PerUnitPrice = @pricePerUnit, supplier = @supplier WHERE materialCode = @materialCode";

            MySqlParameter[] parameters = {
        new MySqlParameter("@name", name),
        new MySqlParameter("@quantity", quantity),
        new MySqlParameter("@unit", unit),
        new MySqlParameter("@pricePerUnit", PricePerUnit),
        new MySqlParameter("@supplier", supplier),
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
            this.Close();
        }
    }
}
