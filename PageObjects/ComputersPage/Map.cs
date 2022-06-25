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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement DesktopLink => WaitAndFindElement(By.XPath("//a[@title='Show products in category Desktops']"));
        public IWebElement NotebooksLink => WaitAndFindElement(By.XPath("//a[@title='Show products in category Notebooks']"));
        public IWebElement AccessoriesLink => WaitAndFindElement(By.XPath("//a[@title='Show products in category Accessories']"));
    }
}
