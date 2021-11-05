using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTEM_TEST
{
    public class LoginPage : LoginElements
    {
        public LoginPage EnterLogin(string login)
        {
            WaitUntil.ElementIsClickable(inputLogin, 3);

            inputLogin.SendKeys(login);

            return Pages.Login;
        }
    }
}
