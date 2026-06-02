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

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Staff");
            comboBox1.SelectedIndex = 0; // 預設選擇第一個
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedType = comboBox1.SelectedItem.ToString();

            // 清空輸入欄位
            textBox_UserName.Clear();
            textBox_password.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("請輸入使用者名稱和密碼。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("請選擇登入身份（客戶/員工）。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string uname = textBox_UserName.Text;
            string pass = textBox_password.Text;
            string isStaff = comboBox1.SelectedItem.ToString();
           

            try
            {
                string query = "SELECT * FROM `customers` WHERE `cName` = @cName AND `cPassword` = @cPassword ";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@cName", uname);
                cmd.Parameters.AddWithValue("@cPassword", pass);

                DataTable table = customerLogin.getlist(cmd);

                if (table.Rows.Count > 0)
                {
                    string welcomeMessage = (isStaff == "Staff") ? $"歡迎員工，{uname}！" : $"歡迎客戶，{uname}！";
                    MessageBox.Show(welcomeMessage, "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    string errorMessage = (isStaff == "Staff") ?
                        "員工帳號或密碼錯誤。" :
                        "客戶帳號或密碼錯誤。";
                    MessageBox.Show(errorMessage, "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // 清空密碼欄位讓使用者重新輸入
                    textBox_password.Clear();
                    textBox_password.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登入時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Form1 form1 = new Form1();  // 保持原来的
            form1.Show();
            // this.Hide();  // 如果需要隐藏当前登录窗体，取消注释这行
        }
    }
}
