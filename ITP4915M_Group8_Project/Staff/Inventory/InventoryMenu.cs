using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M_Group8_Project;

namespace ITP4915M_Group8_Project.Staff.Inventory
{
    public partial class InventoryMenu : Form
    {
        public InventoryMenu()
        {
            InitializeComponent();

        }

        private void btnToFurniture_Click(object sender, EventArgs e)
        {
            Staff.Inventory.InventoryFurniture Form = new Staff.Inventory.InventoryFurniture();
            Form.Show();
            this.Close();
        }

        private void btnToMaterial_Click(object sender, EventArgs e)
        {
            Staff.Inventory.InventoryMaterials Form = new Staff.Inventory.InventoryMaterials();
            Form.Show();
            this.Close();
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffMenu menu = new StaffMenu();
            menu.Show();
            this.Close();
        }
    }
}
