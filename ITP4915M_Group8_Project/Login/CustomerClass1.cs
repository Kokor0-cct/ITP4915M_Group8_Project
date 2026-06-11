using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;

namespace ITP4915M_Group8_Project.Login
{
    internal class CustomerClass1
    {
        

        DbUserConnect connect = new DbUserConnect();

        

        //cerate a fuction to add a customer to database
        public bool InsertCustomer( string cName, string cPhone,string cPassword, string cAddress, string company)
        {

            //---Finding the maximum cid---
            string sql = "SELECT MAX(cUserID) FROM Customers";
            DataTable dt = DbConnect.Query(sql);
            string max_cid = (string) dt.Rows[0]["MAX(cUserID)"];

            Match match = Regex.Match(max_cid, "[1-9]"); // Find the first occurance of a non-zero integer

            int max_sequence = int.Parse(max_cid.Substring(match.Index)); // Find the maximum sequence
            int new_sequence = max_sequence + 1;

            //---Creating the new cid---
            string new_cid = "C";

            if (new_sequence < 10)
                new_cid += "000000";
            else if (new_sequence < 100)
                new_cid += "00000";
            else if (new_sequence < 1000)
                new_cid += "0000";
            else if (new_sequence < 10000)
                new_cid += "000";
            else if (new_sequence < 100000)
                new_cid += "00";
            else if (new_sequence < 1000000)
                new_cid += "0";

            new_cid += new_sequence;

            //---Applying the values---

            MySqlCommand command = new MySqlCommand(
    "INSERT INTO Customers(cUserID, cName, cPhone, cPassword, cAddress, company) VALUES (@cid,@cn,@cp,@cpw,@cads,@cmpy)",
    connect.Connection);

            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = new_cid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cPhone;
            command.Parameters.Add("@cpw", MySqlDbType.VarChar).Value = cPassword;
            command.Parameters.Add("@cads", MySqlDbType.VarChar).Value = cAddress;
            command.Parameters.Add("@cmpy", MySqlDbType.VarChar).Value = company;

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
