using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BookingTest.Util
{
   
    [Binding]
    public class StartGenericDriver
    {
        protected IWebDriver Browser;

        [BeforeFeature]
        public static void Setup()
        {
        }
        [AfterScenario]
        public void TearDown()
        {
        }
        [AfterStep]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
            }
        }
    }
}