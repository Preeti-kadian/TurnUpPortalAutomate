using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TurnUpLogin.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace TurnUpLogin.Pages
{
    public class EmployeePage: CommonDriver
    {
       
            //test- create employee test
        public void CreateEmployee(IWebDriver driver)
        {
           
            Wait.WaitForWebElementToExist(driver, "//*[@id='container']/p/a", "XPath", 7);

            //Identify Create button and click on create employee
            IWebElement createEmpButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createEmpButton.Click();
            Wait.WaitForWebElementToExist(driver, "Name", "ID",  7);

            //Identify name field and input value
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.SendKeys("Mike");
            Thread.Sleep(1000);

            //Identify username field and input value
            IWebElement userName = driver.FindElement(By.Id("Username"));
            userName.SendKeys("abc");
            Thread.Sleep(2000);

            //Identify contact field and input value
            //IWebElement contact  = driver.FindElement(By.Id("ContactDispaly"));
            //userName.SendKeys("123456");
            //Thread.Sleep(1000);


            //Identify password field and input value
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Qwerty12");
            Thread.Sleep(1000);

            //Identify Retype password field and input value
            IWebElement confirmPassword = driver.FindElement(By.Id("RetypePassword"));
            confirmPassword.SendKeys("Qwerty12");
            Thread.Sleep(1000);

            //Identify IsAdmin checkbox and check item
            IWebElement isAdmin = driver.FindElement(By.Id("IsAdmin"));
            isAdmin.Click();

            //Identify vehicle field and input value
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicle.SendKeys("Audi");
            Thread.Sleep(1000);

            //Identify Groups field and input value
            IWebElement groups = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groups.Click();
            Thread.Sleep(2000);
            
            IWebElement selectGroup = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[1]"));
            selectGroup.Click();
            
            Thread.Sleep(2000);

            //Identify save button and click and save
            IWebElement saveEmployeeButton = driver.FindElement(By.Id("SaveButton"));
            saveEmployeeButton.Click();
            Thread.Sleep(3000);

            //identify back to list link and click
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(2000);


            // Go to last page

            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(2000);


            //Check is employee record is created
            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(actualName.Text == "Mike", "Actual name and expected name doesnot match");
            Assert.That(actualUserName.Text == "abc", "Actual Username and expected Username doesnot match");

        }

        //test-edit employee test
        public void UpdateEmployee(IWebDriver driver)
        {
            
            Thread.Sleep(1000);
            //Go to last page     
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]","XPath", 4);

            //Click on edit button

            IWebElement editEmployeeButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
           editEmployeeButton.Click();

            //Identify name field, clear value and input new value
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.Clear();
            name.SendKeys("Josh");

            //Identify Username field, clear value and input new value
            IWebElement userName = driver.FindElement(By.Id("Username"));
            userName.Clear();
            userName.SendKeys("ab12");

            //Identify contact field, clear value and input new value
            //IWebElement contact = driver.FindElement(By.Id("ContactDispaly"));
            //contact.Clear();
            //contact.SendKeys("123");


            //Identify password field, clear value and input new value
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.Clear();
            password.SendKeys("Qwerty123");

            //Identify Retype Password field, clear value and input new value

            IWebElement confirmPassword = driver.FindElement(By.Id("RetypePassword"));
            confirmPassword.Clear();
            confirmPassword.SendKeys("Qwerty123");

            //Identify Is admin checkbox, change value
            IWebElement isAdmin = driver.FindElement(By.Id("IsAdmin"));
            isAdmin.Click();


            //Identify vehicle field, clear value and input new value
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicle.Clear();
            vehicle.SendKeys("Toyota");
            Thread.Sleep(1000);

            //Identify Groups field, clear value and select new value
            IWebElement groups = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groups.Click();
            Thread.Sleep(2000);

            IWebElement selectGroup = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[8]"));
            selectGroup.Click();
            Thread.Sleep(1000);

            //Identify Save button and click
            IWebElement saveEmployeeButton = driver.FindElement(By.Id("SaveButton"));
            saveEmployeeButton.Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='container']/div/a", "XPath", 4);


            //Identify Back to List link and click to navigate to employee page
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[4]/a[4]/span", "XPath", 5);

            //Go to last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(3000);


            //check if the value is edited

            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(editedName.Text == "Josh", "Actual name and expected name doesnot match");
            Assert.That(editedUserName.Text == "ab12", "Actual Username and expected Username doesnot match");


        }

        //test- Delete employee test
        public void DeleteEmployee(IWebDriver driver)
        {
           
            Thread.Sleep(2000);
            //Identify GO TO LAST page link and click
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Wait.WaitForWebElementToExist(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]", 4);

            //Identify and Click on delete button
            IWebElement deleteEmployeeButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteEmployeeButton.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            //Click to GO To last page
            lastPage.Click();
            Thread.Sleep(2000);

            //Check if the specified item is deleted

            IWebElement nameField = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement userNameField = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if(nameField.Text!="Josh" && userNameField.Text!="ab12")
            {
                Assert.Pass("Item deleted, Test Passed");
            }
            else
            {
                Assert.Fail("Item exists, Test failed");
            }

        }
    }
}
