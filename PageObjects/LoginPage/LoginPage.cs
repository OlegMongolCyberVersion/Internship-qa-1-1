using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.Login
{
    internal class LoginPage : WebPage
    {
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }

        protected override string Url => "http://demowebshop.tricentis.com/login";

        public Main.MainPage FillingPersonalDetails(TestData.PersonalDetails personalDetails)
        {
            Map.EmailField.SendKeys(personalDetails.Email);
            Map.PasswordField.SendKeys(personalDetails.Password);
            return new Main.MainPage(Driver);
        }

        public void ClickOnTheLogInButton()
        {
            Map.LoginButton.Click();
        }
    }
}
