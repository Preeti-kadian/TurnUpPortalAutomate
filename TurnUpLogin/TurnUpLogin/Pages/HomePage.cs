using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using TurnUpLogin.Utilities;

namespace TurnUpLogin.Pages
{
    
    public class HomePage: CommonDriver
    {
        IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
        


        //navigate to time and material module 
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                //Identify Administration tab and click

                administration.Click();

                //Identify Time and material module and click
                IWebElement moduleLink = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                moduleLink.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            Thread.Sleep(3000);

        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            try
            {
                //Click on Adminstration tab
                administration.Click();

                //Identify Employee module and click
                IWebElement employeeLink = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeLink.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
