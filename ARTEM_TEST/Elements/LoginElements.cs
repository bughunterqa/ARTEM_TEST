using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTEM_TEST
{
    public class LoginElements
    {
        [FindsBy(How=How.Id, Using = "TestLocator")]
        public IWebElement inputLogin;
    }
}
