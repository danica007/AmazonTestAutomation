using OpenQA.Selenium;
using System;

namespace AmazonTestAutomation.Src.Pages
{
    abstract class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver) {
            if (driver == null)
            {
                throw new ArgumentNullException("driver", "Driver cannot be null.");
            }

            this.driver = driver;
        }

        protected abstract void InitElements();

        public abstract bool VerifyPageIsLoaded();
    }
}
