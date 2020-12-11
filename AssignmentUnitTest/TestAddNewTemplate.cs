using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace AssignmentUnitTest
{
    [TestClass]
    public class TestAddNewTemplate
    {
        [TestMethod]
        public void TestMethod1()
        {
            DbConnection dbC = new DbConnection();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Admin newTemplate = new Admin();
            newTemplate.Textbox1 = "Testing1";
            newTemplate.Textbox2 = "Testing2";
            newTemplate.Textbox3 = "Testing3";
            newTemplate.Textbox4 = "Testing4";
            newTemplate.Textbox5 = "Testing5";
            newTemplate.Textbox6 = "Testing6";
            newTemplate.Textbox7 = "Testing7";

            Textbox1Handler templateHandler = new Textbox1Handler();
            int resp2 = templateHandler.addTextbox1(dbC.getConn(), newTemplate);
            Assert.IsNotNull(resp2);
        }
    }
}
