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

namespace DemoWebShop.PageObjects
{
    public class BaseMap
    {
        private const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
        private WebDriverWait _webDriverWait;

        public BaseMap(IWebDriver driver)
        {
            _webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
        }
        protected IWebElement WaitAndFindElement(By locator)
        {
            return _webDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }
    }
}
