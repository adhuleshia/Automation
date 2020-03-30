namespace TestAutomation.Hooks
{
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;

    [Binding]
    public class Hooks
    {
        public IWebDriver Driver;

        public Hooks(IWebDriver driver)
        {
            Driver = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }

    }
}

