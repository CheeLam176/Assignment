using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        /*public int deleteData(MySqlConnection conn, Admin admin)
        {
            string deleteQuery = "DELETE FROM template where id='" + searchIdTxt.Text + "'";


            MySqlCommand sqlComm = new MySqlCommand(deleteQuery, conn);
            return sqlComm.ExecuteNonQuery();

        }*/

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin admin = new Admin();

            admin.Id = int.Parse(searchIdTxt.Text);

            DeleteTemplate dltTem = new DeleteTemplate();
            int recordCnt = dltTem.deleteData(dbConn.getConn(), admin);
            MessageBox.Show(recordCnt + " data have been deleted! ");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }
    }
}
