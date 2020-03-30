using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.PageObjects
{
    public class ShoppingCartPage
    {
        private IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public string baseSelectorPath = "#shopping-cart-form > .table-wrapper > table > tbody >";
        public int CountItems(string partialProductName) { 
         string countselector = baseSelectorPath + "tr > td.product > a[href*='"+partialProductName.ToLower()+"']";
         return _driver.FindElements(By.CssSelector(countselector)).Count(); }

        public string GetOrderTotalValue() { return _driver.FindElement(By.CssSelector(" tbody > tr.order-total > td.cart-total-right > span > strong")).Text.Replace("$","").Replace(",",""); }
        
        public List<string> GetProductTitle() { return _driver.FindElements(By.CssSelector(baseSelectorPath + "tr > td.product > a"))
                .Select(o => o.Text).ToList(); }
        public string GetColumnRowByIndex(ColumnHeaders _headers,int indexOfItem=1)
        {
            
            switch (_headers)
            {
                case ColumnHeaders.productTitle:
                    return _driver.FindElement(By.CssSelector(baseSelectorPath + "tr:nth-child(" + indexOfItem + ") > td.product > a")).Text;

                case ColumnHeaders.price:
                    return _driver.FindElement(By.CssSelector(baseSelectorPath + " tr:nth-child("+ indexOfItem+") > td.unit-price")).Text.Replace("$","");

                case ColumnHeaders.qty:
                    return _driver.FindElement(By.CssSelector(baseSelectorPath + "tr:nth-child("+ indexOfItem + ") > td.quantity > input")).Text;
                 default:
                    throw new ArgumentOutOfRangeException("No column header with value found");
            }
        }

        public void RemoveItemWithDetailsAtIndex(int indexOfItem,string partialProductName =null)
        {
            _driver.FindElements(By.CssSelector("input[id*=removefromcart]")).ElementAt(indexOfItem).Click();
            ClickOnUpdateShoppingCartButton();
        }
        public void ClickOnUpdateShoppingCartButton() { _driver.FindElement(By.CssSelector("#shopping-cart-form > .cart-options > .common-buttons > .update-cart-button")).Click(); }
        public enum ColumnHeaders
        {
            productTitle,
            price,
            qty,
            remove
        }
    }


}
