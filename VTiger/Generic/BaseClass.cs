using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{
    [TestClass]
    public class BaseClass
    {

        public WebdriverUtility wUtil=new WebdriverUtility();
        public Excellutility eUtil=new Excellutility();
        public Csharputility cUtil=new Csharputility();
        public ExtentReportclass exReport=new ExtentReportclass();
   
        public TestContext TestContext { get; set; }
        public IWebDriver driver;

        public static ExtentReports extentReports1;
        public static ExtentHtmlReporter htmlReporter1;
        public static ExtentTest extentTest1;


        [AssemblyInitialize]
        public static void Assemblyinit(TestContext Context)
        {
            extentReports1 = new ExtentReports();
            htmlReporter1 = new ExtentHtmlReporter(Constantpaths.reportpath);
            htmlReporter1.Start();
            extentReports1.AttachReporter(htmlReporter1);
        }


        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            wUtil.maximizewindow(driver);
            extentTest1 = extentReports1.CreateTest(TestContext.TestName);
            //  string url =TestContext.Properties["appurl"].ToString();
            string url = eUtil.getavalue("login", "appurl");
            driver.Url = url;
            extentTest1.Info("application succesfully launched");
         
        }


        [TestCleanup]
        public void TestCleanup()
        {
            exReport.Extentreportmethod(driver);
            driver.Quit();
            driver.Dispose();
        }



        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            extentReports1.Flush();
            htmlReporter1.Stop();
        }
    }
}

