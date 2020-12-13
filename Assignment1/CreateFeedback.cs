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
        private string intervieweeFirstName;
        private string intervieweeLastName;
        private string intervieweeAddress;
        private string intervieweePosition;
        private string intervieweeEmail;
        private string interviewerComment;
        private int intervieweePhoneNo;
        


        public int Id { get => id; set => id = value; }
        public string IntervieweeFirstName { get => intervieweeFirstName; set => intervieweeFirstName = value; }
        public string IntervieweeLastName { get => intervieweeLastName; set => intervieweeLastName = value; }
        public string IntervieweeAddress { get => intervieweeAddress; set => intervieweeAddress = value; }
        public string IntervieweePosition { get => intervieweePosition; set => intervieweePosition = value; }
        public string IntervieweeEmail { get => intervieweeEmail; set => intervieweeEmail = value; }
        public string InterviewerComment { get => interviewerComment; set => interviewerComment = value; }
        public int InterviewerChosenTemplateID { get => interviewerChosenTemplateID; set => interviewerChosenTemplateID = value; }
        public int IntervieweePhoneNo { get => intervieweePhoneNo; set => intervieweePhoneNo = value; }

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
                crtFe.IntervieweeFirstName = (string)myReader.GetValue(2);
                crtFe.IntervieweeLastName = (string)myReader.GetValue(3);
                crtFe.IntervieweeAddress = (string)myReader.GetValue(4);
                crtFe.IntervieweePosition = (string)myReader.GetValue(5);
                crtFe.IntervieweeEmail = (string)myReader.GetValue(6);
                crtFe.IntervieweePhoneNo = (int)myReader.GetValue(7);
                crtFe.InterviewerComment = (string)myReader.GetValue(8);
                listLabr.Add(crtFe);
            }
            return listLabr;
        }
    }


}
