using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BookingTest.Configuration
{
    public class BaseUITest
    {
        public IWebDriver _driver;
        public void SetupBrowser()
        {
            _driver = new ChromeDriver("C:/NewTest/BookingTest/bin/Debug");
            _driver.Url = "https://www.booking.com";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(50);
            _driver.Manage().Window.Maximize();
        }
    }
}