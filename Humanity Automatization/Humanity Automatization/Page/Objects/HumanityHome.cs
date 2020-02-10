using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanityHome
    {
        public static readonly string Humanity_URL = "https://www.humanity.com/";
        public static readonly string Humanity_Signed_Out_URL = "https://safisorinc.humanity.com/app/";
        public static readonly string Free_Trial_Path = "//a[@class='button pale']";
        public static readonly string Login_Path = "//p[contains(text(),'LOGIN')]";
        public static readonly string About_Us_Path = "//a[@class='nav-link no-before'][contains(text(),'About us')]";
        public static readonly string Full_Name_Path = "//div[@class='input-wrapper']//input[@placeholder='Full Name']";
        public static readonly string Email_Path = "//div[@class='input-wrapper']//input[@placeholder='Work Email']";
        public static readonly string Start_Trial_Path = "//input[@id='free-trial-link-01']";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(Humanity_URL);
        }

        //Getting and sending Full Name
        #region FullName
        public static IWebElement GetFullName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Full_Name_Path));
        }
        public static void SendFullName(IWebDriver wd, string name)
        {
            GetFullName(wd).SendKeys(name);
        }
        #endregion

        //Getting and sending Email
        #region Email
        public static IWebElement GetEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Email_Path));
        }
        public static void SendEmail(IWebDriver wd, string email)
        {
            GetFullName(wd).SendKeys(email);
        }
        #endregion

        //Getting and clicking "Start my free trial"
        #region StartTrial
        public static IWebElement GetStartTrial(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Start_Trial_Path));
        }
        public static void ClickStartTrial(IWebDriver wd)
        {
            GetStartTrial(wd).Click();
        }
        #endregion

        //Getting and clicking "About us"
        #region AboutUs
        public static IWebElement GetAboutUs(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(About_Us_Path));
        }
        public static void ClickAboutUs(IWebDriver wd)
        {
            GetAboutUs(wd).Click();
        }
        #endregion

        //Getting and clicking free trial button
        #region FreeTrial
        public static IWebElement GetFreeTrial(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Free_Trial_Path));
        }
        public static void ClickFreeTrial(IWebDriver wd)
        {
            GetFreeTrial(wd).Click();
        }
        #endregion

        //Getting and clicking Login
        #region Login
        public static IWebElement GetLogin(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_Path));
        }
        public static void ClickLogin(IWebDriver wd)
        {
            GetLogin(wd).Click();
        }
        #endregion
    }
    
}
