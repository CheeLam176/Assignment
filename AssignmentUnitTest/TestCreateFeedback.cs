using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace AssignmentUnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void createFeedbackTest()
        {

            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            CreateFeedback sendInterviewer = new CreateFeedback();

            sendInterviewer.InterviewerChosenTemplateID = int.Parse("50");
            sendInterviewer.IntervieweeLastName = "me";
            sendInterviewer.IntervieweeFirstName = "me";
            sendInterviewer.IntervieweeAddress = "me";
            sendInterviewer.IntervieweePosition = "me";
            sendInterviewer.IntervieweePhoneNo = 01125864125;
            sendInterviewer.IntervieweeEmail = "me";
            sendInterviewer.InterviewerComment = "me";
        
            SaveFeedback newTxtbox1 = new SaveFeedback();
            int recordCnt = newTxtbox1.addFeedback(dbConn.getConn(), sendInterviewer);
            Assert.IsNotNull("Pass.");
        }
    }
}
