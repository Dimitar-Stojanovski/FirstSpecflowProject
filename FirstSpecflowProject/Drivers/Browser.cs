using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Drivers
{
    public class Browser
    {
        public IWebDriver driver = null;
        private readonly ScenarioContext _scenarioContext;

        public Browser(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
       

        public IWebDriver SetUp(string _browser)
        {
            switch (_browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "gecko":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            return driver;
        }
    }
}
