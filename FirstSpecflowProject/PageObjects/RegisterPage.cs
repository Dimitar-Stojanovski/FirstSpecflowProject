using FirstSpecflowProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSpecflowProject.PageObjects
{
    public class RegisterPage
    {
        private IWebDriver driver = null;
        private WebDriverWait wait = null;

        By _signInButton = By.XPath("//*[@class = 'header_user_info']/a");
        By _enterEmail = By.Id("email_create");
        By _createAccountBtn = By.Id("SubmitCreate");
        By _pageHeader = By.ClassName("page-heading");

        public RegisterPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void ClickLogInButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(_signInButton)).Click();
        }

        public void EnterEmail(string mail)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(_enterEmail)).SendKeys(mail);
        }

        public void ClickCreateAccount()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(_createAccountBtn)).Click();
        }

        public string GetTextFromHeader()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(_pageHeader)).Text;
        }
    }
}
