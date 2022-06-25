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
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement AddToCartButton => WaitAndFindElement(By.XPath("//input[@id='add-to-cart-button-75']"));
        public IWebElement SlowProcessorCheckbox => WaitAndFindElement(By.XPath("//input[@id='product_attribute_75_5_31_96']"));
    }
}
