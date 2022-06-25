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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }
        public IWebElement CountryDropDownMenu => WaitAndFindElement(By.XPath("//select[@data-val-number='The field Country must be a number.']"));
        public IWebElement Russia => WaitAndFindElement(By.XPath("//option[text()='Russia']"));
        public IWebElement CityFiled => WaitAndFindElement(By.XPath("//input[@id='BillingNewAddress_City']"));
        public IWebElement Address1Field => WaitAndFindElement(By.XPath("//input[@id='BillingNewAddress_Address1']"));
        public IWebElement ZipPostalCodeField => WaitAndFindElement(By.XPath("//input[@id='BillingNewAddress_ZipPostalCode']"));
        public IWebElement PhoneNumberField => WaitAndFindElement(By.XPath("//input[@id='BillingNewAddress_PhoneNumber']"));
        public IWebElement BillingAddressContinueButton => WaitAndFindElement(By.XPath("//input[@class='button-1 new-address-next-step-button']"));
        public IWebElement ShippingAddressContinueButton => WaitAndFindElement(By.CssSelector("div.master-wrapper-page:nth-child(4) div.master-wrapper-content div.master-wrapper-main:nth-child(5) div.center-1 div.page.checkout-page div.page-body.checkout-data:nth-child(2) ol.opc li.tab-section.allow.active:nth-child(2) div.step.a-item div.buttons:nth-child(3) > input.button-1.new-address-next-step-button"));
        public IWebElement ShippingMethodContionueButton => WaitAndFindElement(By.CssSelector("div.master-wrapper-page:nth-child(4) div.master-wrapper-content div.master-wrapper-main:nth-child(5) div.center-1 div.page.checkout-page div.page-body.checkout-data:nth-child(2) ol.opc li.tab-section.allow.active:nth-child(3) div.step.a-item form:nth-child(1) div.buttons:nth-child(3) > input.button-1.shipping-method-next-step-button"));
        public IWebElement CreditCardRadioButton => WaitAndFindElement(By.XPath("//input[@id='paymentmethod_2']"));
        public IWebElement PaymentMethodContinueButton => WaitAndFindElement(By.CssSelector("div.master-wrapper-page:nth-child(4) div.master-wrapper-content div.master-wrapper-main:nth-child(5) div.center-1 div.page.checkout-page div.page-body.checkout-data:nth-child(2) ol.opc li.tab-section.allow.active:nth-child(4) div.step.a-item div.buttons:nth-child(3) > input.button-1.payment-method-next-step-button"));
        public IWebElement CardHoledrNameField => WaitAndFindElement(By.XPath("//input[@id='CardholderName']"));
        public IWebElement CardNumberField => WaitAndFindElement(By.XPath("//input[@id='CardNumber']"));
        public IWebElement CardCodeField => WaitAndFindElement(By.XPath("//input[@id='CardCode']"));
        public IWebElement PaymentInformationContinueButton => WaitAndFindElement(By.CssSelector("div.master-wrapper-page:nth-child(4) div.master-wrapper-content div.master-wrapper-main:nth-child(5) div.center-1 div.page.checkout-page div.page-body.checkout-data:nth-child(2) ol.opc li.tab-section.allow.active:nth-child(5) div.step.a-item div.buttons:nth-child(3) > input.button-1.payment-info-next-step-button"));
        public IWebElement ConfirmOrderContinueButton => WaitAndFindElement(By.CssSelector("div.master-wrapper-page:nth-child(4) div.master-wrapper-content div.master-wrapper-main:nth-child(5) div.center-1 div.page.checkout-page div.page-body.checkout-data:nth-child(2) ol.opc li.tab-section.allow.active:nth-child(6) div.step.a-item div.buttons:nth-child(3) > input.button-1.confirm-order-next-step-button"));
        public IWebElement ContionueButtonOnTheCompletedPage => WaitAndFindElement(By.XPath("//input[@class='button-2 order-completed-continue-button']"));
    }
}
