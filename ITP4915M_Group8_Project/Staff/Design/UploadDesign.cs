using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using ITP4915M_Group8_Project.Staff.Production;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ITP4915M_Group8_Project.Staff.Production;

namespace ITP4915M_Group8_Project.Staff.Design
{
    public partial class UploadDesign : Form
    {
        public UploadDesign()
        {
            InitializeComponent();
            LoadDataToGridView();

        }

        private void LoadDataToGridView()
        {
            string sql1 = "SELECT * FROM customfurniturerequest WHERE  Completed = @Completed";
            MySqlParameter[] parameters1 = {
                new MySqlParameter("@Completed","0")//0=false ,1=true
            };
            DataTable dtCFR = DbConnect.Query(sql1, parameters1);
            dgvCFR.DataSource = dtCFR;

            string sql2 = "SELECT * FROM customfurniture WHERE cfState = @cfState";
            MySqlParameter[] parameters2 = {
                new MySqlParameter("@cfState", "Design pending")
            };
            DataTable dtCF = DbConnect.Query(sql2, parameters2);
            dgvCF.DataSource = dtCF;
        }


        private void dgvCFR_CellClick (object sender, EventArgs e)
        {
            if (dgvCFR.CurrentRow == null || dgvCFR.CurrentRow.Index < 0)
                return;

            DataGridViewRow row1 = dgvCFR.CurrentRow;
            txtcfrType.Text = Convert.ToString(row1.Cells["fType"].Value);
            txtcfrBudget.Text = Convert.ToString(row1.Cells["cfrBudget"].Value);
            txtcfrDescription.Text = Convert.ToString(row1.Cells["cfrDESC"].Value);

            ClearTextBoxes();
            txtcfType.Text = Convert.ToString(row1.Cells["fType"].Value);
        }

        private void dgvCF_CellClick(object sender, EventArgs e)
        {
            if (dgvCF.CurrentRow == null || dgvCF.CurrentRow.Index < 0)
                return;

            try
            {
                DataGridViewRow row2 = dgvCF.CurrentRow;
                txtcfName.Text = Convert.ToString(row2.Cells["cfName"].Value);
                txtcfType.Text = Convert.ToString(row2.Cells["fType"].Value);
                numcfPrice.Value = Convert.ToDecimal(row2.Cells["cfprice"].Value);
                txtcfDesc.Text = Convert.ToString(row2.Cells["cfDesc"].Value);
            }catch (Exception ex)
            {
                ClearTextBoxes();
                return;
            }
        }

