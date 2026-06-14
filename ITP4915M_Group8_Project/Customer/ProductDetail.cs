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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class ProductDetail : Form
    {
        public int CurrentFId { get; set; }
        public ProductDetail(string selectFid)
        {
            InitializeComponent();
            int fid = CurrentFId;

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
