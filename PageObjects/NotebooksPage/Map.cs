using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.NotebooksPage
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }
        public IWebElement LaptopAddToCartButton => WaitAndFindElement(By.XPath("//input[@class='button-2 product-box-add-to-cart-button']"));
    }
}
