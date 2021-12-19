using FirstSpecflowProject.Drivers;
using FirstSpecflowProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Hooks
{
    [Binding]
    public class HooksInitialization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext _scenarioContext;

        public HooksInitialization(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
        
        Browser browser;
        private string chromeBrs = "chrome";
        public IWebDriver driver;
        public WebDriverWait wait;
        public RegisterPage registerPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            browser = new Browser(_scenarioContext);
            driver = browser.SetUp(chromeBrs);
            _scenarioContext.Set(browser, "SeleniumDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            registerPage = new RegisterPage(driver, wait);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
