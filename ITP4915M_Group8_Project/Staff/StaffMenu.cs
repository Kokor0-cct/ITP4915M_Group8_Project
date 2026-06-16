using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff;
using ITP4915M_Group8_Project.Staff.Inventory;
using ITP4915M_Group8_Project.Staff.Production;
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



namespace ITP4915M_Group8_Project.Staff
{
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
            StaffMenu_Load();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            Staff.Inventory.InventoryMenu Form = new Staff.Inventory.InventoryMenu();
            Form.Show();
            this.Hide();

        }

        private void btnSalesService_Click(object sender, EventArgs e)
        {
            Staff.Sales.CustomerService Form = new Staff.Sales.CustomerService();
            Form.Show();
            this.Hide();
        }

        private void btnSalesOrderEdit_Click(object sender, EventArgs e)
        {
            Staff.Sales.EditOrder Form = new Staff.Sales.EditOrder();
            Form.Show();
            this.Hide();
        }

        private void btnLogistic_Click(object sender, EventArgs e)
        {
            Staff.Logistic.Logistics_Control Form = new Staff.Logistic.Logistics_Control();
            Form.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Staff.ViewOrder Form = new Staff.ViewOrder();
            Form.Show();
            this.Hide();
        }
        private void StaffMenu_Load()
        {
            List<Button> salesBtns = new List<Button>() { btnSalesService, btnSalesOrderEdit, btnSalesReport };
            List<Button> productionBtns = new List<Button>() { btnProductionList, btnProductionMaterlalSheet };
            List<Button> inventoryBtns = new List<Button>() { btnInventoryManagement, btnInventoryMaterlalList };
            List<Button> logisticBtns = new List<Button>() { btnLogistic };
            List<Button> designBtns = new List<Button>() { btnDesign };

            Action<List<Button>> DisableAll = (btns) =>
            {
                foreach (var btn in btns) btn.Enabled = false;
            };
            DisableAll(salesBtns);
            DisableAll(productionBtns);
            DisableAll(inventoryBtns);
            DisableAll(logisticBtns);
            DisableAll(designBtns);

            if (UserSession.StaffDepartment == "D01") // Admin login
            {
                Action<List<Button>> EnableAll = (btns) =>
                {
                    foreach (var btn in btns) btn.Enabled = true;
                };
                EnableAll(salesBtns);
                EnableAll(productionBtns);
                EnableAll(inventoryBtns);
                EnableAll(logisticBtns);
                EnableAll(designBtns);
            }
            else
            {
                switch (UserSession.StaffDepartment)
                {
                    case "D02":   // Sales Login
                        salesBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "D03": // Production Login
                        productionBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "D04": // Inventory Login
                        inventoryBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "D05": // Logistic Login
                        logisticBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "D06": // Design Login
                        designBtns.ForEach(x => x.Enabled = true);
                        break;
                }
            }

            String sql = @"SELECT deptName FROM Department WHERE deptcode = @CODE";
            MySqlParameter parameter = new MySqlParameter("@CODE", UserSession.StaffDepartment); // Extract the department name from table Department
            DataTable dt = DbConnect.Query(sql, parameter);
            String deptName = dt.Rows[0]["deptName"].ToString();

            lblWelcome.Text = $"Hi, {UserSession.StaffName} from department: {deptName}";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login.CustomerLogIn Form = new Login.CustomerLogIn();
            Form.Show();
            this.Close();
        }

        private void btnProductionMaterlalSheet_Click(object sender, EventArgs e)
        {
            Production.FMaterialRequirementSheet Form = new Production.FMaterialRequirementSheet();
            Form.Show();
            this.Close(); 
        }
    }
}
