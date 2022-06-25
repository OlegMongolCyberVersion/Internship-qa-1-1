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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement DesktopPCWithCDRWLink => WaitAndFindElement(By.XPath("//a[contains(text(),'Desktop PC with CDRW')]"));
        public IWebElement DesktopPCWithCDRWPrice => WaitAndFindElement(By.XPath("//td[contains(text(),'500.00')]"));
    }
}
