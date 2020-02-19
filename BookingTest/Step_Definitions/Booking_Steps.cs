using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using BookingTest.Page_Objects;

namespace BookingTest.Step_Definitions
{
    [Binding]
    public class Booking_Steps
    {
        protected readonly ScenarioContext scenarioContext;
        protected readonly IWebDriver Browser;
        private Booking Booking;

        public Booking_Steps(ScenarioContext injectedContext)
        {
            this.scenarioContext = scenarioContext ?? throw new ArgumentNullException("scenarioContext");
        }

        [Given(@"I am in the Booking home page")]
        public void GivenIAmInTheBookingHomePage()
        {
            Booking = new Booking(Browser);
            Booking.GivenIAmInTheBookingHomePage();
        }
        [When(@"I set up the data information")]
        public void WhenISetUpTheDataInformation()
        {
            Booking.WhenISetUpTheDataInformation();
        }
        [When(@"I filter the hotels with sauna")]
        public void WhenIFilterTheHotelsWithSauna()
        {
            Booking.WhenIFilterTheHotelsWithSauna();
        }
        [When(@"I filter the hotels with 5 stars")]
        public void WhenIFilterTheHotelsWithStars()
        {
            Booking.WhenIFilterTheHotelsWithStars();
        }
        [Then(@"I check if the Limerick Strand Hotel are avaliable")]
        public void ThenICheckIfTheLimerickStrandHotelAreAvaliable()
        {
            Booking.ThenICheckIfTheLimerickStrandHotelAreAvaliable();
        }
        [Then(@"I check if the George Limerick Hotel are avaliable")]
        public void ThenICheckIfTheGeorgeLimerickHotelAreAvaliable()
        {
            Booking.ThenICheckIfTheGeorgeLimerickHotelAreAvaliable();
        }
        [Then(@"I check if the The Savoy Hotel are avaliable")]
        public void ThenICheckIfTheTheSavoyHotelAreAvaliable()
        {
            Booking.ThenICheckIfTheTheSavoyHotelAreAvaliable();
        }
    }
}
