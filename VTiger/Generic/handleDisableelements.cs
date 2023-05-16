using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{
    public class handleDisableelements
    {
        public static void sendkeyfordisele(IWebDriver driver,IWebElement elementadd,int v)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript($"arguments[0].value='"+v+"';",elementadd);
        }

    }
}
