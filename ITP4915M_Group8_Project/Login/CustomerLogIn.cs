using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
 

namespace ITP4915M_Group8_Project.Login
{
    public partial class CustomerLogIn : Form
    {
        CustomerClass1 customerLogin = new CustomerClass1 ();
        public CustomerLogIn()
        {
            InitializeComponent();

            cboBoxIdentity.Items.Clear();
            cboBoxIdentity.Items.Add("Customer");
            cboBoxIdentity.Items.Add("Staff");
            cboBoxIdentity.SelectedIndex = 0; 
        }

        private void cboBoxIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxIdentity.SelectedItem == null) return;

            string selectedType = cboBoxIdentity.SelectedItem.ToString();

            textBox_UserName.Clear();
            textBox_password.Clear();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (cboBoxIdentity.SelectedItem == null)
            {
                MessageBox.Show("Please select login role. (Customer/Staff)", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string uname = textBox_UserName.Text;
            string pass = textBox_password.Text;
            string isStaffValue = cboBoxIdentity.SelectedItem.ToString();

            try
            {
                if (isStaffValue == "Staff")
                {

                    string query = "SELECT * FROM `staff` WHERE `sName` = @sName AND `sPassword` = @sPassword ";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Parameters.AddWithValue("@sName", uname);
                    cmd.Parameters.AddWithValue("@sPassword", pass);

                    DataTable table = customerLogin.getlist(cmd);

                    if (table.Rows.Count > 0)
                    {
       
                        string welcomeMessage = $"Welcome Staff, {uname}!";
                        MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                        DataTable dt = DbUserConnect.GetStaffinfo(uname);
               

                        UserSession.StaffName = Convert.ToString(dt.Rows[0]["sName"]);
                        UserSession.StaffPhone = Convert.ToString(dt.Rows[0]["sPhone"]);
                        UserSession.StaffPassword = Convert.ToString(dt.Rows[0]["sPassword"]);
                        UserSession.StaffDepartment = Convert.ToString(dt.Rows[0]["DeptCode"]);
                        UserSession.StaffId = Convert.ToString(dt.Rows[0]["sUserID"]);

                        Staff.StaffMenu Form = new Staff.StaffMenu();
                        Form.Show();
                        this.Close();
                        textBox_password.Clear();
                        textBox_UserName.Clear();
                    }
                    else
                    {
                        string errorMessage = "Staff name or password incorrect!";
                           
                        MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBox_password.Clear();
                        textBox_password.Focus();
                    }
                }
                else if (isStaffValue == "Customer")
                {
                    string query = "SELECT * FROM `customers` WHERE `cName` = @cName AND `cPassword` = @cPassword ";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Parameters.AddWithValue("@cName", uname);
                    cmd.Parameters.AddWithValue("@cPassword", pass);

                    DataTable table = customerLogin.getlist(cmd);
                    if (table.Rows.Count > 0)
                    {
                        string welcomeMessage = $"Welcome ! {uname}!";
                        MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        DataTable dt = DbUserConnect.GetCustomerinfo(uname);


                        UserSession.CustomerName = Convert.ToString(dt.Rows[0]["cName"]);
                        UserSession.CustomerPhone = Convert.ToString(dt.Rows[0]["cPhone"]);
                        UserSession.CustomerPassword = Convert.ToString(dt.Rows[0]["cPassword"]);
                        UserSession.CustomerAddress = Convert.ToString(dt.Rows[0]["cAddress"]);
                        UserSession.CustomerId = Convert.ToString(dt.Rows[0]["cUserID"]);
                        UserSession.CustomerBalance = Convert.ToInt32(dt.Rows[0]["cBudget"]);
                        UserSession.CustomerCompany = Convert.ToString(dt.Rows[0]["company"]);

                        Customer.CustomerMenu buyForm = new Customer.CustomerMenu();
                        buyForm.Show();
                        textBox_password.Clear();
                        textBox_UserName.Clear();
                        this.Close();

                    }
                    else
                    {
                        string errorMessage = "Customer name or password incorrect!";
                        MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_password.Clear();
                        textBox_password.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblRegister.LinkVisited = true;
            RegisterForm form1 = new RegisterForm(); 
            form1.Show();
            this.Hide();

        }

    }
}
