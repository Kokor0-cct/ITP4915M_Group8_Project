using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer
{
    public partial class ProductCard : UserControl
    {

        public ProductCard()
        {
            InitializeComponent();
        }

        public string FId { get; set; }

        public string PName
        {
            set => lblpName.Text = value;
        }
        public string PType { get; set; }


        public decimal PPrice
        {
            set => lblpPrice.Text = $"${value}";
        }

        public int PStock
        {
            set
            {
                lblStockText.Text = $"Stock: {value}";
                if (value <= 0)
                {
                    btnOperate.Text = "Out of Stock";
                    btnOperate.Enabled = false;
                }
                else
                {
                    btnOperate.Text = "Product Info";
                    btnOperate.Enabled = true;
                }
            }
        }

        public Image PImage
        {
            set => picImg.Image = value;
        }

        public event EventHandler CardBtnClick;


        private void btnOperate_Click_1(object sender, EventArgs e)
        {
            CardBtnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