        private void btnfRefresh_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {

            ClearTextBoxes();
        }
        public void ClearTextBoxes()
        {
            txtcfDesc.Clear();
            txtcfName.Clear();
            numcfPrice.Value = 0;
            txtcfType.Clear();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (dgvCFR.CurrentRow == null || dgvCFR.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a custom furniture request to upload design.");
                return;
            }
            if (txtcfDesc.Text == "" || txtcfName.Text == "" || numcfPrice.Value == 0 || txtcfType.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (fpMaterialRequirement.Controls.Count == 0)
            {
                MessageBox.Show("Please add at least one material requirement！");
                return;
            }

            List<Material_Requirement_Sheet> allSheets = new List<Material_Requirement_Sheet>();
            foreach (Control ctrl in fpMaterialRequirement.Controls)
            {
                if (ctrl is Material_Requirement_Sheet sheet)
                {
                    string matName = sheet.SelectedMaterialName;
                    int qty = sheet.RequireQuantity;
                    if (string.IsNullOrEmpty(matName) || qty <= 0)
                    {
                        MessageBox.Show("There are entries without selected materials or invalid quantities. Please check！");
                        return;
                    }
                    allSheets.Add(sheet);
                }
            }
            try
            {

                string sqlMaxcmId = "SELECT MAX(CAST(SUBSTRING(cfID,3) AS UNSIGNED)) FROM customfurniture;";
                int maxfID = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxcmId)) + 1;
                string newfID = $"CF{maxfID:D6}";

                string insertSql = @"INSERT INTO customrequestmaterials(cfrID, mid, pmqty) VALUES(@cfid, @materialCode, @mrQuantity)";

                foreach (var sheet in allSheets)
                {
                    string sqlMcode = "SELECT materialCode FROM material WHERE mName = '" + sheet.SelectedMaterialName + "'";
                    DataTable dt = DbConnect.Query(sqlMcode);

                    string mCode = dt.Rows[0]["materialCode"].ToString();
                    int qty = sheet.RequireQuantity;


                    MySqlParameter[] parameters23 = {
                    new MySqlParameter("@cfid", newfID),
                    new MySqlParameter("@materialCode",mCode),
                    new MySqlParameter("@mrQuantity", qty),
                    };
                    int ds = DbConnect.Execute(insertSql, parameters23);

                }

                fpMaterialRequirement.Controls.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed submission，all data has been withdrawn：" + ex.Message);
            }


            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(cfID,3) AS UNSIGNED)) FROM customfurniture;";
            int maxCFID = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
            string newCFID = $"CF{maxCFID:D6}";

            string CFID = newCFID;
            string name = txtcfName.Text.Trim();
            string type = txtcfType.Text.Trim();
            string price = numcfPrice.Value.ToString();
            string desc = txtcfDesc.Text.Trim();
            string cfrID = Convert.ToString(dgvCFR.CurrentRow.Cells["cfrID"].Value);
            string cUserID = Convert.ToString(dgvCFR.CurrentRow.Cells["cUserID"].Value);
            string cfstate = "Pending approval";

            DialogResult result = MessageBox.Show("Are you sure you want to insert this data？\n" +
                "Furniture ID : " + CFID + "\n" +
                "Customer ID : " + cUserID + "\n" +
                "Customize Request ID : " + cfrID + "\n" +
                "Furniture Name : " + name + "\n" +
                "Furniture Type : " + type + "\n" +
                "Furniture Price : " + price + "\n" +
                "Furniture Description : " + desc + "\n" +
                "State : " + cfstate + "\n" + "\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string CF_Upload_sql = @"INSERT INTO customfurniture (cfID,cUserID, cfrID, cfName, fType, cfprice,cfDesc,cfState)VALUES (@cfID, @cUserID, @cfrID, @cfName, @fType, @cfprice, @cfDesc, @cfState)";
            string CF_StateUpdate_sql = @"UPDATE customfurniturerequest SET Completed = @Completed WHERE cfrID = @cfrID";

            MySqlParameter[] parameters_1 = {
                new MySqlParameter("@cfID", CFID),
                new MySqlParameter("@cUserID", cUserID),
                new MySqlParameter("@cfrID", cfrID),
                new MySqlParameter("@cfName", name),
                new MySqlParameter("@fType", type),
                new MySqlParameter("@cfprice", price),
                new MySqlParameter("@cfDesc", desc),
                new MySqlParameter("@cfState", cfstate)};

            MySqlParameter[] parameters_2 = {
                new MySqlParameter("@cfrID", cfrID),
                new MySqlParameter("@Completed", 1)};


            int rows = DbConnect.Execute(CF_Upload_sql, parameters_1);

            if (rows > 0)
            {
                DbConnect.Execute(CF_StateUpdate_sql, parameters_2);
                MessageBox.Show("Added successfully！");
                LoadDataToGridView();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Failed to add！");
            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCF.CurrentRow == null || dgvCF.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a custom furniture to upload design.");
                return;
            }
            if (txtcfDesc.Text == "" || txtcfName.Text == "" || numcfPrice.Value == 0 || txtcfType.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (fpMaterialRequirement.Controls.Count == 0)
            {
                MessageBox.Show("Please add at least one material requirement！");
                return;
            }

            string CFID = Convert.ToString(dgvCF.CurrentRow.Cells["cfID"].Value); ;
            string name = txtcfName.Text.Trim();
            string type = txtcfType.Text.Trim();
            string price = numcfPrice.Value.ToString();
            string desc = txtcfDesc.Text.Trim();
            string cfrID = Convert.ToString(dgvCF.CurrentRow.Cells["cfrID"].Value);
            string cUserID = Convert.ToString(dgvCF.CurrentRow.Cells["cUserID"].Value);
            string cfstate = "Pending approval";

            DialogResult result = MessageBox.Show("Are you sure you want to Update this data？\n" +
                "Furniture ID : " + CFID + "\n" +
                "Customer ID : " + cUserID + "\n" +
                "Customize Request ID : " + cfrID + "\n" +
                "Furniture Name : " + name + "\n" +
                "Furniture Type : " + type + "\n" +
                "Furniture Price : " + price + "\n" +
                "Furniture Description : " + desc + "\n" +
                "State : " + cfstate + "\n" + "\n", "Are you sure?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string CF_Upload_sql = @"UPDATE customfurniture SET  cfName = @cfName,  cfprice = @cfprice, cfDesc = @cfDesc, cfState = @cfState WHERE cfID = @cfID";

            MySqlParameter[] parameters_1 = {
                new MySqlParameter("@cfID", CFID),
                new MySqlParameter("@cfName", name),
                new MySqlParameter("@cfprice", price),
                new MySqlParameter("@cfDesc", desc),
                new MySqlParameter("@cfState", cfstate)};



            int rows = DbConnect.Execute(CF_Upload_sql, parameters_1);

            if (rows > 0)
            {
                MessageBox.Show("Updated successfully！");
                LoadDataToGridView();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Failed to add！");
            }
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnADDMaterialRequirement_Click(object sender, EventArgs e)
        {
            fpMaterialRequirement.Controls.Add(new Material_Requirement_Sheet());

        }

        private void btndeleteMaterialRequirement_Click(object sender, EventArgs e)
        {
            if (fpMaterialRequirement.Controls.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No more material requirement sheet to delete.");
                return;
            }

            fpMaterialRequirement.Controls.RemoveAt(fpMaterialRequirement.Controls.Count - 1);
        }
    }
}
 
    
