using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

namespace ITP4915M_Group8_Project.Staff.Inventory
{
    internal class DbConnect
    {
        //create connection with db
        private static readonly string connection = "DataSource=localhost; server=localhost;port=3306;database=itp4915m_2526_projectdatabase;user=root;password=;";


        public static DataTable Query(string sql, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database query error: " + ex.Message);
                }
            }
            return dt;
        }



        public static int Execute(string sql, params MySqlParameter[] parameters)
        {
            int rowsAffected = 0;
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        // 执行增删改，返回影响行数
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database execution error: " + ex.Message);
                }
            }
            return rowsAffected;
        }
    }
}
