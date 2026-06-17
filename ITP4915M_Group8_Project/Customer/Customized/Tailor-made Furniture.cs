using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using Microsoft.VisualBasic;
using MySqlConnector;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ITP4915M_Group8_Project.Customer.Customized
{
    public partial class Tailor_made_Furniture : Form
    {
        public Tailor_made_Furniture()
        {
            InitializeComponent();
            cmbType.Items.Clear();
            cmbType.Items.Add("Table");
            cmbType.Items.Add("Chair");
            cmbType.Items.Add("Sofa");
            cmbType.Items.Add("Wardrobe");
            cmbType.Items.Add("Shelf");
            cmbType.Items.Add("Bed");

            cmbType.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        public void ClearTextBox()
        {
            txtDescription.Clear();
            cmbType.SelectedIndex = -1;
            numLength.Value = 0;
            numWidth.Value = 0;
            numHeigh.Value = 0;
            numBudget.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (cmbType.SelectedIndex == -1 || txtDescription.Text.Trim() == ""|| numBudget.Value == 0 || numWidth.Value == 0 || numHeigh.Value == 0|| txtDescription.Text.Trim() == "Please enter your desired customized product information here.")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(cfrID,4) AS UNSIGNED)) FROM customfurniturerequest;";
            int maxcfrID = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;

            string newcfrID = $"CFR{maxcfrID:D5}";
            string Budget = numBudget.Value.ToString();
            string desc = txtDescription.Text.Trim()+ $"\nSize: L={numLength.Value},W={numWidth.Value},H={numHeigh.Value}";
            string cUserID = UserSession.CustomerId;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string type="";

            if (cmbType.SelectedItem.ToString() == "Table")
            {
                type += "FT01";
            }
            else if (cmbType.SelectedItem.ToString() == "Chair")
            {
                type += "FT02";
            }
            else if (cmbType.SelectedItem.ToString() == "Sofa")
            {
                type += "FT03";
            }
            else if (cmbType.SelectedItem.ToString() == "Wardrobe")
            {
                type += "FT04";
            }
            else if (cmbType.SelectedItem.ToString() == "Shelf")
            {
                type += "FT05";
            }
            else if (cmbType.SelectedItem.ToString() == "Bed")
            {
                type += "FT06";
            }


            string sql = @"INSERT INTO customfurniturerequest(cfrID, cUserID, fType, cfrBudget, cfrDESC, cfrCreateDate) VALUES(@cfrID, @cUserID, @fType, @cfrBudget, @cfrDESC, @cfrCreateDate)
";

            MySqlParameter[] parameters = {
        new MySqlParameter("@cfrID", newcfrID),
        new MySqlParameter("@cUserID", cUserID),
        new MySqlParameter("@fType", type),
        new MySqlParameter("@cfrBudget", Budget),
        new MySqlParameter("@cfrDESC", desc),
        new MySqlParameter("@cfrCreateDate", date)};

            int rows = DbConnect.Execute(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show("Added successfully！");
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Failed to add！");
            }
        }
    }
}
