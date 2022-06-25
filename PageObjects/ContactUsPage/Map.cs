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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
            
        }

        public IWebElement EnterYourNameField => WaitAndFindElement(By.XPath("//input[@data-val-required='Enter your name']"));
        public IWebElement EnterYourEmailAddres => WaitAndFindElement(By.XPath("//input[@data-val-required='Enter email']"));
        public IWebElement EnterYourEnquiry => WaitAndFindElement(By.XPath("//textarea[@data-val-required='Enter enquiry']"));
        public IWebElement SubmitButton => WaitAndFindElement(By.XPath("//input[@class='button-1 contact-us-button']"));
    }
}
