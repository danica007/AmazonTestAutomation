using OpenQA.Selenium;
using System.Collections.Generic;

namespace AmazonTestAutomation.Src.Pages
{
    class SearchResultPage : AbstractPage
    {
        private IWebElement PageIdentifier;
        private IList<IWebElement> SearchResults;
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
           
        }

        protected override void InitElements()
        {
            PageIdentifier = driver.FindElement(By.CssSelector("span[class='a-color-state a-text-bold']"));
            SearchResults = driver.FindElements((By.CssSelector("a[class='a-link-normal s-no-outline']")));            
        }

        public bool VerifyResultPageBySearchText(string searchText) 
        { 
            return VerifyPageIsLoaded() && PageIdentifier.Text.Contains(searchText);
        }

        public override bool VerifyPageIsLoaded()
        {
            InitElements();
            return PageIdentifier.Displayed;
        }

        public void selectItemByIndex(int index)
        {
            IWebElement item = SearchResults[index];
            item.Click();
        }
    }
}
