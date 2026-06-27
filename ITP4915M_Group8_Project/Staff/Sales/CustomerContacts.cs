using ITP4915M_Group8_Project.Customer.CustomerService;
using ITP4915M_Group8_Project.Staff.Inventory;
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
using ITP4915M_Group8_Project.Staff.Sales;

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class CustomerContacts : UserControl
    {
        public bool isRead { get; set; }
        
        public string cid { get; set; }

        public event EventHandler<string> SearchCID;
        public CustomerContacts(string cid)
        {
            InitializeComponent();
            this.cid = cid; 
            btnCustomerID.Text = cid.ToString();
        }

        public string CId { get; set; }
        public string CNAME { set => btnCustomerID.Text = value; }

        private void btnCustomerID_Click(object sender, EventArgs e)
        {
            SearchCID?.Invoke(this, this.cid);
        }




    }
}
