using OpenQA.Selenium;

namespace AHW2
{
    public class Locator
    {
        public By Departure = By.Id("search-departure-station");
        public By Destination = By.Id("search-arrival-station");
        public By SelectDepartureDate = By.Id("search-departure-date");
        public By AvailableDays = By.XPath("//td[contains(@aria-selected, 'false') and @class='']/button");
        public By LoadingElement = By.XPath("//div[contains(@class, 'loader-combined')]");
        public By OneWayOnlyLink = By.XPath("//button[contains(text(), 'One way only')]");
        public By OKButton = By.XPath("//button[contains(@class, 'rf-button--shrinkable')]");
        public By SearchButton = By.XPath("//span[contains(text(), 'Search')]/../..");
        public By ShowReturnFlightsLink = By.XPath("//a[contains(text(), 'Show return flights')]");
        public By CurrentRoute = By.XPath("//div[@class = 'flight-select__flight__title-container']/address");
        public By ShowPricesLink = By.XPath("//div[contains(text(), 'show prices from')]");
        public By WizzPlusSection = By.XPath("//div[contains(@id,'-plus')]");
        public By WizzGoSection = By.XPath("//div[contains(@id,'-middle')]");
        public By BasicSection = By.XPath("//div[contains(@id,'-basic')]");
        public By WizzPlusSectionPrice = By.XPath("//div[contains(@id,'-plus')]//div[@class = 'fare-type-button__title']/span");
        public By WizzGoSectionPrice = By.XPath("//div[contains(@id,'-middle')]//div[@class = 'fare-type-button__title']/span");
        public By BasicSectionPrice = By.XPath("//div[contains(@id,'-basic')]//div[@class = 'fare-type-button__title']/span");
        public By AvailablePricesButton = By.XPath("//div[contains(@class, 'fare-type-button__title fare-type-button__title--active')]");
        public By FirstName = By.XPath("//input[contains(@name, 'firstName')]");
        public By LastName = By.XPath("//input[contains(@name, 'lastName')]");
        public By ContinueButton = By.Id("flight-select-continue-button");
        public By CloseButton = By.XPath("//div[@class = 'container']/button[@class='cookie-policy__button']");
        public By SingMode = By.XPath("//h2[contains(text(), 'Sign in')]");
        public By Way = By.XPath("//div[@class='booking-flow__itinerary__route']");
        public By PassengersContinueButton = By.Id("passengers-continue-btn");
        public By AvailableBaggage = By.ClassName("rf-switch__icon-container");
        public By Sex = By.XPath("//span[contains(text(), 'Female')]");
    }
}
