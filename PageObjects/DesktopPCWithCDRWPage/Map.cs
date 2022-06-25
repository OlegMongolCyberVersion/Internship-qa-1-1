using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.DesktopPCWithCDRWPage
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement AddToCompareListButton => WaitAndFindElement(By.XPath("//input[@value='Add to compare list']"));
        public IWebElement AddToCartButton => WaitAndFindElement(By.XPath(""));
    }
}
