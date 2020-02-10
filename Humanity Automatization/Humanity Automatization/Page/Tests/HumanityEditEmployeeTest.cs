using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Humanity_Automatization.Page.Objects;
using Humanity_Automatization.Page.Tests;
using System.Diagnostics;
using System.Threading;

namespace Humanity_Automatization.Page.Tests
{
    public class HumanityEditEmployeeTest
    {
        public static void EditEmployee()
        {
            #region ReachingEmployee
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            wd.Navigate().GoToUrl(HumanityLoginPage.Humanity_Login_URL);
            HumanityLoginTests.FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani");
            HumanityLoginPage.ClickLoginButton(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HumanityMenu.ClickStaff(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            #endregion

            #region EditingEmployee
            HumanityStaff.ClickEmployee1(wd);
            //Was reaching Employee page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityStaff.Employee1_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityEditStaff.ClickEditDetails(wd);
            //Was reaching Edit Employee page successful?
            #region Pass/Fail
            if (wd.Url.Contains(HumanityEditStaff.Edit_Staff_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            HumanityEditStaff.SendNickName(wd, "Safi");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            HumanityEditStaff.SendUploadPicture(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            HumanityEditStaff.ClickSaveEmployee(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            wd.Quit();
            #endregion
        }
    }
 }