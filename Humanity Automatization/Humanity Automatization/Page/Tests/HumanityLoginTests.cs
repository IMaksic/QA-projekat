using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Humanity_Automatization.Page.Objects;
using System.Diagnostics;
using IronXL;
using System.Threading;

namespace Humanity_Automatization.Page.Tests
{
    public class HumanityLoginTests
    {
        #region LoginToHumanity
        public static void LoginToHumanity()
        {
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            HumanityLoginPage.NavigateTo(wd);

            //Was reaching login page successful?
            #region Pass/Fail1
            if (wd.Url.Contains(HumanityLoginPage.Humanity_Login_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion

            FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani"); HumanityLoginPage.ClickLoginButton(wd);

            //Was loggin in successful?
            #region Pass/Fail2
            if (wd.Url.Contains(HumanityMenu.Humanity_Menu_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            #endregion

            wd.Quit();
        }
        #endregion
        #region FillOut
        public static void FillOutLogin(IWebDriver wd, string loginEmail, string loginPassword)
        {
            HumanityLoginPage.SendLoginEmail(wd, loginEmail);
            HumanityLoginPage.SendLoginPassword(wd, loginPassword);
        }
        #endregion
        #region AutomaticLoginToHumanity
        public static void AutomaticLoginToHumanity()
        {
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            ExcelUtility.OpenFile(Constants.Excel_Path);
            ExcelUtility.LoadWorkSheet(0);

            
            string loginEmail = ExcelUtility.GetDataAt(1, 3);
            string loginPassword = ExcelUtility.GetDataAt(1, 10);
            HumanityLoginPage.NavigateTo(wd);
            //Was reaching login page successful?
            #region Pass/Fail1
                if (wd.Url.Contains(HumanityLoginPage.Humanity_Login_URL))
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
                #endregion

            FillOutLogin(wd, loginEmail, loginPassword);
            HumanityLoginPage.ClickLoginButton(wd);
            //Was test with invalid info successful?
            #region Pass/Fail2
                if (wd.Url.Contains(HumanityLoginPage.Humanity_Login_URL))
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            #endregion
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Thread.Sleep(3000);
            wd.Quit();
        }
        #endregion
    }
}
