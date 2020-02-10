using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Humanity_Automatization.Page.Tests;
using System.Diagnostics;
using Humanity_Automatization.Page.Objects;

namespace Humanity_Automatization.Page.Tests
{
    public class HumanitySettingsTest
    {
        public static void ChangingSettings()
        {
            #region ReachingSettings
            IWebDriver wd = new ChromeDriver(Constants.Chrome_Driver_Path);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized.");
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            wd.Navigate().GoToUrl(HumanityLoginPage.Humanity_Login_URL);
            HumanityLoginTests.FillOutLogin(wd, "safisor720@seomail.top", "pandanagrani");
            HumanityLoginPage.ClickLoginButton(wd);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            #endregion
            #region ChangingSettings
            try
            {
                HumanityMenu.ClickSettingsButton(wd);
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Was reaching Settings successful?
            #region Pass/Fail1
            if (wd.Url.Contains(HumanitySettings.Settings_URL))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
                #endregion

                HumanitySettings.SelectCountry(wd, "Israel");
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Thread.Sleep(3000);
                HumanitySettings.SelectDefaultLanguage(wd, "Hebrew (machine)");
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Thread.Sleep(3000);
                HumanitySettings.SelectTimeFormat(wd, "24 hour");
                //Thread.Sleep(3000);
                HumanitySettings.ClickSaveSettings(wd);
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            wd.Quit();
            #endregion
        }

    }
}
