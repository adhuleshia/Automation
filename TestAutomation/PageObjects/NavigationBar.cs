namespace TestAutomation.PageObjects
{
    using OpenQA.Selenium;

    class NavigationBar
    {
        public IWebElement Logo => _driver.FindElement(By.CssSelector("a[data-testid='asoslogo']"));
        private IWebDriver _driver;

        public NavigationBar(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
