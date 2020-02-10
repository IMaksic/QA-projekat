using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Humanity_Automatization.Page.Objects;
using Humanity_Automatization.Page.Tests;
using IronXL;
using System.Diagnostics;
using System.Threading;

namespace Humanity_Automatization.Page.Tests
{
    public class HumanityAddNewEmployeeTests
    {
        public static void AddNewEmployee()
        {
            #region ReachingAddingEmployees
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            ExcelUtility.OpenFile(Constants.Excel_Path);
            ExcelUtility.LoadWorkSheet(0);

            wd.Navigate().GoToUrl(HumanityLoginPage.Humanity_Login_URL);
            HumanityLoginTests.FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani");
            HumanityLoginPage.ClickLoginButton(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityMenu.ClickStaff(wd);
            //Was reaching Staff page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityStaff.Staff_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion
            #endregion
            #region AddNewEmployee
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityStaff.ClickAddEmployees(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Was reaching Add Employee page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityStaff.Add_Employee_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion
            Thread.Sleep(3000);
            FillOutNewEmployee(wd, "Stefan", "Nikolic", "stefannikolic@gmail.com");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            HumanityStaff.ClickSaveNewEmployee(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            wd.Quit();
        }
        #endregion
        #region Fillout
        public static void FillOutNewEmployee(IWebDriver wd, string firstName, string lastName, string email)
         {
             HumanityStaff.SendEmployeeFirstName(wd, firstName);
             HumanityStaff.SendEmployeeLastName(wd, lastName);
             HumanityStaff.SendEmployeeEmail(wd, email);
         }
        #endregion
        #region AutoAddMultipleEmployees
        public static void AutoAddMultipleEmployees()
        {
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            ExcelUtility.OpenFile(Constants.Excel_Path);
            ExcelUtility.LoadWorkSheet(0);

            wd.Navigate().GoToUrl(HumanityLoginPage.Humanity_Login_URL);
            HumanityLoginTests.FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani");
            HumanityLoginPage.ClickLoginButton(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityMenu.ClickStaff(wd);
            //Was reaching Staff page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityStaff.Staff_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityStaff.ClickAddEmployees(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Was reaching Add Employee page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityStaff.Add_Employee_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion

            for (int i = 1; i < 4; i++)
            {
                string firstName = ExcelUtility.GetDataAt(i, 0);
                string lastName = ExcelUtility.GetDataAt(i, 1);
                string email = ExcelUtility.GetDataAt(i, 3);



                wd.FindElement(By.XPath(HumanityStaff.Employee_First_NamePT1_Path + i + HumanityStaff.PT2_Path)).SendKeys(firstName);
                // Thread.Sleep(3000);
                wd.FindElement(By.XPath(HumanityStaff.Employee_Last_NamePT1_Path + i + HumanityStaff.PT2_Path)).SendKeys(lastName);
                // Thread.Sleep(3000);
                wd.FindElement(By.XPath(HumanityStaff.Employee_EmailPT1_Path + i + HumanityStaff.PT2_Path)).SendKeys(email);
                Thread.Sleep(3000);
            }
            Thread.Sleep(3000);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityStaff.ClickSaveNewEmployee(wd);
            Thread.Sleep(3000);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wd.Quit();
        }
        #endregion;
    }
}
