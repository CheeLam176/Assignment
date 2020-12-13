using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace AssignmentUnitTest
{
    /// <summary>
    /// Summary description for TestDeleteTemplate
    /// </summary>
    [TestClass]
    public class TestDeleteTemplate
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void TestMethod1()
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin admin = new Admin();

            admin.Id = 51;

            DeleteTemplate dltTem = new DeleteTemplate();
            int resp = dltTem.deleteData(dbConn.getConn(), admin);
            Assert.IsNotNull(resp);



        }
    }
}
