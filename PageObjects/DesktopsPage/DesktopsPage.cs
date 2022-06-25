using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.Desktops
{
    internal class DesktopsPage : WebPage
    {
        public DesktopsPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/desktops";

        public void ChoiceSortByOption()
        {
            IWebElement sortByOption = Map.SortByDropDownMenu;
            SelectElement selectOption = new SelectElement(sortByOption);
            selectOption.SelectByText(Map.SortByPrice_LowToHigh.Text);
        }
        public DesktopPCWithCDRWPage.ProductPage ClickOnTheDesktopPCWithCDRWLink()
        {
            Map.DesktopPCWithCDRWLink.Click();
            return new DesktopPCWithCDRWPage.ProductPage(Driver);
        }
        public SimpleComputer.SimpleComputerPage ClickOnTheSimpleComputerLink()
        {
            Map.SimpleComputer.Click();
            return new SimpleComputer.SimpleComputerPage(Driver);
        }
    }
}
