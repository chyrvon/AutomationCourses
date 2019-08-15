using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


//a[contains(text(),'new')]

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


public class Waiters
        {
                private string _googleUrl = "https://gismeteo.ua";
                private IWebDriver _driver = new ChromeDriver(@"C:\Users\YevhenC\Downloads\chromedriver_win32");
                private WebDriverWait _explicitWait;




                [OneTimeSetUp]
                public void SetUp()
                {
                        _driver.Manage().Window.Maximize();


                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        _explicitWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));


//_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        //_explicitWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));




//_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        //_explicitWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(11));


                        _driver.Navigate().GoToUrl(_googleUrl);
                }


                [Test]
                public void TestIfElementIsDisplyed()
                {
                        _explicitWait.Until(d => d.FindElement(By.Id("hplogo")).Displayed); 
                }


                [Test]
                public void TestIfElementIsNotDisplyed()
                {
                        var logo = _driver.FindElement(By.Id("this-id-does-not-exist"));
                }


                [Test]
                public void TestIfElementIsNotDisplyedFromUntil()
                {
                        _explicitWait.Until(d => d.FindElement(By.Id("this-id-does-not-exist")).Displayed); 
                }


                [Test]
                public void TestIfElementIsNotDisplyedFromUntil_1()
                {
                        _explicitWait.Until(d => !d.FindElement(By.Id("this-id-does-not-exist")).Displayed); 
                }


                //[Test]
                //public void TestIfElementIsNotDisplyedFromUntil_2()
                //{
                //        _explicitWait.Until(d => d.FindElements(By.Id("this-id-does-not-exist")).All(el => !el.Displayed)); 
                //}


                [OneTimeTearDown]
                public void TearDown()
                {
                        _driver.Quit();
                }
        }
