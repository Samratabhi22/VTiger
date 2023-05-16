using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class LoginPage
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
        private IWebElement usernameTF;

        [FindsBy (How=How.Name,Using = "password")]
        private IWebElement passwordTF;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement signinBTN;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void logintoapp(string un,string psw)
        {
            try
            {
                usernameTF.SendKeys(un);
                BaseClass.extentTest1.Info("User enters the valid username : " + un);
                passwordTF.SendKeys(psw);
                BaseClass.extentTest1.Info("User enters the valid password : " + psw);
                signinBTN.Click();
                BaseClass.extentTest1.Info("User click on signin");
            }catch (Exception ex)
            {
                BaseClass.extentTest1.Fail(ex.Message);
            }
        }
    }
}
