using AmazonTestAutomation.Src.Pages;
using OpenQA.Selenium;
using System;

namespace AmazonTestAutomation.Src.Application
{
    class Amazon
    {
        private HomePage homePage;
        private SearchResultPage resultPage;
        private ItemInformation itemInformation;

        public Amazon(IWebDriver driver) 
        {            
            homePage = new HomePage(driver);
            resultPage = new SearchResultPage(driver);
            itemInformation = new ItemInformation(driver);
        }

        public void searchItem(string itemName)
        {            
            homePage.LoadUrl();

            if (homePage.VerifyPageIsLoaded())
            {
                homePage.SearchItem(itemName);
            }
            else 
            {
                throw new AppDomainUnloadedException("WebPage application is not loading the home page as expected.");
            }
        }

        public void selectItemByIndexFromResults(string itemName, int index) 
        {
            if (resultPage.VerifyResultPageBySearchText(itemName))
            {
                resultPage.selectItemByIndex(index);
            }
            else 
            {
                throw new AppDomainUnloadedException("WebPage application is not loading the result page as expected.");
            }
        }

        public Decimal getItemPrice()
        {
            if (itemInformation.VerifyPageIsLoaded())
            {
                return itemInformation.getItemPrice();
            }
            else 
            {
                throw new AppDomainUnloadedException("WebPage application is not loading the item information page as expected.");
            }
        }

    }
}
