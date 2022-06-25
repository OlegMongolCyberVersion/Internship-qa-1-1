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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement SortByDropDownMenu => WaitAndFindElement(By.XPath("//select[@name='products-orderby']"));
        public IWebElement SortByPosition => WaitAndFindElement(By.XPath("//option[text()='Position']"));
        public IWebElement SortByName_AToZ => WaitAndFindElement(By.XPath("//option[text()='Name: A to Z']"));
        public IWebElement SortByName_ZToA => WaitAndFindElement(By.XPath("//option[text()='Name: Z to A']"));
        public IWebElement SortByPrice_LowToHigh => WaitAndFindElement(By.XPath("//option[text()='Price: Low to High']"));
        public IWebElement SortByPrice_HighToLow => WaitAndFindElement(By.XPath("//option[text()='Price: High to Low']"));
        public IWebElement SortByCreatedOn => WaitAndFindElement(By.XPath("//option[text()='Created on']"));
        public IWebElement DesktopPCWithCDRWLink => WaitAndFindElement(By.XPath("//a[text()='Desktop PC with CDRW']"));
        public IWebElement SimpleComputer => WaitAndFindElement(By.XPath("//a[text()='Simple Computer']"));
    }
}
