using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M_Group8_Project.Customer
{
    internal class ShoppingCart
    {
        public class CartItem
        {
            // 商品ID（必须有）
            public int fID { get; set; }

            // 商品名称
            public string fName { get; set; }

            // 单价
            public decimal Price { get; set; }

            // 购买数量
            public int fQuantity { get; set; }

            // 小计（自动计算）
            public decimal TotalPrice => Price * fQuantity;
        }
    }
}
