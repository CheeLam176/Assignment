using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment1
{
    public class SaveFeedback
    {
        public int addFeedback(MySqlConnection conn, CreateFeedback sendData)
        {
            string sql = "INSERT INTO feedback (templateID ,lastName, firstName, address, position, email,phoneNo, comment)"
                + "VALUE('" + sendData.InterviewerChosenTemplateID + "','" + sendData.IntervieweeLastName + "' , '" + sendData.IntervieweeFirstName +
                "', '" + sendData.IntervieweeAddress + "' , '" + sendData.IntervieweePosition +
                "','" + sendData.IntervieweeEmail + "',"+sendData.IntervieweePhoneNo+",'" + sendData.InterviewerComment + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}
