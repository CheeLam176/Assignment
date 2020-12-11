using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class Admin
    {
        private int id;
        private string textbox1;
        private string textbox2;
        private string textbox3;
        private string textbox4;
        private string textbox5;
        private string textbox6;
        private string textbox7;

        public int Id { get => id; set => id = value; }
        public string Textbox1 { get => textbox1; set => textbox1 = value; }
        public string Textbox2 { get => textbox2; set => textbox2 = value; }
        public string Textbox3 { get => textbox3; set => textbox3 = value; }
        public string Textbox4 { get => textbox4; set => textbox4 = value; }
        public string Textbox5 { get => textbox5; set => textbox5 = value; }
        public string Textbox6 { get => textbox6; set => textbox6 = value; }
        public string Textbox7 { get => textbox7; set => textbox7 = value; }


        public List<Admin> GetAllData(MySqlConnection conn)
        {

            List<Admin> listLabr = new List<Admin>();
            string sql = "SELECT * FROM template";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                Admin admin = new Admin();
                admin.Id = (int)myReader.GetValue(0);
                admin.Textbox1 = (string)myReader.GetValue(1);
                admin.Textbox2 = (string)myReader.GetValue(2);
                admin.Textbox3 = (string)myReader.GetValue(3);
                admin.Textbox4 = (string)myReader.GetValue(4);
                admin.Textbox5 = (string)myReader.GetValue(5);
                admin.Textbox6 = (string)myReader.GetValue(6);
                admin.Textbox7 = (string)myReader.GetValue(7);
                listLabr.Add(admin);
            }
            return listLabr;
        }


    }
}

