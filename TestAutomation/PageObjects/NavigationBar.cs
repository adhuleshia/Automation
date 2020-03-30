namespace TestAutomation.PageObjects
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    class NavigationBar
    {
        
        private IWebDriver _driver;

        public NavigationBar(IWebDriver driver)
        {
            _driver = driver;
        }

        //To-do create common component for menu options
        public IWebElement ComputersMenuOption => _driver.FindElement(By.CssSelector("a[href*='computers']"));
        public IWebElement DesktopsMenuOption => _driver.FindElement(By.CssSelector("ul.top-menu.notmobile > li > ul > li>a[href*='desktops']"));

        public IWebElement BooksMenuOption => _driver.FindElement(By.CssSelector("ul.top-menu.notmobile > li > a[href*='books']"));
        public void HoverMainMenuAndClickChild(IWebElement mainMenu, IWebElement subMenu)
        {
            //Create object 'action' of an Actions class
            Actions actions = new Actions(_driver);
            //Mouseover on an element
            actions.MoveToElement(mainMenu).Perform();
            //Sub Menu
            
            //To mouseover on sub menu
            actions.MoveToElement(subMenu);
            //build() method is used to compile all the actions into a single step 
            actions.Click().Build().Perform();
        }
    }
}
