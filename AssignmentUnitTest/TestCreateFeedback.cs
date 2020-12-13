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
            IntDbConnection db_connect = new IntDbConnection();
            db_connect.tryConn();

            CreateFeedback sendInterviewer = new CreateFeedback();
            sendInterviewer.InterviewerChosenTemplateID = int.Parse("39");
            sendInterviewer.InterviewerLastName = "me";
            sendInterviewer.InterviewerFirstName = "me";
            sendInterviewer.InterviewerAddress = "me";
            sendInterviewer.InterviewerPosition = "me";
            sendInterviewer.InterviewerPhoneNo = "me";
            sendInterviewer.InterviewerEmail = "me";
            sendInterviewer.InterviewerDay = "Saturday";

            createFeedback toDB = new createFeedback();
            int recordCount = toDB.insertInterviewer(db_connect.getConnect(), sendInterviewer);
            Assert.IsNotNull("Pass.");
        }
    }
}
