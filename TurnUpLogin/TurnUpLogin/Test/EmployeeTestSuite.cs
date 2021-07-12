using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpLogin.Pages;
using TurnUpLogin.Utilities;

namespace TurnUpLogin.Test
{
  [TestFixture]
  [Parallelizable]
    public class EmployeeTestSuite : CommonDriver
    {
        

        [Test]
        public void CreateEmployeeTest()
        {
            //navigate home page to employee module
            //Object for employee page

            HomePage homeObj = new HomePage();
            homeObj.GoToEmployeePage(driver);
            //Test- Create new employee entry
            EmployeePage employeeObj = new EmployeePage();
            employeeObj.CreateEmployee(driver);
        }

        [Test]
        public void UpdateEmployeeTest()
        {
            //navigate home page to employee module
            //Object for employee page

            HomePage homeObj = new HomePage();
            homeObj.GoToEmployeePage(driver);

            // Update created employee entry
            EmployeePage employeeObj = new EmployeePage();
            employeeObj.UpdateEmployee(driver);
        }

        [Test]
        public void DeleteEmployeeTest()
        {
            //navigate home page to employee module
            //Object for employee page

            HomePage homeObj = new HomePage();
            homeObj.GoToEmployeePage(driver);

            //delete updated employee entry
            EmployeePage employeeObj = new EmployeePage();
            employeeObj.DeleteEmployee(driver);
        }


    


    }
}
