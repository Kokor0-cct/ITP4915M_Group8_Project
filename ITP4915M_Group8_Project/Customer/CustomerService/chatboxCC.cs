using ITP4915M_Group8_Project.Login;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M_Group8_Project.Staff.Inventory;

namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    public partial class chatboxCC : UserControl
    {
        public bool IsCustomerSide { get; set; }
        public chatboxCC(string senderType, string cid, string message, string createdAt)
        {
            InitializeComponent();

            lblWHO.Text = cid;
            txtMSG.Text = message;
            lblDate.Text = createdAt;

            bool isCustomerSide = senderType == "customer";
            if (isCustomerSide)
            {
                BackColor = Color.FromArgb(225, 230, 225);
            }
            else
            {
                BackColor = Color.FromArgb(232, 230, 228);
            }
        }
    }

        
       

    }

