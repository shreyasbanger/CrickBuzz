using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CrickBuzz.page
{
    [Binding]
    public class CrickPractiseStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Entering the URL")]
        public void GivenEnteringTheURL()
        {
            driver.Navigate().GoToUrl("https://www.cricbuzz.com/");
        }

        [Then(@"Crickbuzz webapplication should be displayed")]
        public void ThenCrickbuzzWebapplicationShouldBeDisplayed()
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Given(@"Clicking on livescore linkbutton")]
        public void GivenClickingOnLivescoreLinkbutton()
        {
            driver.FindElement(By.ClassName("cb-hm-mnu-itm")).Click();
        }
        [Then(@"livescore page should me displayed")]
        public void ThenLivescorePageShouldMeDisplayed()
        {

        }


    }
}
