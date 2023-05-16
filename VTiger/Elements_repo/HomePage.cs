using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTiger.Generic;

namespace VTiger.Elements_repo
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Projects']")]
        private IWebElement projectMTAB;

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Clickonprojects()
        {
            projectMTAB.Click();
            BaseClass.extentTest1.Info("User click on the projects major tab");
        }
    }
}
