using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestAutomation.PageObjects;
using static TestAutomation.PageObjects.DesktopsPage;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class Navigation
    {
        //Declare private variables
        //To-do refactor and move driver to driver context
        private IWebDriver _driver;
        private NavigationBar NavBar => new NavigationBar(_driver);
        private DesktopsPage DeskPage => new DesktopsPage(_driver);
        private BooksPage BookPage => new BooksPage(_driver);


        private ScenarioContext _scenarioContext;

        public Navigation(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }
        [Given(@"an ecommerce website")]
        public void GivenAnEcommerceWebsite()
        {
           //Pass URL from seperate Data file or environment config
        }

        [Given(@"site sells desktop computers")]
        public void GivenSiteSellsDesktopComputers()
        {
            //Get list of computer on site, get quantity and description
        }

        [Given(@"site sells books")]
        public void GivenSiteSellsBooks()
        {
            // Get list of books on site, get quantity and description
        }

        [Given(@"customer navigated to website")]
        public void GivenCustomerNavigatedToWebsite()
        {
            _driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"navigated to Desktops page using menu item Computers > Desktops")]
        public void GivenNavigatedToDesktopsPageUsingMenuItemComputersDesktops()
        {
            NavBar.HoverMainMenuAndClickChild(NavBar.ComputersMenuOption, NavBar.DesktopsMenuOption);
        }

        [Given(@"sorted items Price Low to High")]
        public void GivenSortedItemsPriceLowToHigh()
        {
            DeskPage.SelectSortByOption(SortOption.priceLowToHigh);
        }

        [Given(@"customer clicks Add on first in the list")]
        public void GivenCustomerClicksAddOnFirstInTheList()
        {
           // Add zeroth index item from the list of IWebElements
            DeskPage.AddDesktopItemsToCart(0);
        }

        [When(@"customer click Add on first (.*) in the list")]
        public void WhenCustomerClickAddOnFirstInTheList(string p0)
        {
            // Add zeroth index item from the list of IWebElements
            BookPage.AddBooksItemsToCart(0);
        }

        [When(@"customer clicks Add on first in the list")]
        public void WhenCustomerClicksAddOnFirstInTheList()
        {
            //Add zeroth index item from the list of IWebElements
            DeskPage.AddDesktopItemsToCart(0);
        }


        [When(@"clicks on Shopping cart link from pop-up window")]
        public void WhenClicksOnShoppingCartLinkFromPop_UpWindow()
        {
            DeskPage.ClickShoppingCarLinkFromNotifBar();
        }

        [Given(@"customer navigated to Books page using menu item Books")]
        public void GivenCustomerNavigatedToBooksPageUsingMenuItemBooks()
        {
            NavBar.BooksMenuOption.Click();
        }

        [Given(@"customer's shopping cart has (.*) First in list at price (.*)")]
        public void GivenCustomerSShoppingCartHasFirstInListAtPrice(int p0, Decimal p1)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"added (.*) book item of price \$(.*) to shopping cart")]
        public void GivenAddedBookItemOfPriceToShoppingCart(int p0, Decimal p1)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"added (.*) computer item of price \$(.*) to shopping cart")]
        public void GivenAddedComputerItemOfPriceToShoppingCart(int p0, string p1)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"total of shopping cart is \$(.*)")]
        public void GivenTotalOfShoppingCartIs(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"customer clicks on Remove for (.*) book item in the list")]
        public void WhenCustomerClicksOnRemoveForBookItemInTheList(int p0)
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
