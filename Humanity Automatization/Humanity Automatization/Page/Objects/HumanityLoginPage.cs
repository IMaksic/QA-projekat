using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanityLoginPage
    {
        public static readonly string Humanity_Login_URL = "https://www.humanity.com/app/";
        public static readonly string Login_Email_Path = "//input[@id='email']";
        public static readonly string Login_Password_Path = "//input[@id='password']";
        public static readonly string Login_Button_Path = "//button[@name='login'][contains(text(),'Log in')]";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(HumanityHome.Humanity_URL);
            HumanityHome.ClickLogin(wd);
        }

        //Getting and sending Login Email
        #region LoginEmail
        public static IWebElement GetLoginEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_Email_Path));
        }
        public static void SendLoginEmail(IWebDriver wd, string loginEmail)
        {
            GetLoginEmail(wd).SendKeys(loginEmail);
        }
        #endregion

        //Getting and sending Login Password
        #region LoginPassword
        public static IWebElement GetLoginPassword(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_Password_Path));
        }
        public static void SendLoginPassword(IWebDriver wd, string loginPassword)
        {
            GetLoginPassword(wd).SendKeys(loginPassword);
        }
        #endregion

        //Getting and clicking Login Button
        #region LoginButton
        public static IWebElement GetLoginButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_Button_Path));
        }
        public static void ClickLoginButton(IWebDriver wd)
        {
            GetLoginButton(wd).Click();
        }
        #endregion
    }
}
