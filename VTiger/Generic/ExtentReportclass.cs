using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{
    public class ExtentReportclass
    {
        public void Extentreportmethod(IWebDriver driver)
        {
            if (BaseClass.extentTest1.Status == Status.Fail)
            {
                string path = WebdriverUtility.TakeADefectSnap(driver);
                BaseClass.extentTest1.AddScreenCaptureFromPath(path);
                BaseClass.extentTest1.Fail(" test failed ");
            }
            else if (BaseClass.extentTest1.Status == Status.Pass)
            {
                BaseClass.extentTest1.Pass("test passed");
            }
            else if (BaseClass.extentTest1.Status == Status.Skip)
            {
                BaseClass.extentTest1.Log(Status.Info, "skipped");
            }
        }
    }
}
