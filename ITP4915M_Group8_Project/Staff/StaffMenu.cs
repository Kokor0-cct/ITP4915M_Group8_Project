using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M_Group8_Project.Staff.Inventory;
using ITP4915M_Group8_Project.Staff.Sales;
using ITP4915M_Group8_Project.Staff.Logistic;

namespace ITP4915M_Group8_Project.Staff
{
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
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
            Staff.Sales.OderInfrommationEdit Form = new Staff.Sales.OderInfrommationEdit();
            Form.Show();
        }

        private void btnLogistic_Click(object sender, EventArgs e)
        {
            Staff.Logistic.Logistics_Control Form = new Staff.Logistic.Logistics_Control();
            Form.Show();
        }
    }
}
