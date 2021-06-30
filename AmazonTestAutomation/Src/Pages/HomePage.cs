using OpenQA.Selenium;
using System;

namespace AmazonTestAutomation.Src.Pages
{
    class HomePage : AbstractPage
    {
        private static string URL = "https://www.amazon.com/ ";

        private IWebElement SearchBar;
        private IWebElement SearchButton;

        public HomePage(IWebDriver driver) : base(driver)
        {
            driver.Url = URL;
        }

        protected override void InitElements()
        {
            SearchBar = driver.FindElement(By.Name("field-keywords"));
            SearchButton = driver.FindElement((By.Id("nav-search-submit-button")));
        }

        public void LoadUrl() 
        {
            driver.Navigate();
           
        }

        public override bool VerifyPageIsLoaded() 
        {
            InitElements();
            return SearchBar.Displayed;
        }

        public void SearchItem(String name)
        {
            SearchBar.Clear();
            SearchBar.SendKeys(name);
            SearchButton.Click();
        }

    }
}
