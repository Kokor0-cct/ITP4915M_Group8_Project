using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
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

namespace ITP4915M_Group8_Project.Staff.Logistic
{
    public partial class CreateNewShippingRequest : Form
    {
        public bool inserted = false;
        //private string updatetable;
        private string itemId;
        private DateTime deliverydate;
        private string collectAddress;
        private string deliveryAddress;
        public CreateNewShippingRequest()
        {
            InitializeComponent();
            inserted = false;
            //updatetable = "";
            //itemId = "";
            //deliverydate = "";
            //collectAddress = "";
            //deliveryAddress = "";
            cmbAddress.Items.Clear();
            if (UserSession.StaffDepartment == "D01" || UserSession.StaffDepartment == "D02")
            {
                cmbAddress.Items.Add("Warehouse 1");
                cmbAddress.Items.Add("Warehouse 2");
                cmbAddress.Items.Add("Warehouse 3");
            }
            if (UserSession.StaffDepartment == "D01" || UserSession.StaffDepartment == "D03")
            {
                cmbAddress.Items.Add("Production Site 1");
                cmbAddress.Items.Add("Production Site 2");
                cmbAddress.Items.Add("Production Site 3");
            }
            if (UserSession.StaffDepartment == "D01" || UserSession.StaffDepartment == "D04")
            {
                cmbAddress.Items.Add("Inventory Site 1");
                cmbAddress.Items.Add("Inventory Site 2");
                cmbAddress.Items.Add("Inventory Site 3");
            }
        }

        

        public void collectShippingDetails(String itemId, DateTime deliverydate, String deliveryAddress)
        {
            //this.updatetable = table;
            this.itemId = itemId;
            this.deliverydate = deliverydate;
            this.deliveryAddress = deliveryAddress;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAddress.Text.Trim() != "")
                {
                    collectAddress = cmbAddress.Text.Trim();
                }else if (cmbAddress.SelectedItem.ToString() != "")
                {
                    collectAddress = cmbAddress.SelectedItem.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter or select a Shipping Address!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            createShippingRequest();
        }

        private void createShippingRequest()
        {
            string sql = "SELECT MAX(CAST(SUBSTRING(SRID,3) AS UNSIGNED)) FROM ShippingRequest";
            int maxSRID = Convert.ToInt32(DbConnect.ExecuteScalar1(sql)) + 1;
            string newSRID = $"SR{maxSRID:D8}";

            sql = "INSERT INTO ShippingRequest (SRID, IID, deliveryDate, collectAddress, deliveryAddress) VALUES (@SRID, @IID, @deliveryDate, @collectAddress, @deliveryAddress)";
            MySqlParameter[] parameters = { 
                new MySqlParameter("@SRID", newSRID), 
                new MySqlParameter("@IID", itemId),
                new MySqlParameter("@deliveryDate", deliverydate), 
                new MySqlParameter("@collectAddress", collectAddress),
                new MySqlParameter("@deliveryAddress", deliveryAddress) };
            int rows = DbConnect.Execute(sql, parameters);
            
            if (rows > 0)
            {
                MessageBox.Show("Shipping Request Created");
                inserted = true;
                Close();
            }
            else
            {
                MessageBox.Show("Creation Failed");
                inserted = false; 
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
