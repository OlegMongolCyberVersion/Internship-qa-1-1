using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.CheckOutGest
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }
        public IWebElement EmailField => WaitAndFindElement(By.XPath("//input[@name='Email']"));
        public IWebElement PasswordField => WaitAndFindElement(By.XPath("//input[@name='Password']"));
        public IWebElement LogInButton => WaitAndFindElement(By.XPath("//input[@value='Log in']"));
    }
}
