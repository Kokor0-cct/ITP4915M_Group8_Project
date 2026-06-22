using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using ScottPlot.MultiplotLayouts;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ITP4915M_Group8_Project.Staff.Production
{
    public partial class FMaterialRequirementSheet : Form
    {
        public FMaterialRequirementSheet()
        {
            InitializeComponent();
            cmbLevel.Items.Clear();
            cmbLevel.Items.Add("Low");
            cmbLevel.Items.Add("Medium");
            cmbLevel.Items.Add("High");
            cmbLevel.SelectedIndex = 0;
            cmbProductionSite.Items.Clear();
            cmbProductionSite.Items.Add("Production Site 1");
            cmbProductionSite.Items.Add("Production Site 2");
            cmbProductionSite.Items.Add("Production Site 3");
            cmbProductionSite.SelectedIndex = 0;
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





        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            String Rdate = txtRequiredDate.Text.Trim();

            if (fpMaterialRequirement.Controls.Count == 0)
            {
                MessageBox.Show("Please add at least one material requirement！");
                return;
            }else if (Rdate == null)
            {
                MessageBox.Show("Required Date cannot be left empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(mrID,3) AS UNSIGNED)) FROM materialrequest;";
                int maxfID = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
                string newfID = $"MR{maxfID:D8}";
                DateTime parsedDate = DateTime.ParseExact(Rdate, "M/dd/yyyy", CultureInfo.InvariantCulture);

                string insertSql = @"INSERT INTO materialrequest(mrID, sUserID, materialCode, mrQuantity, UrgencyLevel, RequiredDate, mrdeliveryaddress) VALUES(@mrID, @sUserID, @materialCode, @mrQuantity, @UrgencyLevel, @RequiredDate, @MRDA)";

                foreach (var sheet in allSheets)
                {
                    string sqlMcode = "SELECT materialCode FROM material WHERE mName = '" + sheet.SelectedMaterialName + "'";
                    DataTable dt = DbConnect.Query(sqlMcode);

                    string mCode = dt.Rows[0]["materialCode"].ToString();
                    int qty = sheet.RequireQuantity;
                    string Level = cmbLevel.SelectedItem.ToString();
                    string deliveryAddress = cmbProductionSite.SelectedItem.ToString();
                    string sUserID = UserSession.StaffId;


                    MySqlParameter[] parameters = {
                    new MySqlParameter("@mrID", newfID),
                    new MySqlParameter("@sUserID", sUserID),
                    new MySqlParameter("@materialCode",mCode),
                    new MySqlParameter("@mrQuantity", qty),
                    new MySqlParameter("@UrgencyLevel", Level),
                    new MySqlParameter("@RequiredDate", parsedDate), 
                    new MySqlParameter("@MRDA", deliveryAddress)};
                    
                    int rows = DbConnect.Execute(insertSql, parameters);

                }


                MessageBox.Show("Material Request Submitted！");
                fpMaterialRequirement.Controls.Clear(); // 提交完成清空所有表单

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed submission，all data has been withdrawn：" + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
