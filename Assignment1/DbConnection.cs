using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class DbConnection
    {
        MySqlConnection conn;

        public string connect()
        {
            string connStr = "server=localhost;user=testing123;database=dynamictesting1;port=3306;password=testing123";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Done";
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
