using FirstSpecflowProject.Drivers;
using FirstSpecflowProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Steps
{
    [Binding]
    public class SignInSteps
    {
        private RegisterPage registerPage;
        private IWebDriver driver = null;
        private WebDriverWait wait;
        //Browser browser;

        public SignInSteps(IWebDriver driver, WebDriverWait wait)
        {
            registerPage = new RegisterPage(driver, wait);
        }



        [Given(@"Load the page")]
        public void GivenLoadThePage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            
        }
        
        [Given(@"Click on SignIn button")]
        public void GivenClickOnSignInButton()
        {
            registerPage.ClickLogInButton();
        }
        
        [Given(@"Enter e-mail address")]
        public void GivenEnterE_MailAddress()
        {
            registerPage.EnterEmail("fakeEmail123@mail.com");
        }
        
        [When(@"I click Create Account")]
        public void WhenIClickCreateAccount()
        {
            registerPage.ClickCreateAccount();
        }
        
        [Then(@"I can see Create an Account File")]
        public void ThenICanSeeCreateAnAccountFile()
        {
            Assert.AreEqual(registerPage.GetTextFromHeader(), "CREATE AN ACCOUNT");
        }
    }
}
