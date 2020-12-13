using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class CreateFeedback
    {
        private int id;
        private int interviewerChosenTemplateID;
        private string interviewerFirstName;
        private string interviewerLastName;
        private string interviewerAddress;
        private string interviewerPosition;
        private string interviewerEmail;
        private string interviewerPhoneNo;
        private string interviewerDay;


        public int Id { get => id; set => id = value; }
        public string InterviewerFirstName { get => interviewerFirstName; set => interviewerFirstName = value; }
        public string InterviewerLastName { get => interviewerLastName; set => interviewerLastName = value; }
        public string InterviewerAddress { get => interviewerAddress; set => interviewerAddress = value; }
        public string InterviewerPosition { get => interviewerPosition; set => interviewerPosition = value; }
        public string InterviewerEmail { get => interviewerEmail; set => interviewerEmail = value; }
        public string InterviewerPhoneNo { get => interviewerPhoneNo; set => interviewerPhoneNo = value; }
        public int InterviewerChosenTemplateID { get => interviewerChosenTemplateID; set => interviewerChosenTemplateID = value; }
        public string InterviewerDay { get => interviewerDay; set => interviewerDay = value; }



        public List<CreateFeedback> getAllReview(MySqlConnection conn)
        {

            List<CreateFeedback> listLabr = new List<CreateFeedback>();
            string sql = "SELECT * FROM feedback";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                CreateFeedback crtFe = new CreateFeedback();
                crtFe.Id = (int)myReader.GetValue(0);
                crtFe.InterviewerFirstName = (string)myReader.GetValue(2);
                crtFe.InterviewerLastName = (string)myReader.GetValue(3);
                crtFe.InterviewerAddress = (string)myReader.GetValue(4);
                crtFe.InterviewerPosition = (string)myReader.GetValue(5);
                crtFe.InterviewerEmail = (string)myReader.GetValue(6);
                crtFe.InterviewerPhoneNo = (string)myReader.GetValue(7);
                crtFe.InterviewerDay = (string)myReader.GetValue(8);
                listLabr.Add(crtFe);
            }
            return listLabr;
        }
    }


}
