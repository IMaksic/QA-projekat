using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Humanity_Automatization.Page.Tests;
using Humanity_Automatization.Page.Objects;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanityStaff
    {
        public static int i = 1;
        public static readonly string Add_Employees_Path = "//button[@id='act_primary']";
        public static readonly string Employee1_Path = "//a[contains(@class,'staff-employee')]";
        public static readonly string Employee_First_NamePT1_Path = "//input[@id='_asf";
        public static readonly string Employee_Last_NamePT1_Path = "//input[@id='_asl";
        public static readonly string Employee_EmailPT1_Path = "//input[@id='_ase";
        public static readonly string PT2_Path = "']";
        public static readonly string Save_New_Employee_Path = "//button[@id='_as_save_multiple']";
        public static readonly string Staff_URL = "https://safisorinc.humanity.com/app/staff/list/load/true/";
        public static readonly string Add_Employee_URL = "https://safisorinc.humanity.com/app/staff/add/";
        public static readonly string Employee1_URL = "https://safisorinc.humanity.com/app/staff/detail/5309025/";

        public static void NavigateTo(IWebDriver wd)
        {
            HumanityLoginTests.LoginToHumanity();
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            HumanityMenu.ClickStaff(wd);
        }

        //Getting and clicking Add Employees
        #region AddEmployees
        public static IWebElement GetAddEmployees(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Add_Employees_Path));
        }
        public static void ClickAddEmployees(IWebDriver wd)
        {
            GetAddEmployees(wd).Click();
        }
        #endregion

        //Getting and clicking Employee 1
        #region Employee1
        public static IWebElement GetEmployee1(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee1_Path));
        }
        public static void ClickEmployee1(IWebDriver wd)
        {
            GetEmployee1(wd).Click();
        }
        #endregion

        //Getting and clicking Save New Employee
        #region SaveNewEmployee
        public static IWebElement GetSaveNewEmployee(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Save_New_Employee_Path));
        }
        public static void ClickSaveNewEmployee(IWebDriver wd)
        {
            GetSaveNewEmployee(wd).Click();
        }
        #endregion

        //Getting and sending First Name
        #region FirstName
        public static IWebElement GetEmployeeFirstName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee_First_NamePT1_Path + i + PT2_Path));
        }
        public static void SendEmployeeFirstName(IWebDriver wd, string firstName)
        {
            GetEmployeeFirstName(wd).SendKeys(firstName);
        }
        #endregion

        //Getting and sending Last Name
        #region Last Name
        public static IWebElement GetEmployeeLastName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee_Last_NamePT1_Path + i + PT2_Path));
        }
        public static void SendEmployeeLastName(IWebDriver wd, string lastName)
        {
            GetEmployeeLastName(wd).SendKeys(lastName);
        }
        #endregion

        //Getting and sending Email
        #region Email
        public static IWebElement GetEmployeeEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee_EmailPT1_Path + i +PT2_Path));
        }
        public static void SendEmployeeEmail(IWebDriver wd, string email)
        {
            GetEmployeeEmail(wd).SendKeys(email);
        }
        #endregion
    }
}
