using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M_Group8_Project.Customer
{
    public class CartItem
    {
        public string fID { get; set; }

        public string fName { get; set; }

        public decimal UnitPrice { get; set; }

        public int fQuantity { get; set; }

        public decimal TotalPrice => UnitPrice * fQuantity;

        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }
    }
}
