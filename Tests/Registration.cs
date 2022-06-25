using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using DemoWebShop.PageObjects;

namespace DemoWebShop.Tests
{
    public class Registration
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;
        private static DemoWebShop.PageObjects.Register.RegisterPage _registerPage;
        private static DemoWebShop.PageObjects.Login.LoginPage _loginPage;

        public Registration()
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
        public void RegistrationWithExistingEmail()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheRegisterLink();
            var personalDetails = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "Александр",
                LastName = "Потапов",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
                ConfirmPassword = "AleksandrPotapov1992",
            };
            _registerPage.FillingPersonalDetails(personalDetails);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationItNotSuccessfullWithExistingEmail();
            Dispose();
        }
        [Test]
        public void RegistrationWithoutFillingAnyFields()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheRegisterLink();
            var personalDetails_1 = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "",
                LastName = "Потапов",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
                ConfirmPassword = "AleksandrPotapov1992",
            };
            _registerPage.FillingPersonalDetails(personalDetails_1);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationIsNotSuccessfulWithoutFirstName();
            _registerPage.ClearPersonalDetailsField();
            var personalDetails_2 = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "Александр",
                LastName = "",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
                ConfirmPassword = "AleksandrPotapov1992",
            };
            _registerPage.FillingPersonalDetails(personalDetails_2);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationIsNotSuccessfulWithoutLastName();
            _registerPage.ClearPersonalDetailsField();
            var personalDetails_3 = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "Александр",
                LastName = "Потапов",
                Email = "",
                Password = "AleksandrPotapov1992",
                ConfirmPassword = "AleksandrPotapov1992",
            };
            _registerPage.FillingPersonalDetails(personalDetails_3);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationIsNotSuccessfulWitoutEmail();
            _registerPage.ClearPersonalDetailsField();
            var personalDetails_4 = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "Александр",
                LastName = "Потапов",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "",
                ConfirmPassword = "AleksandrPotapov1992",
            };
            _registerPage.FillingPersonalDetails(personalDetails_4);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationIsNotSuccessfulWithoutPassword();
            _registerPage.ClearPersonalDetailsField();
            var personalDetails_5 = new PageObjects.Register.TestData.PersonalDetails()
            {
                Gender = "male",
                FirstName = "Александр",
                LastName = "Потапов",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
                ConfirmPassword = "",
            };
            _registerPage.FillingPersonalDetails(personalDetails_5);
            _registerPage.ClickOnTheRegisterButton();
            _registerPage.Assertions.AssertionRegistrationIsNotSuccessfulWithoutConfirmPassword();
            Dispose();
        }
    }
}