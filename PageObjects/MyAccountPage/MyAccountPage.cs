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
    internal class MyAccountPage : WebPage
    {
        public MyAccountPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/customer/info";
        public void ClickOnThecustomerInfo()
        {
            Map.CustomerInfoButton.Click();
        }
        public void ClcikOnTheAddressButton()
        {
            Map.AddressButton.Click();
        }
        public void ClickOnTheOrdersButton()
        {
            Map.OrdersButton.Click();
        }
        public void ClickOnTheDownloadableProducts()
        {
            Map.DownloadableProductsButton.Click();
        }
        public void ClickOnTheBackInSubscriptionButton()
        {
            Map.BackInStockSubscriptionsButton.Click();
        }
        public void ClickOnTheRewardPointsButton()
        {
            Map.RewardPointsButton.Click();
        }
        public void ClickOnTheChangePasswordButton()
        {
            Map.ChangePasswordButton.Click();
        }
    }
}
