using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpLogin.Utilities;
using TurnUpLogin.Pages;

namespace TurnUpPortal
{
    [TestFixture]
    [Parallelizable]
    class Program : CommonDriver
    {
          
      
    

        [Test]
        public void CreateTMTest()
        {
            //Test navigation to Time and Material module
            //Object for Home page
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            //Test-Create new TM entry
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);
        }
        
        [Test]
        public void UpdateTMTest()
        {
            //Test navigation to Time and Material module
            //Object for Home page
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            //Test-Update new TM entry
            TMPage tmObj = new TMPage();
            tmObj.UpdateTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            //Test navigation to Time and Material module
            //Object for Home page
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            //Test-Delete updated TM entry
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }
            

        }
    }
