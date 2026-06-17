using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer.Customized
{
    public partial class Customized_Menu : Form
    {
        public Customized_Menu()
        {
            InitializeComponent();

        }

        private void btnCustomized_Click(object sender, EventArgs e)
        {
            Tailor_made_Furniture tailor_Made_Furniture = new Tailor_made_Furniture();
            tailor_Made_Furniture.ShowDialog();
        }

        private void btnDesignList_Click(object sender, EventArgs e)
        {
            DesignList designList = new DesignList();
            designList.ShowDialog();
        }
    }
}
