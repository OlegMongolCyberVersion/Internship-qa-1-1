using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.MyAccountPage
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }
        public IWebElement CustomerInfoButton => WaitAndFindElement(By.XPath("//a[text()='Customer info']"));
        public IWebElement AddressButton => WaitAndFindElement(By.XPath("//a[text()='Addresses']"));
        public IWebElement OrdersButton => WaitAndFindElement(By.XPath("//a[text()='Orders']"));
        public IWebElement DownloadableProductsButton => WaitAndFindElement(By.XPath("//a[text()='Downloadable products']"));
        public IWebElement BackInStockSubscriptionsButton => WaitAndFindElement(By.XPath("//a[text()='Back in stock subscriptions']"));
        public IWebElement RewardPointsButton => WaitAndFindElement(By.XPath("//a[text()='Reward points']"));
        public IWebElement ChangePasswordButton => WaitAndFindElement(By.XPath("//a[text()='Change password']"));
    }
}
