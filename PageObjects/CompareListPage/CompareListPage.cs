using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.CompareList
{
    internal class CompareListPage : WebPage
    {
        public CompareListPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/compareproducts";

        public void ClickOnTheDesktopPCWithCDRWLink()
        {
            Map.DesktopPCWithCDRWLink.Click();
        }
    }
}
