using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VTiger.Generic
{
    public class WebdriverUtility
    {
        public void maximizewindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        public void waitforpageload(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(10);
        }

        public void waitforelementvisible(IWebDriver driver,string element)
        {
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }

        public void select(IWebDriver driver,IWebElement addofdd,int ind)
        {
            SelectElement sel = new SelectElement(addofdd);
            sel.DeselectByIndex(ind);
        }

        public void select(IWebElement addofdd,string name)
        {
            SelectElement sel = new SelectElement(addofdd);
            sel.SelectByText(name);
        }
        public void scrollintoview(IWebDriver driver,IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
        public static string TakeADefectSnap(IWebDriver driver)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var snap=takesScreenshot.GetScreenshot();
            DateTime dateTime = DateTime.Now;
            string cdate = dateTime.ToString().Replace("/", "-").Replace(" ", "-").Replace(":", "-");
            snap.SaveAsFile(Constantpaths.screnshotpath+cdate+".png",ScreenshotImageFormat.Png);
            string scpath = Constantpaths.screnshotpath + cdate + ".png";
            return scpath;
        }


    }
}
