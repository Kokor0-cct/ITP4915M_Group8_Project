using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M_Group8_Project.Login
{
    internal class DbUserConnect
    {
        //create connection with db
        private static readonly string connStr = "DataSource=localhost; server=localhost;port=3306;database=itp4915m_2526_projectdatabase;user=root;password=;";


        MySqlConnection connection = new MySqlConnection("DataSource=localhost; port=3306;username=root;password=;database=itp4915m_2526_projectdatabase");

        //to get connection 
        public MySqlConnection Connection { get { return connection; } }

        //funtion of open connection
        public void openconnect() {
            if (connection.State==System.Data.ConnectionState.Closed) 
                connection.Open();
        }
        public void closeconnect()
        {
            if (connection.State==System.Data.ConnectionState.Open)
                connection.Close();
        }
        public static DataTable GetStaffinfo(string sName)
        {
            string sql = "SELECT * FROM staff WHERE sName=@sName";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@sName", sName); // 防注入

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                conn.Open();
                da.Fill(dt); // 把结果填进 DataTable

                return dt; // dt.Rows[0] 就是 user1 的那一行
            }
        }

        public static DataTable GetCustomerinfo(string cName)
        {
            string sql = "SELECT * FROM customers WHERE cName=@cName";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@cName", cName); // 防注入

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                conn.Open();
                da.Fill(dt); // 把结果填进 DataTable

                return dt; // dt.Rows[0] 就是 user1 的那一行
            }
        }
    }


}
