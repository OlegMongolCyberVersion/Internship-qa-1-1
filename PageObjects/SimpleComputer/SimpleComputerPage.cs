using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.SimpleComputer
{
    internal class SimpleComputerPage : WebPage
    {
        public SimpleComputerPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/simple-computer";

        public void ClickOnTheAddToCartButton()
        {
            Map.AddToCartButton.Click();
        }
        public void ClickOnTheSlowProcessorCheckBox()
        {
            Map.SlowProcessorCheckbox.Click();
        }
    }
}
