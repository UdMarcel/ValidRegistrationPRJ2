using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ValidRegistrationPRJ2.PageObject
{
    [Binding]
    public class HooksRegistration
    {
        //public static IWebdriver driver;
        public static IWebDriver driver;

        [BeforeScenario("@tag1")] 
        public void BeforeScenarioWithTag()
        {
            //driver = new Chromedriver();

            //driver.Manage().Window.Maximize();

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {


            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}
