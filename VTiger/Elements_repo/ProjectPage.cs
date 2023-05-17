using Microsoft.Extensions.Primitives;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VTiger.Generic;

namespace VTiger.Elements_repo
{
    public class ProjectPage
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//span[.='Create Project']")]
        private IWebElement createprojectBTN;

        [FindsBy(How=How.Name,Using = "projectName")]
        private IWebElement projectnameTF;

        [FindsBy(How = How.Name, Using = "teamSize")]
        private IWebElement teamsizeDTF;

        [FindsBy(How = How.Name, Using = "createdBy")]
        private IWebElement projectmanagerTF;

        [FindsBy(How=How.XPath,Using = "(//select[@name='status'])[2]")]
        private IWebElement statusDD;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement addprojectBTN;

        public ProjectPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }  
        
        public void CreateProjectmethod(String pname,string pmanager,WebdriverUtility util,string opt)
        {
            try
            {
                createprojectBTN.Click();
                BaseClass.extentTest1.Info("user click on the create project button");
                projectnameTF.SendKeys(pname);
                BaseClass.extentTest1.Info("user enter the projectname : " + pname);

                handleDisableelements.sendkeyfordisele(driver, teamsizeDTF, 3);
                String value = teamsizeDTF.GetAttribute("value");
                BaseClass.extentTest1.Info("user enter the Teamsize : " + value);

                projectmanagerTF.SendKeys(pmanager);
                BaseClass.extentTest1.Info("user enter the project manager name : " + pmanager);
                statusDD.Click();
                util.select(statusDD, opt);
                BaseClass.extentTest1.Info("user selected the status : " + opt);

                addprojectBTN.Click();
                BaseClass.extentTest1.Info("user click on the AddProject Button");

                Datavalidation.createdprojectvalidate(pname);
            }
            catch (Exception e)
            {
                BaseClass.extentTest1.Fail(e);
            }


        }
    }
}
