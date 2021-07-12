using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using NUnit.Framework;
using TurnUpLogin.Pages;

namespace TurnUpLogin.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            //Open chrome browser   
            driver = new ChromeDriver();

            //Object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);


        }

        [OneTimeTearDown]
        public void ClearTestRun()
        {
            driver.Quit();
        }




    }   } 