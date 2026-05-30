
    //using MySqlConnector;
    using System.Data;
    //using System.Windows.Forms;

    namespace ITP4915M_Group8.Utils
    {
        public static class DbHelper
        {
            // XAMPP MySQL 默认连接字符串（直接用！）
            private static string connStr = "server=localhost;database=itp4915m_2526_projectdatabase;user=root;password=;";

            // 查询返回 DataTable
            public static DataTable Query(string sql, params MySqlParameter[] parameters)
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddRange(parameters);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(dt);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库错误：" + ex.Message);
                    }
                }
                return dt;
            }

            // 增删改 操作
            public static int Execute(string sql, params MySqlParameter[] parameters)
            {
                int result = 0;
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddRange(parameters);
                            result = cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库错误：" + ex.Message);
                    }
                }
                return result;
            }
        }
    }