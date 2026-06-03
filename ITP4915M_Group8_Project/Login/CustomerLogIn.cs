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
            cboBoxIdentity.SelectedIndex = 0; // 預設選擇第一個
        }

        private void cboBoxIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxIdentity.SelectedItem == null) return;

            string selectedType = cboBoxIdentity.SelectedItem.ToString();

            // 清空輸入欄位
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

            // 檢查是否選擇了身份類型
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
                        // 登入成功
                        string welcomeMessage = $"Welcome Staff, {uname}!";
                        MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 可以在這裡儲存登入資訊（如果需要）
                        UserSession.StaffName = uname;
                        UserSession.StaffPassword = pass;

                        this.Hide(); // 隱藏登入表單

                        // 可以根據不同身份開啟不同的主畫面
                        // if (isStaff == "Staff")
                        // {
                        //     StaffMainForm staffForm = new StaffMainForm();
                        //     staffForm.Show();
                        // }
                        // else
                        // {
                        //     CustomerMainForm customerForm = new CustomerMainForm();
                        //     customerForm.Show();
                        // }
                    }
                    else
                    {
                        // 登入失敗
                        string errorMessage = (identity == "Staff") ?
                            "Staff code or password incorrect!" :
                            "Customer code or password incorrect!";
                        MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // 清空密碼欄位讓使用者重新輸入
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
                        // 登入成功
                        string welcomeMessage = $"Welcome Customer, {uname}!";
                        MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // 可以在這裡儲存登入資訊（如果需要）
                        // 例如：Session.LoginUser = uname;
                        // Session.UserType = isStaff;
                        this.Hide(); // 隱藏登入表單
                        // 可以根據不同身份開啟不同的主畫面
                        // if (isStaff == "Staff")
                        // {
                        //     StaffMainForm staffForm = new StaffMainForm();
                        //     staffForm.Show();
                        // }
                        // else
                        // {
                        //     CustomerMainForm customerForm = new CustomerMainForm();
                        //     customerForm.Show();
                        // }
                    }
                    else
                    {
                        // 登入失敗
                        string errorMessage = "Customer code or password incorrect!";
                        MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // 清空密碼欄位讓使用者重新輸入
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

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblRegister.LinkVisited = true;
            Form1 form1 = new Form1();  // 保持原来的
            form1.Show();
            // this.Hide();  // 如果需要隐藏当前登录窗体，取消注释这行
        }
    }
}
