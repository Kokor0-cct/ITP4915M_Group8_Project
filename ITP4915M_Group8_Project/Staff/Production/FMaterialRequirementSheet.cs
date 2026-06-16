using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using ScottPlot.MultiplotLayouts;
using System.Data;
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

                string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(mrID,3) AS UNSIGNED)) FROM materialrequest;";
                int maxfID = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
                string newfID = $"MR{maxfID:D8}";

                string insertSql = @"INSERT INTO materialrequest(mrID, materialCode, mrQuantity,UrgencyLevel,createDate,sUserID) VALUES(@mrID, @materialCode, @mrQuantity, @UrgencyLevel, @createDate, @sUserID)";

                foreach (var sheet in allSheets)
                {
                    string sqlMcode = "SELECT materialCode FROM material WHERE mName = '" + sheet.SelectedMaterialName + "'";
                    DataTable dt = DbConnect.Query(sqlMcode);

                    string mCode = dt.Rows[0]["materialCode"].ToString();
                    int qty = sheet.RequireQuantity;
                    string Level = cmbLevel.SelectedItem.ToString();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string sUserID = UserSession.StaffId;


                    MySqlParameter[] parameters = {
                    new MySqlParameter("@mrID", newfID),
                    new MySqlParameter("@materialCode",mCode),
                    new MySqlParameter("@mrQuantity", qty),
                    new MySqlParameter("@UrgencyLevel", Level),
                    new MySqlParameter("@createDate", DateTime.Now),
                    new MySqlParameter("@sUserID", UserSession.StaffId)};

                    int rows = DbConnect.Execute(insertSql, parameters);


                }


                MessageBox.Show("所有物料需求提交成功！");
                fpMaterialRequirement.Controls.Clear(); // 提交完成清空所有表单

            }
            catch (Exception ex)
            {
                MessageBox.Show("提交失败，已撤销全部数据：" + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
