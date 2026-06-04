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
    public partial class Form1 : Form
    {
        CustomerClass1 customer = new CustomerClass1();
        public Form1()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void PwtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhonetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void companyBox(object sender, EventArgs e)
        {

        }

        private void comboBox_identity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
