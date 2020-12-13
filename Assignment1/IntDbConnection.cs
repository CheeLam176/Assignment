using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class IntDbConnection
    {
        MySqlConnection connect;

        public string tryConn()
        {
            string tryConnect1 = "server=localhost;user=testing123;database=dynamictesting1;port=3306;password=testing123";
            connect = new MySqlConnection(tryConnect1);
            try
            {
                connect.Open();
            }

            catch (Exception ex1)
            {
                return ex1.ToString();
            }

            return "Connection success!";
        }

        public MySqlConnection getConnect()
        {
            return connect;
        }
    }
}
