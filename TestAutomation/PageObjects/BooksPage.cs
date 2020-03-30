using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.PageObjects
{
    public class BooksPage
    {
        private IWebDriver _driver;

        public BooksPage(IWebDriver driver)
        {
            _driver = driver;
        }


        //To-Do move this to common components as it is used by DesktopsPage object
        public void AddBooksItemsToCart(int elementIndex)
        {
            _driver.FindElements(By.CssSelector(".details .add-info .buttons > input[class*=cart-button]"))
                .ElementAt(elementIndex).Click();
        }

        //To-Do move this to common component
        public void ClickShoppingCarLinkFromNotifBar()
        {
            _driver.FindElement(By.CssSelector("#bar-notification > .bar-notification > p > a")).Click();
        }
    }
}
