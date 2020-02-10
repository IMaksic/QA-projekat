using System;
using System.Collections.Generic;
using System.Text;
using Humanity_Automatization.Page.Objects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace Humanity_Automatization.Page.Tests
{
    public class HumanitySignOutTest
    {
        public static void SigningOut()
        {
            #region ReachingSignOut
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            wd.Navigate().GoToUrl(HumanityLoginPage.Humanity_Login_URL);
            HumanityLoginTests.FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani");
            HumanityLoginPage.ClickLoginButton(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            #endregion
            #region SigningOut
            try
            {
                HumanityProfile.ClickProfileMenu(wd);
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                HumanityProfile.ClickSignOut(wd);
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Was signing out successful?
                #region Pass/Fail
                if (wd.Url.Contains(HumanityHome.Humanity_Signed_Out_URL))
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
                #endregion
                Thread.Sleep(3000);
                wd.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            #endregion
        }

    }
}
