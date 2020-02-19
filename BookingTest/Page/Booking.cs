using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Linq;
using BookingTest.Configuration;

namespace BookingTest.Page_Objects
{
    public class Booking : BaseUITest
    {
        public string BaseLogin { get; set; }
        public Booking(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(this._driver, this);
            BaseLogin = "www.booking.com";
        }

        public void GivenIAmInTheBookingHomePage()
        {
            SetupBrowser();
            _driver.Navigate().GoToUrl(BaseLogin);
        }

        public void WhenISetUpTheDataInformation()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            var CitySearch = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ss")));
            CitySearch.SendKeys("Limerick");
            var CitySelect = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".sb-autocomplete__item-with_photo:nth-child(1)")));
            CitySearch.Click();
            var JumpToNextMonth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__control--next > svg")));
            JumpToNextMonth.Click();
            JumpToNextMonth.Click();
            JumpToNextMonth.Click();
            var SelectCheckIn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__date--selected:nth-child(3) > span > span")));
            SelectCheckIn.Click();
            var SelectCheckOut = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__date--selected:nth-child(4) > span > span")));
            SelectCheckOut.Click();
            var Search = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Pesquisar')]")));
            Search.Click();

        }

        public void WhenIFilterTheHotelsWithSauna()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            var SaunaFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#filter_popular_activities > div.filteroptions > a:nth-child(3)")));
            SaunaFilter.Click();
        }

        public void WhenIFilterTheHotelsWithStars()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            var starFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#filter_class > div.filteroptions > a:nth-child(3)")));
            starFilter.Click();

        }
        #region assert
        public void ThenICheckIfTheLimerickStrandHotelAreAvaliable()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            Boolean isPresent = _driver.FindElements(By.XPath("//*[text()[contains(.,'Limerick Strand Hotel')]]")).Count() > 0;
            Console.WriteLine(isPresent);
        }

        public void ThenICheckIfTheTheSavoyHotelAreAvaliable()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            Boolean isPresent = _driver.FindElements(By.XPath("//*[text()[contains(.,'The Savoy Hotel')]]")).Count() > 0;
            Console.WriteLine(isPresent);
        }

        public void ThenICheckIfTheGeorgeLimerickHotelAreAvaliable()
        {
            Boolean isPresent = _driver.FindElements(By.XPath("//*[text()[contains(.,'The Savoy Hotel')]]")).Count() > 0;
            Console.WriteLine(isPresent);
        }
        #endregion assert
    }
}
