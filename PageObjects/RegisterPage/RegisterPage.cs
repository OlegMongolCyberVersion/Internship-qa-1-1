using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DemoWebShop.PageObjects.Register
{
    internal class RegisterPage : WebPage
    {
        public RegisterPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }

        protected override string Url => "http://demowebshop.tricentis.com/register";

        public void FillingPersonalDetails(TestData.PersonalDetails personalDetails)
        {
            switch(personalDetails.Gender)
            {
                case "male":
                    Map.GenderMaleRadioButton.Click();
                    break;
                case "female":
                    Map.GenderFemaleRadiobutton.Click();
                    break;
            }
            Map.FisrtNameField.SendKeys(personalDetails.FirstName);
            Map.LastNameField.SendKeys(personalDetails.LastName);
            Map.EmailField.SendKeys(personalDetails.Email);
            Map.PassworField.SendKeys(personalDetails.Password);
            Map.ConfirmPasswordField.SendKeys(personalDetails.ConfirmPassword);
        }
        public void ClearPersonalDetailsField()
        {
            Map.FisrtNameField.Clear();
            Map.LastNameField.Clear();
            Map.EmailField.Clear();
            Map.PassworField.Clear();
            Map.ConfirmPasswordField.Clear();
        }
        
        public Main.MainPage ClickOnTheRegisterButton()
        {
            Map.RegisterButton.Click();
            return new Main.MainPage(Driver);
        }
    }
}
