using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization.Page.Objects
{
    class HumanityEditStaff
    {
        public static readonly string Save_Employee_Path = "//button[@id='act_primary']";
        public static readonly string Edit_Details_Path = "//a[contains(text(),'Edit Details')]";
        public static readonly string Upload_Picture_Path = "//input[@id='fileupload']";
        public static readonly string Nick_Name_Path = "//input[@id='nick_name']";
        public static readonly string Edit_Staff_URL = "https://safisorinc.humanity.com/app/staff/edit/5309025/";
        public static void NavigateTo(IWebDriver wd)
        {
            HumanityLoginTests.LoginToHumanity();
            HumanityMenu.ClickStaff(wd);
            HumanityStaff.ClickEmployee1(wd);
        }

        //Getting and clicking Edit Details
        #region EditDetails
        public static IWebElement GetEditDetails(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Edit_Details_Path));
        }
        public static void ClickEditDetails(IWebDriver wd)
        {
            GetEditDetails(wd).Click();
        }
        #endregion

        //Getting and clicking Upload Picture
        #region UploadPicture
        public static IWebElement GetUploadPicture(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Upload_Picture_Path));
        }
        public static void SendUploadPicture(IWebDriver wd)
        {
            GetUploadPicture(wd).SendKeys(Constants.Picture_Path);
        }
        #endregion

        //Getting and sending Nick Name
        #region NickName
        public static IWebElement GetNickName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Nick_Name_Path));
        }
        public static void SendNickName(IWebDriver wd,string nickName)
        {
            GetNickName(wd).SendKeys(nickName);
        }
        #endregion

        //Getting and clicking Save Employee
        #region SaveEmployee
        public static IWebElement GetSaveEmployee(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Save_Employee_Path));
        }
        public static void ClickSaveEmployee(IWebDriver wd)
        {
            GetSaveEmployee(wd).Click();
        }
        #endregion
    }
}
