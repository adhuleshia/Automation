namespace TestAutomation.StepDefinitions
{
    using OpenQA.Selenium;
    using PageObjects;
    using TechTalk.SpecFlow;

    [Binding]
    public class Navigation
    {
        private NavigationBar NavBar => new NavigationBar(_driver);
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public Navigation(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the (.*) page")]
        public void GivenINavigateToPage(string page)
        {
            _driver.Navigate().GoToUrl($"https://www.asos.com/{page}");
            _scenarioContext["pageName"] = page;
        }

        [When(@"I click the logo")]
        public void WhenIClickTheLogo()
        {
            NavBar.Logo.Click();
        }

    }
}


