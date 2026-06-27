using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    public partial class chatboxCC : UserControl
    {
        public bool IsCustomerSide { get; set; }
        public chatboxCC()
        {
            InitializeComponent();

        }
        public void SetMessage(string senderText, string content, string timeText, bool isCustomer)
        {
            IsCustomerSide = isCustomer;
            lblWHO.Text = senderText;
            txtMSG.Text = content;
            lblDate.Text = timeText;

            if (IsCustomerSide)
            {
                this.BackColor = Color.FromArgb(225, 230, 225);
            }
            else
            {
                this.BackColor = Color.FromArgb(232, 230, 228);
            }
        }

    }
}
