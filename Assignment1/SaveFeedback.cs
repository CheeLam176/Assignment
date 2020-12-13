using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    class SaveFeedback
    {
        public int addFeedback(MySqlConnection conn, CreateFeedback sendData)
        {
            string sql = "INSERT INTO feedback (templateID ,lastName, firstName, address, position, email, phoneNo)"
                + "VALUE('" + sendData.InterviewerChosenTemplateID + "','" + sendData.InterviewerLastName + "' , '" + sendData.InterviewerFirstName +
                "', '" + sendData.InterviewerAddress + "' , '" + sendData.InterviewerPosition +
                "','" + sendData.InterviewerEmail + "','" + sendData.InterviewerPhoneNo + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}
