using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Humanity_Automatization.Page.Objects;
using Humanity_Automatization.Page.Tests;

namespace Humanity_Automatization
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Main
            int choice;
            bool exit = false;
            do
            {
                PrintMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Chose exit.");
                            exit = true;
                            break;
                        }
                    case 1:
                        Console.WriteLine("Test logging in to humanity with correct info.");
                        HumanityLoginTests.LoginToHumanity();
                        break;
                    case 2:
                        Console.WriteLine("Automatic test logging in to humanity with incorrect info.");
                        HumanityLoginTests.AutomaticLoginToHumanity();
                        break;
                    case 3:
                        Console.WriteLine("Adding one new employee.");
                        HumanityAddNewEmployeeTests.AddNewEmployee();
                        break;
                    case 4:
                        Console.WriteLine("Adding multiple new employees.");
                        HumanityAddNewEmployeeTests.AutoAddMultipleEmployees();
                        break;
                    case 5:
                        Console.WriteLine("Edditing employee.");
                        HumanityEditEmployeeTest.EditEmployee();
                        break;
                    case 6:
                        Console.WriteLine("Changing Settings.");
                        HumanitySettingsTest.ChangingSettings();
                        break;
                    case 7:
                        Console.WriteLine("Signing out of Humanity.");
                        HumanitySignOutTest.SigningOut();
                        break;
                }
            }
            while (!exit);
            #endregion
        }
        #region PrintMenu
        static void PrintMenu()
        {
            Console.WriteLine("0 - Exit.");
            Console.WriteLine("1 - Logging in to Humanity.");
            Console.WriteLine("2 - Automatic logging in to Humanity with wrong info.");
            Console.WriteLine("3 - Add new employee.");
            Console.WriteLine("4 - Auto add multiple new employees.");
            Console.WriteLine("5 - Edit Employee.");
            Console.WriteLine("6 - Change Settings.");
            Console.WriteLine("7 - Sign Out.");
        }
        #endregion
    }
}
