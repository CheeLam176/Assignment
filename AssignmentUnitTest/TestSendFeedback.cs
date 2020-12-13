using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment1;
using System.Net.Mail;

namespace AssignmentUnitTest
{
    [TestClass]
    public class TestSendFeedback
    {
        [TestMethod]
        public void sendFeedbackTest()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("veemon1000@gmail.com");
            mail.To.Add("This person.");
            mail.Subject = "Feedback replied!";
            mail.Body = "Please check your feedback response!";
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("Attached Content");
            mail.Attachments.Add(attachment);

            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("veemon1000@gmail.com", "abc1234");
            smtp.EnableSsl = true;
            smtp.Send(mail);
            Assert.IsNotNull("Sent mail!");
            Assert.Fail("Invalid address/Password!");
        }
    }
}
