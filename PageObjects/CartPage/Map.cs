using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.Cart
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement RemoveFromcartCheckBox => WaitAndFindElement(By.XPath("//input[@name='removefromcart']"));
        public IWebElement SimpleComputerLink => WaitAndFindElement(By.XPath("//a[@class='product-name']"));
        public IWebElement IAgreeWithTheTermsOfServiceCheckBox => WaitAndFindElement(By.XPath("//input[@name='termsofservice']"));
        public IWebElement CheckOutButton => WaitAndFindElement(By.XPath("//button[@class='button-1 checkout-button']"));
    }
}
