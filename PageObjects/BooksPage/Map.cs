using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.BooksPage
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }
        public IWebElement ComputingAndInternetBookAddToCartButton => WaitAndFindElement(By.XPath("//body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[3]/div[2]/input[1]"));
    }
}
