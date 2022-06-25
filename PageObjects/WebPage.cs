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
    public abstract class WebPage
    {
        private const int WAIT_FOR_ELEMENT_TIMEOUT = 30;

        public WebPage(IWebDriver driver)
        {
            Driver = driver;
            WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
        }

        protected IWebDriver Driver { get; set; }
        protected WebDriverWait WebDriverWait { get; set; }
        protected abstract string Url { get; }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(Url);
            Driver.Manage().Window.Maximize();
            WaitForPageToLoad();
        }

        protected virtual void WaitForPageToLoad()
        {

        }

        protected IWebElement WaitAndFindElement(By locator)
        {
            return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }

        protected void WaitForAjax()
        {
            var js = (IJavaScriptExecutor)Driver;
            WebDriverWait.Until(wd => js.ExecuteScript("return JQuery.avtive").ToString() == "0");
        }
    }
}
