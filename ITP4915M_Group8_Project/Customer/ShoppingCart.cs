using ITP4915M_Group8_Project.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M_Group8_Project.Customer
{
    public static class ShoppingCart
    {



        public static string CustomerId = UserSession.CustomerId;



        public static List<CartItem> Items { get; set; } = new List<CartItem>();



        public static void AddItem(string id, string name, decimal price, int qty )
        {
            var existItem = Items.FirstOrDefault(x => x.fID == id);

            if (existItem != null)
            {
                existItem.fQuantity += qty;
            }
            else
            {
                Items.Add(new CartItem
                {
                    fID = id,
                    fName = name,
                    UnitPrice = price,
                    fQuantity = qty
                });
            }
        }
        public static bool UpdateItem(string id, int qty)
        {
            var existItem = Items.FirstOrDefault(x => x.fID == id);
            
            if (existItem != null)
            {
                existItem.fQuantity = qty;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DeleteItem(string id)
        {
            var existItem = Items.FirstOrDefault(x => x.fID == id);

            if (existItem != null)
            {
                Items.Remove(existItem);
            }
        }

        public static void Clear()
        {
            Items.Clear();
        }





        public static decimal GetTotalAmount()
        {
            return Items.Sum(x => x.TotalPrice);
        }
    }
}
