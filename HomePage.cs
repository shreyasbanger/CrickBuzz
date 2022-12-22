using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrickBuzz.page
{
    public class HomePage
    {
        IWebDriver driver = new ChromeDriver();

        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.cricbuzz.com/");
            driver.Manage().Window.Maximize();
        }
        public void Close()
        {
            driver.Quit();
        }


    }
}
