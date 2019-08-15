using AHW2;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

/*
  Open gismeteo.ua
1. Find all divs on the page
//div

2. Find all divs with h2 class
//*[@class="_line timeline clearfix"]

3. Find all items with news titles(the block under list of cities)(х items)
//div[@class="readmore_item"]

4. Find the last span with news title
//div[@class="readmore_list"]/div[last()]

5. Get all titles from items from #3
//div[@class="readmore_title nolink white"]

6. Find element with text Киев
//*[contains(text(), 'Киев')]

7. Find the element that describes city next after Киев
//div[@class="cities_list"]//*[contains(text(), 'Киев')]//..//../following-sibling::*[1]

8. Find all top menu link
//ul[@class="nav_list"]/li/a

9. On the current city weather page find element for 3 current weekdays.
 a) //ul[@class="subnav_nav"]/li[3]/a
 b) //div[@class="forecast_frame dw_wrap js_widget"]

10. Find element for currently selected weekday
//div[@class="weather_now"]

11. Find temperature when it's Малооблачно (1 element!!)
//div[@class="description gray"]
12. Find the same elements, but using CSS where possible
$$(".content_wrap")
$$("div.content_wrap")
*/

/*
 * Part2
Create new test class and implement the following scenario:
- Open 'wizzair.com'
- Search for flights from Kiev to Copenhagen for 1 adult person for the nearest date (one way)
- Ensure that correct flight is displayed in search results
- Verify:
 	  flight date
 	  arrival/destination points
  correct date is selected
 	  3 options with different prices are displayed, check prices
 	  return flights are not displayed

- Select one of the proposed offers 
- On the PASSENGERS page enter the first, last name, select Male/Female 
- Verify that route is correct on the top of the page
- Select any luggage option
- Click Continue
- Verify that Sign in dialog is displayed

Use ChromeDriver
!!!! Do NOT use data-test attribute to create element locators
 */
namespace AHW2
{
    public class WizzairTest
    {
        private string FNamePassenger = "Olivia";
        private string LNamePassenger = "Wilde";
        private string _wizzairUrl = "https://wizzair.com";
        private IWebDriver _driver = new ChromeDriver();
        private WebDriverWait _wait;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            _driver.Navigate().GoToUrl(_wizzairUrl);
        }

        [Test]
        public void TestWizzair()
        {
            Locator _ = new Locator();
            string PointOfDeparture = "Kyiv";
            string PointOfDestination = "Copenhagen";
            
            Assert.IsTrue(WaitUntilDisplayed(_.Departure));

            SetDeparture(_.Departure, PointOfDeparture);
            SetDestination(_.Destination, PointOfDestination);

            FindElement(_.SelectDepartureDate);

            FindElement(_.SelectDepartureDate).Click();
            ElementInvisibility(_.LoadingElement);
            WaitUntilDisplayed(_.AvailableDays);
            _driver.FindElements(_.AvailableDays)[2].Click();
            ElementIsVisible(_.LoadingElement);
            ElementInvisibility(_.LoadingElement);
            FindElement(_.OneWayOnlyLink).Click();
            FindElement(_.OKButton).Click();
            WaitUntilDisplayed(_.SearchButton);
            FindElement(_.SearchButton).Click();

            if (_driver.WindowHandles.Count > 1)
            {
                _driver.SwitchTo().Window(_driver.WindowHandles.First()).Close();
                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            }

            ElementInvisibility(_.LoadingElement);

            new VerifyRoute(FindElement(_.CurrentRoute).Text, PointOfDeparture, PointOfDestination);
            Assert.IsTrue(WaitUntilDisplayed(_.ShowReturnFlightsLink));
            FindElement(_.ShowPricesLink).Click();

            Assert.IsTrue(WaitUntilDisplayed(_.WizzPlusSection));
            Assert.IsTrue(WaitUntilDisplayed(_.WizzGoSection));
            Assert.IsTrue(WaitUntilDisplayed(_.BasicSection));

            Assert.IsTrue(FindElement(_.WizzPlusSectionPrice).Text.Length > 3);
            Assert.IsTrue(FindElement(_.WizzGoSectionPrice).Text.Length > 3);
            Assert.IsTrue(FindElement(_.BasicSectionPrice).Text.Length > 3);

            WaitUntilDisplayed(_.AvailablePricesButton);
            var availablePricesButton = _driver.FindElements(_.AvailablePricesButton);
            ElementIsVisible(_.CloseButton);
            FindElement(_.CloseButton).Click();

            Actions actions = new Actions(_driver);
            actions.MoveToElement(availablePricesButton[1]).Click(availablePricesButton[1]).Perform();
            _wait.Until(ExpectedConditions.ElementToBeClickable(_.ContinueButton));
            FindElement(_.ContinueButton).Click();
            ElementInvisibility(_.LoadingElement);

            //Uncomment if exist seats choice
            //ElementInvisibility(_.LoadingElement);
            //By RecommendedSeats = By.XPath("//button[contains(text(), 'Accept recommended seats')]");
            //ElementIsVisible(RecommendedSeats);
            //FindElement(RecommendedSeats).Click();

            _driver.Navigate().GoToUrl(_driver.Url);
            ElementIsVisible(_.FirstName);
            SetDataPassenger(_.FirstName, FNamePassenger);
            SetDataPassenger(_.LastName, LNamePassenger);

            ElementInvisibility(_.LoadingElement);
            ElementIsVisible(_.Sex);
            _wait.Until(x => x.FindElement(_.Sex).Enabled);
            
            FindElement(_.Sex).Click();
            _driver.FindElements(_.AvailableBaggage)[2].Click();

            ElementInvisibility(_.LoadingElement);
            _wait.Until(x => x.FindElement(_.PassengersContinueButton).Enabled);

            new VerifyRoute(FindElement(_.Way).Text, PointOfDeparture, PointOfDestination);

            ElementInvisibility(_.LoadingElement);
            ElementIsVisible(_.PassengersContinueButton);
            FindElement(_.PassengersContinueButton).Click();

            ElementIsVisible(_.SingMode);
            Assert.IsTrue(WaitUntilDisplayed(_.SingMode));
        }

        public IWebElement FindElement(By locator)
        {
            return this._driver.FindElement(locator);
        }

        private void SetDeparture(By locator, string pointOfDeparture)
        {
            IWebElement departure = FindElement(locator);
            departure.Clear();
            departure.SendKeys(pointOfDeparture);
            departure.SendKeys(Keys.Enter);
        }

        private void SetDestination(By locator, string pointOfDestination)
        {
            IWebElement destination = FindElement(locator);
            destination.SendKeys(pointOfDestination);
            destination.SendKeys(Keys.Enter);
        }

        private void SetDataPassenger(By locator, string namePassenger)
        {
            WaitUntilDisplayed(locator);
            var NameField = FindElement(locator);
            NameField.SendKeys(namePassenger);
            NameField.SendKeys(Keys.Enter);
        }

        public bool WaitUntilDisplayed(By locator)
        {
            return this._wait.Until(x => x.FindElement(locator).Displayed);
        }

        public IWebElement ElementIsVisible(By locator)
        {
            return this._wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void ElementInvisibility(By locator)
        {
            this._wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}