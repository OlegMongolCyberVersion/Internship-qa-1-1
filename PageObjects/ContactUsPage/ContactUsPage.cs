using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.ContactUs
{
    internal class ContactUsPage : WebPage
    {
        public ContactUsPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/contactus";

        public void SendMessageToTheAdministration(TestData.PersonalDetails personalDetails)
        {
            Map.EnterYourNameField.SendKeys(personalDetails.Name);
            Map.EnterYourEmailAddres.SendKeys(personalDetails.Email);
            Map.EnterYourEnquiry.SendKeys(personalDetails.Enquiry);
            Map.SubmitButton.Click();
        }
    }
}
