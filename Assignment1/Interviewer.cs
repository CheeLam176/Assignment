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
using System.Drawing.Printing;

namespace Assignment1
{
    public partial class Interviewer : Form
    {
        public Interviewer()
        {
            InitializeComponent();
        }

        public int showData(MySqlConnection conn, Admin admin)
        {
            string sqlQuery = "SELECT * from template where id='" + idSearchtxtbox.Text + "'";


            MySqlCommand sqlComm = new MySqlCommand(sqlQuery, conn);
            using (MySqlDataReader dr = sqlComm.ExecuteReader())
            {
                if (dr.Read())
                {
                    label2.Text = (dr["textbox1"].ToString() + " :");
                    label3.Text = (dr["textbox2"].ToString() + " :");
                    label4.Text = (dr["textbox3"].ToString() + " :");
                    label5.Text = (dr["textbox4"].ToString() + " :");
                    label6.Text = (dr["textbox5"].ToString() + " :");
                    label7.Text = (dr["textbox6"].ToString() + " :");
                    label8.Text = (dr["textbox7"].ToString() + " :");


                }
            }
            return sqlComm.ExecuteNonQuery();

        }

        private void templateLoadButton_Click(object sender, EventArgs e)
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin admin = new Admin();
            templateDataGrid.DataSource = admin.GetAllData(dbConn.getConn());
        }

        private void searchIDButton_Click(object sender, EventArgs e)
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin admin = new Admin();

            int recordCnt = showData(dbConn.getConn(), admin);
        }

        private void sendFeedbackbtn_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            CreateFeedback sendInterviewer = new CreateFeedback();

            sendInterviewer.InterviewerChosenTemplateID = int.Parse(idSearchtxtbox.Text);
            sendInterviewer.InterviewerLastName = txt1.Text;
            sendInterviewer.InterviewerFirstName = txt2.Text;
            sendInterviewer.InterviewerAddress = txt3.Text;
            sendInterviewer.InterviewerPosition = txt4.Text;
            sendInterviewer.InterviewerPhoneNo = txt5.Text;
            sendInterviewer.InterviewerEmail = txt6.Text;
            sendInterviewer.InterviewerDay = txt7.Text;

            SaveFeedback newTxtbox1 = new SaveFeedback();
            int recordCnt = newTxtbox1.addFeedback(dbConn.getConn(), sendInterviewer);
            MessageBox.Show(recordCnt + " new details has been inserted !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.Show();
            pd.Print();
        }
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
