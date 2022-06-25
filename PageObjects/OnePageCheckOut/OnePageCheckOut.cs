using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.OnePageCheckOut
{
    internal class OnePageCheckOut : WebPage
    {
        public OnePageCheckOut(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }
        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/onepagecheckout";
        public void ChoiceRussiaInCountryDropDownMenu()
        {
            IWebElement choiceCountry = Map.CountryDropDownMenu;
            SelectElement selectCountry = new SelectElement(choiceCountry);
            selectCountry.SelectByText(Map.Russia.Text);
        }
        public void FillingBillingAddressFields(TestData.PersonalDetails personalDetails)
        {
            IWebElement choiceCountry = Map.CountryDropDownMenu;
            SelectElement selectCountry = new SelectElement(choiceCountry);
            selectCountry.SelectByText(Map.Russia.Text);
            Map.CityFiled.SendKeys(personalDetails.City);
            Map.Address1Field.SendKeys(personalDetails.Address1);
            Map.ZipPostalCodeField.SendKeys(personalDetails.ZipPostalCode);
            Map.PhoneNumberField.SendKeys(personalDetails.PhoneNumber);
            Map.BillingAddressContinueButton.Click();
        }
        public void FillingShippingAddressFields()
        {
            Map.ShippingAddressContinueButton.Click();
        }
        public void FillingShippingMethodFields()
        {
            Map.ShippingMethodContionueButton.Click();
        }
        public void FillingPaymentMethodFields()
        {
            Map.CreditCardRadioButton.Click();
            Map.PaymentMethodContinueButton.Click();
        }
        public void FillingPaymentInformationFields(TestData.PaymentInformation paymentInformation)
        {
            Map.CardHoledrNameField.SendKeys(paymentInformation.CardholderName);
            Map.CardNumberField.SendKeys(paymentInformation.CardNumber);
            Map.CardCodeField.SendKeys(paymentInformation.CardCode);
            Map.PaymentInformationContinueButton.Click();
        }
        public void ClickOnTheConfirmOrderContinueButton()
        {
            Map.ConfirmOrderContinueButton.Click();
        }
        public void ClickOnTheContinueButtonAtTheCompletedPage()
        {
            Map.ContionueButtonOnTheCompletedPage.Click();
        }
    }
}
