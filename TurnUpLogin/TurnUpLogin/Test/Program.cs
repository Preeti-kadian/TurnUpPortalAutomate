using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpLogin.Utilities;
using TurnUpLogin.Pages;

namespace TurnUpPortal
{
    [TestFixture]
    class Program : CommonDriver
    {

            [SetUp]
            public void LoginSteps()
            {
            //Open chrome browser
            driver = new ChromeDriver();

                //Object for login page
                LoginPage loginObj = new LoginPage();
                loginObj.LoginActions(driver);

                //Object for Home page
                HomePage homeObj = new HomePage();
                homeObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);
        }
        
        [Test]
        public void UpdateTMTest()
        {
            TMPage tmObj = new TMPage();
            tmObj.UpdateTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }


        [TearDown]
            public void ClearTestRun()
            {
            driver.Quit();
            }


        }
    }
