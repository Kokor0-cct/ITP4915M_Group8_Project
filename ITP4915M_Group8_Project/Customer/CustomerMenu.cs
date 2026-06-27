using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M_Group8_Project.Customer.Customized;
using ITP4915M_Group8_Project.Login;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class CustomerMenu : Form
    {

        public CustomerMenu()
        {
            InitializeComponent();
            lblMsg.Text = "Hi! " + UserSession.CustomerName + ", Welcome to the Customer Menu! Please select an option from the menu.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_page from = new Product_page();
            from.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShoppingCart_Page from = new ShoppingCart_Page();
            from.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customized_Menu customized_Menu = new Customized_Menu();
            customized_Menu.ShowDialog();

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login.CustomerLogIn logIn = new Login.CustomerLogIn();
            logIn.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order from = new Order();
            from.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerService.CustomerService from = new CustomerService.CustomerService();
            from.ShowDialog();
        }
    }
}
