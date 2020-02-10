using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization.Page.Objects
{
    public class HumanitySettings
    {
        public static readonly string Country_Path = "//select[@id='country']";
        public static readonly string Default_Language_Path = "//select[@name='language']";
        public static readonly string Time_Format_Path = "//select[@name='language']";
        public static readonly string Settings_URL = "https://safisorinc.humanity.com/app/admin/settings/";
        public static readonly string Save_Settings_Path = "//button[@id='_save_settings_button']";

        public static void NavigateTo(IWebDriver wd)
        {
            HumanityLoginTests.LoginToHumanity();
            HumanityMenu.ClickSettingsButton(wd);
        }

        //Getting and selecting Country
        #region Country
        public static IWebElement GetCountry(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Country_Path));
        }
        public static void SelectCountry(IWebDriver wd, string country)
        {
            SelectElement newCountry = new SelectElement(GetCountry(wd));
            newCountry.SelectByText(country);
        }
        #endregion

        //Getting and selecting Default Language
        #region Default Language
        public static IWebElement GetDefaultLanguage(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Default_Language_Path));
        }
        public static void SelectDefaultLanguage(IWebDriver wd, string language)
        {
            SelectElement newLanguage = new SelectElement(GetDefaultLanguage(wd));
            newLanguage.SelectByText(language);
        }
        #endregion

        //Getting and selecting Time Format
        #region TimeFormat
        public static IWebElement GetTimeFormat(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Time_Format_Path));
        }
        public static void SelectTimeFormat(IWebDriver wd, string timeFormat)
        {
            SelectElement newTimeFormat = new SelectElement(GetTimeFormat(wd));
            newTimeFormat.SelectByText(timeFormat);
        }
        #endregion

        //Getting and clicking Save Settings
        #region SaveSettings
        public static IWebElement GetSaveSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Save_Settings_Path));
        }
        public static void ClickSaveSettings(IWebDriver wd)
        {
            GetSaveSettings(wd).Click();
        }
        #endregion
    }
}
