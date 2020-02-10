using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanityMenu
    {
        public static readonly string Humanity_Menu_URL = "https://safisorinc.humanity.com/app/dashboard/";
        public static readonly string Dashboard_Path = "//a[@id='sn_dashboard']//span[@class='primNavQtip__inner']";
        public static readonly string Shift_Planning_Path = "//a[@id='sn_schedule']//span[@class='primNavQtip__inner']";
        public static readonly string Time_Clock_Path = "//a[@id='sn_timeclock']//span[@class='primNavQtip__inner']";
        public static readonly string Leave_Path = "//a[@id='sn_requests']//span[@class='primNavQtip__inner']";
        public static readonly string Training_Path = "//a[@id='sn_requests']//span[@class='primNavQtip__inner']";
        public static readonly string Staff_Path = "//a[@id='sn_staff']//span[contains(@class,'primNavQtip__inner')]";
        public static readonly string Payroll_Path = "//a[@id='sn_payroll']//span[@class='primNavQtip__inner']";
        public static readonly string Reports_Path = "//a[@id='sn_reports']//span[@class='primNavQtip__inner']";
        public static readonly string Settings_Button_Path = "//a[@id='sn_admin']";

        public static void NavigateTo(IWebDriver wd)
        {
            HumanityLoginTests.LoginToHumanity();
        }

        //Getting and clicking Dashboard
        #region Dashboard
        public static IWebElement GetDashboard(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Dashboard_Path));
        }
        public static void ClickDashboard(IWebDriver wd)
        {
            GetDashboard(wd).Click();
        }
        #endregion

        //Getting and clicking Shift Planning
        #region ShiftPlanning
        public static IWebElement GetShiftPlanning(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Shift_Planning_Path));
        }
        public static void ClickShiftPlanning(IWebDriver wd)
        {
            GetShiftPlanning(wd).Click();
        }
        #endregion

        //Getting and clicking Time Clock
        #region TimeClock
        public static IWebElement GetTimeClock(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Time_Clock_Path));
        }
        public static void ClickTimeClock(IWebDriver wd)
        {
            GetTimeClock(wd).Click();
        }
        #endregion

        //Getting and clicking Leave
        #region Leave
        public static IWebElement GetLeave(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Leave_Path));
        }
        public static void ClickLeave(IWebDriver wd)
        {
            GetLeave(wd).Click();
        }
        #endregion

        //Getting and clciking Training
        #region Training
        public static IWebElement GetTraining(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Training_Path));
        }
        public static void ClickTraining(IWebDriver wd)
        {
            GetTraining(wd).Click();
        }
        #endregion

        //Getting and clicking Staff
        #region Staff
        public static IWebElement GetStaff(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Staff_Path));
        }
        public static void ClickStaff(IWebDriver wd)
        {
            GetStaff(wd).Click();
        }
        #endregion

        //Getting and clicking Payroll
        #region Payroll
        public static IWebElement GetPayroll(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Payroll_Path));
        }
        public static void ClickPayroll(IWebDriver wd)
        {
            GetPayroll(wd).Click();
        }
        #endregion

        //Getting and clicking Reports
        #region Reports
        public static IWebElement GetReports(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Reports_Path));
        }
        public static void ClickReports(IWebDriver wd)
        {
            GetReports(wd).Click();
        }
        #endregion

        //Getting and clicking Settings Button
        #region SettingsButton
        public static IWebElement GetSettingsButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_Button_Path));
        }
        public static void ClickSettingsButton(IWebDriver wd)
        {
            GetSettingsButton(wd).Click();
        }
        #endregion
    }
}
