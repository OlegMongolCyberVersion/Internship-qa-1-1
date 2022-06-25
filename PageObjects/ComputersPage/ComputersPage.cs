using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.Computers
{
    internal class ComputersPage : WebPage
    {
        public ComputersPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }
        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/computers";
        public Desktops.DesktopsPage ClickOnTheDesktopLink()
        {
            Map.DesktopLink.Click();
            return new Desktops.DesktopsPage(Driver);
        }
        public void ClickOnTheNotebooksLink()
        {
            Map.NotebooksLink.Click();
        }
        public void ClickOnTheAccessoriesLink()
        {
            Map.AccessoriesLink.Click();
        }
    }
}
