using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanityProfile
    {
        public static readonly string Profile_Menu_Path = "//i[@class='icon icon-arrowFullDn j-arrowIconToAvatar navBottom__userArrow']";
        public static readonly string Profile_Path = "//a[contains(text(),'Profile')]";
        public static readonly string Settings_Path = "//div[@class='userm userm-mainPage']//a[contains(text(),'Settings')]";
        public static readonly string Availability_Path = "//div[@class='userm userm-mainPage']//a[contains(text(),'Availability')]";
        public static readonly string Sign_Out_Path = "//a[contains(text(),'Sign Out')]";
        public static readonly string App_Version_Path = "//b[contains(text(),'9.15.2')]";

        public static void NavigateTo(IWebDriver wd)
        {
            HumanityLoginTests.LoginToHumanity();
        }

        //Getting and clicking Profile Menu
        #region ProfileMenu
        public static IWebElement GetProfileMenu(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile_Menu_Path));
        }
        public static void ClickProfileMenu(IWebDriver wd)
        {
            GetProfileMenu(wd).Click();
        }
        #endregion

        //Getting and clicking profile
        #region Profile
        public static IWebElement GetProfile(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile_Path));
        }
        public static void ClickProfile(IWebDriver wd)
        {
            GetProfile(wd).Click();
        }
        #endregion

        //Getting and clicking Settings
        #region Settings
        public static IWebElement GetSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_Path));
        }
        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
        }
        #endregion

        //Getting and clicking Availability
        #region Availability
        public static IWebElement GetAvailability(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Availability_Path));
        }
        public static void ClickAvailability(IWebDriver wd)
        {
            GetAvailability(wd).Click();
        }
        #endregion

        //Getting and clicking Sign Out
        #region SignOut
        public static IWebElement GetSignOut(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Sign_Out_Path));
        }
        public static void ClickSignOut(IWebDriver wd)
        {
            GetSignOut(wd).Click();
        }
        #endregion

        //Getting App Version
        #region AppVersion
        public static IWebElement GetAppVersion(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(App_Version_Path));
        }
        #endregion
    }
}
