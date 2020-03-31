namespace TestAutomation.Hooks
{
    using NUnit.Framework;
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
            TestContext.WriteLine();
            Driver.Quit();
        }

    }
}

