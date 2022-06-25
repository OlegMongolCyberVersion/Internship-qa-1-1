using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DemoWebShop.Tests
{
    public class LogIn
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;
        private static DemoWebShop.PageObjects.Register.RegisterPage _registerPage;
        private static DemoWebShop.PageObjects.Login.LoginPage _loginPage;

        public LogIn()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
            _registerPage = new PageObjects.Register.RegisterPage(_driver);
            _loginPage = new PageObjects.Login.LoginPage(_driver);
        }

        public void Dispose()
        {
            _driver.Quit();
        }

        [Test]
        public void LogInWithValidData()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheLoginLink();
            var personalDetails = new PageObjects.Login.TestData.PersonalDetails()
            {
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
            };
            _loginPage.FillingPersonalDetails(personalDetails);
            _loginPage.ClickOnTheLogInButton();
            _loginPage.Assertions.AssertAuthorizationSuccessfully();
            Dispose();
        }
    }
}
