using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomation.PageObjects;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class Verification
    {

        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        private ShoppingCartPage CartPage => new ShoppingCartPage(_driver);
        public Verification(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }


        [Then(@"the shopping cart has (.*) of (.*)")]
        public void ThenTheShoppingCartHasOf(string p0, string p1)
        {
            Assert.IsTrue(CartPage.CountItems(p1).ToString().Equals(p0), "Cart quantity value is not equal to {0}", p0);
            Assert.IsTrue(CartPage.GetColumnRowByIndex(ShoppingCartPage.ColumnHeaders.productTitle, 1)
                .Contains(p1), "The item selected on desktop page does not exists in cart");
        }


        [Then(@"cart has (.*) of (.*)")]
        public void ThenCartHasOf(string p0, string p1)
        {
            Assert.IsTrue(CartPage.CountItems(p1).ToString().Equals(p0), "Cart quantity value is not equal to {0}", p0);
            Assert.IsTrue(CartPage.GetColumnRowByIndex(ShoppingCartPage.ColumnHeaders.productTitle, 1)
                .Contains(p1), "The item selected on book page does not exists in cart");
        }

        [Then(@"Total is \$(.*)")]
        public void ThenTotalIs(string p0)
        {
            Assert.IsTrue(CartPage.GetOrderTotalValue().Equals(p0), "Cart total is not equal to {0}", p0);
        }


        [Then(@"shopping cart page has (.*) (.*)")]
        public void ThenShoppingCartPageHas(string p0, string p1)
        {
            Assert.IsTrue(CartPage.CountItems(p1).ToString().Equals(p0), "Cart quantity value is not equal to {0}", p0);
            Assert.IsTrue(CartPage.GetColumnRowByIndex(ShoppingCartPage.ColumnHeaders.productTitle, 1)
                .Contains(p1), "The item selected on book page does not exists in cart");
        }
        [Then(@"total of shopping cart is \$(.*)")]
        public void ThenTotalOfShoppingCartIs(string p0)
        {
            Assert.IsTrue(CartPage.GetOrderTotalValue().Equals(p0), "Card total is not equal to {0}", p0);
        }



    }
}
