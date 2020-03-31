using NLog.Fluent;
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
        [Then(@"shopping cart page has (.*) (.*)")]
        [Then(@"cart has (.*) of (.*)")]
        [Then(@"the shopping cart has (.*) of (.*)")]
        public void ThenTheShoppingCartHasOf(string p0, string p1)
        {
            VerifyCartItems(p0, p1);
        }

        private void VerifyCartItems(string p0, string p1)
        {
            Log.Info("Entering");
            Assert.IsTrue(CartPage.GetAllColumnRows(ShoppingCartPage.ColumnHeaders.qty).FirstOrDefault().Equals(p0), "Quantity value is not equal to {0}", p0);
            Assert.IsTrue(CartPage.GetAllColumnRows(ShoppingCartPage.ColumnHeaders.productTitle).Contains(p1), "The item selected on page does not exists in cart");
        }

        [Then(@"Total is \$(.*)")]
        [Then(@"total of shopping cart is \$(.*)")]
        public void ThenTotalOfShoppingCartIs(string p0)
        {
            Assert.IsTrue(CartPage.GetOrderTotalValue().Equals(p0), "Card total is not equal to {0}", p0);
        }



    }
}
