using RadioTrack_ReaderClient;
using RFIDeas_pcProxAPI_forTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MySql.Data.MySqlClient;

namespace MainTestProject
{
    
    
    /// <summary>
    ///This is a test class for form_MainTest and is intended
    ///to contain all form_MainTest Unit Tests
    ///</summary>
    [TestClass()]
    public class form_MainTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for isUserAdministrator
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RadioTrack_ReaderClient.exe")]
        public void isUserAdministratorTest()
        {
            form_Main_Accessor target = new form_Main_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isUserAdministrator();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getBuildStatusFromStationId
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RadioTrack_ReaderClient.exe")]
        public void getBuildStatusFromStationIdTest()
        {
            form_Main_Accessor target = new form_Main_Accessor(); // TODO: Initialize to an appropriate value
            string stationId = "TF"; // TODO: Initialize to an appropriate value
            string stationHistory = "SFC,2014-03-05 13:21:43;S01,2014-03-07 13:52:07;S02,2014-03-07 15:11:50;S03,2014-03-07 16:43:10;S04,2014-03-08 08:48:31;S05,2014-03-08 10:12:31;S06,2014-03-08 11:18:19;S07,2014-03-08 13:47:21;S08,2014-03-08 15:10:27;S09,2014-03-08 16:41:19;S10,2014-03-08 15:58:54"; // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getBuildStatusFromStationId(stationId, stationHistory);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("RadioTrack_ReaderClient.exe")]
        public void canConnectToDatabase()
        {
            form_Main_Accessor target = new form_Main_Accessor();
            MySqlConnection conn = target.dbConn;
            bool actual;
            bool expected = true;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            actual = conn.Ping();
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            Assert.AreEqual(expected, actual, "Cannot ping database");
        }

        [TestMethod()]
        [DeploymentItem("RadioTrack_ReaderClient.exe")]
        public void canConnectToUsbReader()
        {
            int actual;
            int expected = 1;

            actual = pcProxDLLAPI.usbConnect();

            Assert.AreEqual(expected, actual, "No connection to USB Reader");
        }
    }
}
