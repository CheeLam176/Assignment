using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class DeleteTemplate
    {
        public int deleteData(MySqlConnection conn, Admin admin)
        {
            string deleteQuery = "DELETE FROM template where id='" + admin.Id + "'";


            MySqlCommand sqlComm = new MySqlCommand(deleteQuery, conn);
            return sqlComm.ExecuteNonQuery();

        }
    }
}
