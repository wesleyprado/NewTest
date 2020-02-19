using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace BookingTest.Util
{
    [Binding]
    public class GenericDriver
    {
        protected readonly ScenarioContext ScenarioContext;
        protected readonly IWebDriver Browser;
        private IWebDriver _instance;
        public IWebDriver Instance
        {
            get
            {
                Wait.Until(t => { _instance = t; return t; });
                return Instance;
            }
        }
        private WebDriverWait wait;
        public WebDriverWait Wait
        {
            get
            {
                if (wait == null)
                    wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(5));

                return wait;
            }
        }
        public void Dispose()
        {
            Browser.Close();
            Browser.Dispose();
            Browser.Quit();
        }
    }
}
