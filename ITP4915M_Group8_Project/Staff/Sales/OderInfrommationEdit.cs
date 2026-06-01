using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff
{
    public partial class OderInfrommationEdit : Form
    {
        public OderInfrommationEdit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void btnDetial1_Click1(object sender, EventArgs e)
        {
            OderInfrommation oderInfrommation = new OderInfrommation();
            oderInfrommation.Show();
            this.Hide();
        }
    }
}
