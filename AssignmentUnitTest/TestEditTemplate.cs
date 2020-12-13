using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace AssignmentUnitTest
{
    /// <summary>
    /// Summary description for TestEditTemplate
    /// </summary>
    [TestClass]
    public class TestEditTemplate
    {

        [TestMethod]
        public void TestMethod1()
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin textbox = new Admin();

            textbox.Id = 53;
            textbox.Textbox1 = "Edit 1";
            textbox.Textbox2 = "Edit 2";
            textbox.Textbox3 = "Edit 3";
            textbox.Textbox4 = "Edit 4";
            textbox.Textbox5 = "Edit 5";
            textbox.Textbox6 = "Edit 6";
            textbox.Textbox7 = "Edit 7";

            EditTemplate edtTem = new EditTemplate();
            int resp = edtTem.editData(dbConn.getConn(), textbox);
            Assert.IsNotNull(resp);
        }
    }
}
