using MaestroPanelApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MaestroPanelApi_Test
{
    
    
    /// <summary>
    ///This is a test class for ClientTest and is intended
    ///to contain all ClientTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClientTest
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
        ///A test for DomainCreate
        ///</summary>
        [TestMethod()]
        public void DomainCreateTest()
        {
            string ApiKey = "43_6a8200676c0d42f4b1c00094930d3e19";
            string apiHostdomain = "localhost";
            int port = 28411;
            bool ssl = false; 
            Client target = new Client(ApiKey, apiHostdomain, port, ssl);

            string name = "demo4.com";
            string planAlias = "DALISA";
            string username = "demo1.com";
            string password = "kr3m@12!";
            bool activedomainuser = false;
            string firstName = "Demo";
            string lastName = "Customer";
            string email = "demo@customer.com";            

            ApiResult actual = target.DomainCreate(name, planAlias, username, password, activedomainuser, firstName, lastName, email);
            Assert.AreEqual(0, actual.Code);            
        }

        /// <summary>
        ///A test for DomainDelete
        ///</summary>
        [TestMethod()]
        public void DomainDeleteTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            string name = "demo1.com";            
            ApiResult actual = target.DomainDelete(name);
            Assert.AreEqual(0, actual.Code);               
        }

        /// <summary>
        ///A test for DomainStart
        ///</summary>
        [TestMethod()]
        public void DomainStartTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            
            string name = "demo1.com";       
            ApiResult actual = target.DomainStart(name);
            Assert.AreEqual(0, actual.Code);            
        }

        /// <summary>
        ///A test for DomainStop
        ///</summary>
        [TestMethod()]
        public void DomainStopTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            string name = "demo1.com";  
            
            ApiResult actual = target.DomainStop(name);
            Assert.AreEqual(0, actual.Code);                       
        }

        [TestMethod()]
        public void SetDnsZoneTest()
        {
            string ApiKey = "ddd";
            string apiHostdomain = "ddd";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            string name = "testmaestro2.com";  
            
            var soa_expired = "3600";
            var soa_ttl = "172800";
            var soa_refresh = "8640";
            var soa_email = "ping.maestropanel.com";
            var soa_retry = "7200";
            var soa_serial = "2016032412141";
            var primaryServer = "ns1.hosting.com";

            var records = new List<string>();
            records.Add("@,A,4.2.2.1,0");
            records.Add("www,CNAME,domain.com,0");
            records.Add("mail,A,192.168.5.6,0");
            records.Add("@,MX,mail.tatava.com,10");
            records.Add("@,NS,ns1.domain.com,0");
            records.Add("@,NS,ns2.domain.com,0");
            records.Add("@,TXT,spf=v1 mx -all,0");
            records.Add("dkim,CNAME,mx.yandex.com,0");

            ApiResult actual = target.SetDnsZone(name, soa_expired, soa_ttl, soa_refresh, soa_email, soa_retry, soa_serial, primaryServer, false, records.ToArray());
            Debug.WriteLine(actual.Message);
            
            Assert.AreEqual(0, actual.Code);
        }
    }
}
