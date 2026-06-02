using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ITP4915M_Group8_Project.Login
{
    internal class DbConnect
    {
        //create connection with db
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
    }
}
