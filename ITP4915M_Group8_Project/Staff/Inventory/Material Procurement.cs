using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Production;
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

namespace ITP4915M_Group8_Project.Staff.Inventory
{
    public partial class Material_Procurement : Form
    {
        public Material_Procurement()
        {
            InitializeComponent();

            cmbProductionSite.Items.Clear();
            cmbProductionSite.Items.Add("Production Site 1");
            cmbProductionSite.Items.Add("Production Site 2");
            cmbProductionSite.Items.Add("Production Site 3");
            cmbProductionSite.SelectedIndex = 0;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string Rdate = DateTime.Parse(dateRequired.Text.Trim()).ToString("M/dd/yyyy");

            if (fpMaterialRequirement.Controls.Count == 0)
            {
                MessageBox.Show("Please add at least one material requirement！");
                return;
            }
            else if (Rdate == null)
            {
                MessageBox.Show("Required Date cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DateTime.Parse(dateRequired.Text) < DateTime.Now.Date)
            {
                MessageBox.Show("Required Date cannot be in the past!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DateTime parsedDate = DateTime.ParseExact(Rdate, "M/dd/yyyy", CultureInfo.InvariantCulture);

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




                foreach (var sheet in allSheets)
                {
                    string sqlMcode = "SELECT materialCode FROM material WHERE mName = '" + sheet.SelectedMaterialName + "'";
                    DataTable dt = DbConnect.Query(sqlMcode);

                    string mCode = dt.Rows[0]["materialCode"].ToString();

                    int qty = sheet.RequireQuantity;

                    string sqlinsert = @"INSERT INTO materialreport (mid,qty) VALUES (@mid, @qty)";
                    MySqlParameter[] paramReport = {
                        new MySqlParameter("@mid", mCode),
                        new MySqlParameter("@qty", qty)
                    };
                    int reportAffect = DbConnect.Execute(sqlinsert, paramReport);


                    fpMaterialRequirement.Controls.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed submission，all data has been withdrawn：" + ex.Message);
            }

            MessageBox.Show("Material Request Submitted！");

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
