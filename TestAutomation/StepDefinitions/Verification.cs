namespace TestAutomation.StepDefinitions
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using PageObjects;
    using TechTalk.SpecFlow;

    [Binding]
    public class TestStepDefinition
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public TestStepDefinition(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Then(@"the page should be displayed")]
        public void ThenThePageIsDisplayed()
        {
            var page = _scenarioContext["pageName"];
            Assert.AreEqual($"https://www.asos.com/{page}/", _driver.Url);
        }

    }
}


