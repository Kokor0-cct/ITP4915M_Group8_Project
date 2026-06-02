using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ITP4915M_Group8_Project.Login
{
    internal class CustomerClass1
    {
        
        DbConnect connect = new DbConnect();

        //cerate a fuction to add a customer to database
        public bool InsertCustomer( string cName, string cPhone,string cPassword, string cAddress, string company, string isStaff)
        {
            MySqlCommand command = new MySqlCommand(
    "INSERT INTO `customers`(`cName`, `cPhone`, `cPassword`, `cAddress`, `company`, `isStaff`) VALUES (@cn,@cp,@cpw,@cads,@cmpy,@isSf)",
    connect.Connection);

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cPhone;
            command.Parameters.Add("@cpw", MySqlDbType.VarChar).Value = cPassword;
            command.Parameters.Add("@cads", MySqlDbType.VarChar).Value = cAddress;
            command.Parameters.Add("@cmpy", MySqlDbType.VarChar).Value = company;
            command.Parameters.Add("@isSf", MySqlDbType.VarChar).Value = isStaff;

            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.Connection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
