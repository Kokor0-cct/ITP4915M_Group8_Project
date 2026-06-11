using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M_Group8_Project.Login
{
    public static class UserSession
    {
        public static string CustomerId { get; set; }
        public static string CustomerName { get; set; }
        public static string CustomerPhone { get; set; }
        public static string CustomerAddress { get; set; }
        public static string CustomerCompany { get; set; }
        public static int CustomerBalance { get; set; }
        public static string CustomerPassword { get; set; }


        public static string StaffId { get; set; }
        public static string StaffName { get; set; }
        public static string StaffPhone { get; set; }
        public static string StaffDepartment { get; set; }
        public static string StaffPassword { get; set; }

        

    }
}
