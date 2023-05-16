using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTiger.Elements_repo;
using VTiger.Generic;

namespace VTiger.TestData
{
    [TestClass]
    public class script2 : BaseClass
    {
        [TestMethod]
        [TestCategory("System")]  
        public void LoginToApplicationAddNewProject_Test()
        {
            try
            {
                wUtil.waitforpageload(driver);
                LoginPage lp = new LoginPage(driver);
                lp.logintoapp(username, password);
                HomePage homePage = new HomePage(driver);
                homePage.Clickonprojects();
                ProjectPage pp = new ProjectPage(driver);
                string name=p_name + cUtil.Randomnum();
                string pname = pman_name + cUtil.Randomnum();
                pp.CreateProjectmethod(name, pname, wUtil, "Created");
            }
            catch (Exception ex)
            {
                extentTest1.Fail(ex);
            }
        }

    }
}
