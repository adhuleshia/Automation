namespace TestAutomation.Hooks
{
    using BoDi;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using TechTalk.SpecFlow;

    [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver = new ChromeDriver();
            //if the intital options setting fail this is workaround
            Driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(Driver);
        }

    }
}

