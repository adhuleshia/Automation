using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.PageObjects
{
    public class DesktopsPage
    {
        private IWebDriver _driver;
        public DesktopsPage(IWebDriver driver)
        {
            _driver = driver;
        }
   
        public void SelectSortByOption(SortOption _options)
        {
            switch (_options)
            {
                case SortOption.position:
                    _driver.FindElement(By.CssSelector("#products-orderby > option:nth-child(1)")).Click();
                break;
                case SortOption.priceLowToHigh:
                    _driver.FindElement(By.CssSelector("#products-orderby > option:nth-child(4)")).Click();
                break;
                default:
                    throw new ArgumentOutOfRangeException("No sort options found");
            }
        }
        public enum SortOption
        {
            position,
            priceLowToHigh
        }
        public string GetTitleOfDesktopItems(int elementIndex) { return _driver.FindElements(By.CssSelector(".details > .product-title > a")).ElementAt(elementIndex).Text.ToString(); }

        //To-Do move this to common component
        public void AddDesktopItemsToCart(int elementIndex) 
        { 
            _driver.FindElements(By.CssSelector(".details .add-info .buttons > input[class*=cart-button]"))
                .ElementAt(elementIndex).SendKeys(Keys.Enter); 
        }

        //To-Do move this to common component
        public void ClickShoppingCarLinkFromNotifBar()
        {
            _driver.FindElement(By.CssSelector("#bar-notification > .bar-notification > p > a")).Click();
        }


    }
}
