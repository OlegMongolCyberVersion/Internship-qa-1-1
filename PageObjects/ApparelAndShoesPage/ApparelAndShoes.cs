using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.ApparelAndShoesPage
{
    internal class ApparelAndShoes : WebPage
    {
        public ApparelAndShoes(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }
        public Map Map { get; }
        public Assertions Assertions { get; }
        protected override string Url => "http://demowebshop.tricentis.com/apparel-shoes";
        public void ClickOnBlueJeansAddToCartButton()
        {
            Map.BleuJeansAddToCartButton.Click();
        }
    }
}
