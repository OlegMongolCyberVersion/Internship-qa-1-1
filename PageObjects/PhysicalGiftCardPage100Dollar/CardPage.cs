using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.PhysicalGiftCardPage100Dollar
{
    internal class CardPage : WebPage
    {
        public CardPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }

        protected override string Url => "http://demowebshop.tricentis.com/100-physical-gift-card";

        public void FillingPersonalDetails(TestData.PersonalDetails personalDetails)
        {
            Map.RecipientsNameField.SendKeys(personalDetails.RecipientName);
            Map.YourNameField.SendKeys(personalDetails.YourName);
            Map.MessageField.SendKeys(personalDetails.Message);

        }
        public void ClickOnTheAddToCartButton()
        {
            Map.AddToCartButton.Click();
        }
    }
}
