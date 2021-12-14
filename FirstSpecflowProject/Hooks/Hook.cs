using BoDi;
using FirstSpecflowProject.Drivers;
using FirstSpecflowProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Hooks
{
    [Binding]
   public class Hook
    {
        private IObjectContainer objectContainer;
        public IWebDriver driver;
        public WebDriverWait wait;
        public Browser browser;
        private string _chromeBrs = "chrome";
        public RegisterPage registerPage;
        

        public Hook(IObjectContainer objectContainer)
        {
            objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            browser = new Browser();
            registerPage = new RegisterPage(driver, wait);

            
    
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = browser.SetUp("chrome");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Manage().Window.Maximize();
            objectContainer.RegisterInstanceAs(driver);
            objectContainer.RegisterInstanceAs(registerPage);
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
