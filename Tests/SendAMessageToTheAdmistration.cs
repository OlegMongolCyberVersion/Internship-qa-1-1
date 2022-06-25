using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using DemoWebShop.PageObjects;


namespace DemoWebShop.Tests
{
    internal class SendAMessageToTheAdmistration
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;
        private static DemoWebShop.PageObjects.ContactUs.ContactUsPage _contactUsPage;

        public SendAMessageToTheAdmistration()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
            _contactUsPage = new PageObjects.ContactUs.ContactUsPage(_driver);
        }
        public void Dispose()
        {
            _driver.Quit();
        }
        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [Test]
        public void SendRandomMessageToTheAdministrator()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheContactUsLink();

            var personalDetails = new PageObjects.ContactUs.TestData.PersonalDetails()
            {
                Name = "Александр",
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Enquiry = RandomString(40),

            };
            _contactUsPage.SendMessageToTheAdministration(personalDetails);
            Dispose();
        }
    }
}
