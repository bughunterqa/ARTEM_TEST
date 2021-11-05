using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTEM_TEST
{
    class Browser
    {
        public IWebDriver WebDriver { get; set; }
        private static IWebDriver webDriver = new ChromeDriver();



        public Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        public static void Initialize()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://jira-anuitex.atlassian.net/");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static string RootPath()
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var directoryName = System.IO.Path.GetDirectoryName(currentPath);
            var directory = System.IO.Path.GetDirectoryName(directoryName);
            var mainpath = directory.Replace("\\bin\\Debug", "");

            return mainpath;
        }


    }
}
