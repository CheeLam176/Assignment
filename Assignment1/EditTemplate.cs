using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class EditTemplate
    {
        public int editData(MySqlConnection conn, Admin admin)
        {
            string deleteQuery = "UPDATE dynamictesting1.template SET Textbox1='" + admin.Textbox1 + "',Textbox2='" + admin.Textbox2 + "',Textbox3='" + admin.Textbox3 + "',Textbox4='" + admin.Textbox4 + "',Textbox5='" + admin.Textbox5 + "',Textbox6='" + admin.Textbox6 + "',Textbox7='" + admin.Textbox7 + "' WHERE id=" + admin.Id;


            MySqlCommand sqlComm = new MySqlCommand(deleteQuery, conn);
            return sqlComm.ExecuteNonQuery();

        }
    }
}
