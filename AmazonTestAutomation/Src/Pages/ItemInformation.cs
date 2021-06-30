using OpenQA.Selenium;
using System;

namespace AmazonTestAutomation.Src.Pages
{
    class ItemInformation : AbstractPage
    {
        private IWebElement ItemSamplePictures;
        private IWebElement ItemPrice;      

        public ItemInformation(IWebDriver driver) : base(driver)
        {
         
        }

        protected override void InitElements()
        {
            ItemSamplePictures = driver.FindElement(By.CssSelector("ul[class='a-unordered-list a-nostyle a-button-list a-vertical a-spacing-top-micro'"));
            ItemPrice = driver.FindElement(By.Id("priceblock_ourprice"));
        }

        public override bool VerifyPageIsLoaded()
        {
            InitElements();
            return ItemSamplePictures.Displayed && ItemPrice.Displayed;
        }

        public Decimal getItemPrice() => Convert.ToDecimal(ItemPrice.Text.Remove(0, 1)); //remove $ sign           
    }
}
