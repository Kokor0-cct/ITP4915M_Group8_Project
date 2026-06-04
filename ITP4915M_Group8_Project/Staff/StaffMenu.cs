using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using ITP4915M_Group8_Project.Staff.Logistic;
using ITP4915M_Group8_Project.Staff.Sales;
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

        }

        private void btnSalesService_Click(object sender, EventArgs e)
        {
            Staff.Sales.CustomerService Form = new Staff.Sales.CustomerService();
            Form.Show();
        }

        private void btnSalesOrderEdit_Click(object sender, EventArgs e)
        {
            //Staff.Sales.OderInfrommationEdit Form = new Staff.Sales.OderInfrommationEdit();
            //Form.Show();
        }

        private void btnLogistic_Click(object sender, EventArgs e)
        {
            Staff.Logistic.Logistics_Control Form = new Staff.Logistic.Logistics_Control();
            Form.Show();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Staff.ViewOrder Form = new Staff.ViewOrder();
            Form.Show();
        }
        private void StaffMenu_Load()
        {
            // 1.先把所有部门按钮全部存到对应分组
            List<Button> salesBtns = new List<Button>() { btnSalesService, btnSalesOrderEdit, btnSalesReport };
            List<Button> productionBtns = new List<Button>() { btnProductionList, btnProductionMaterlalSheet };
            List<Button> inventoryBtns = new List<Button>() { btnInventoryManagement, btnInventoryMaterlalList };
            List<Button> logisticBtns = new List<Button>() { btnLogistic };
            List<Button> designBtns = new List<Button>() { btnDesign };

            // 2.默认：全部按钮禁用
            Action<List<Button>> DisableAll = (btns) =>
            {
                foreach (var btn in btns) btn.Enabled = false;
            };
            DisableAll(salesBtns);
            DisableAll(productionBtns);
            DisableAll(inventoryBtns);
            DisableAll(logisticBtns);
            DisableAll(designBtns);

            // 3.判断：管理员 → 全部启用
            if (UserSession.StaffDepartment == "Admin")
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
                    case "Sales":
                        salesBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "Production":
                        productionBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "Inventory":
                        inventoryBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "Logistic":
                        logisticBtns.ForEach(x => x.Enabled = true);
                        break;
                    case "Design":
                        designBtns.ForEach(x => x.Enabled = true);
                        break;
                }
            }

            lblWelcome.Text = $"Hi, {UserSession.StaffName}, department:{UserSession.StaffDepartment}";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login.CustomerLogIn Form = new Login.CustomerLogIn();
            Form.Show();
            this.Hide();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
