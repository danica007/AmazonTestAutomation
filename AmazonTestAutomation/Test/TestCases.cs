using AmazonTestAutomation.Src.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AmazonTestAutomation
{
    [TestClass]
    public class TestCases
    {
        private IWebDriver driver;
        private Amazon amazon;
        

        [TestInitialize]
        public void InitializeBrowser() 
        {
            driver = new ChromeDriver(@"C:\Driver");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            amazon = new Amazon(driver);
        }

        [TestMethod]
        public void TestAssertPrice()
        {
            string laptop = "laptop";
            amazon.SearchItem(laptop);
            amazon.SelectItemByIndexFromResults(laptop, 0);
            decimal price = amazon.GetItemPrice();

            Assert.IsTrue(price > 100, "Laptop price should be more than $100");
        }

        [TestCleanup]
        public void CloseBrowser() 
        {
            driver.Close();
        }
    }
}
