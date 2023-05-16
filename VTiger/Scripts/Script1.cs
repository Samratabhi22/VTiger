using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTiger.Elements_repo;
using VTiger.Generic;

namespace VTiger.Scipts
{
    [TestClass]
    public class Script1 : BaseClass
    {
        [TestMethod]
        [TestCategory("Sanity")]
        public void LoginScript() 
        {
            try
            {
                LoginPage lp = new LoginPage(driver);
                String username = eUtil.getavalue("login", "username");
                String password = eUtil.getavalue("login", "password");
                lp.logintoapp(username, password);
            }
            catch (Exception ex)
            {
                extentTest1.Info(ex);
                extentTest1.Fail("test failed");
            }
        }
    }
}
