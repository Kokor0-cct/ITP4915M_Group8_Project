using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Login

{
    public partial class RegisterForm : Form
    {
        CustomerClass1 customer = new CustomerClass1();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_identity.Items.Clear();
            comboBox_identity.Items.Add("Customer");
            comboBox_identity.Items.Add("Staff");
            comboBox_identity.SelectedIndex = 0;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // add new customer
            string cName = NametextBox.Text;
            string cPassword = PwtextBox.Text;
            string cphone = PhonetextBox.Text;
            string cadd = AddstextBox.Text;
            string company = CompanyBox.Text;
            string isStaff = comboBox_identity.SelectedText.ToString() == "Staff" ? "Y" : "N";

            if (verify())
            {
                if (customer.InsertCustomer(cName, cPassword, cphone, cadd, company, isStaff))
                {
                    MessageBox.Show("Registration Successfully!", "Add customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Don't add", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // create a fuction to verify
        bool verify()
        {
            if ((NametextBox.Text == "") || (PwtextBox.Text == "") ||
                (PhonetextBox.Text == "") || (AddstextBox.Text == "") || comboBox_identity.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields ", "hint",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (PwtextBox.Text.Length < 6)
            {
                MessageBox.Show("The password must be at least 6 characters long!", "hint",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhonetextBox.Text, @"^\d{8,12}$"))
            {
                MessageBox.Show("Please enter a valid phone number (8-12 digits)!", "hint",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }


        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llLogin.LinkVisited = true;
            CustomerLogIn form1 = new CustomerLogIn();
            form1.Show();
            this.Close();
        }
    }
}
