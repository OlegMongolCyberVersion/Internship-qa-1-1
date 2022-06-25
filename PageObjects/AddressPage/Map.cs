using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.AddressPage
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement DeleteButton => WaitAndFindElement(By.XPath("//input[@class='button-2 delete-address-button']"));
    }
}
