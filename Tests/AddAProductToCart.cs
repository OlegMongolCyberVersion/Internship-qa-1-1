using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DemoWebShop.Tests
{
    internal class AddAProductToCart
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;
        private static DemoWebShop.PageObjects.Computers.ComputersPage _computersPage;
        private static DemoWebShop.PageObjects.Desktops.DesktopsPage _desktopsPage;
        private static DemoWebShop.PageObjects.SimpleComputer.SimpleComputerPage _simpleComputer;
        private static DemoWebShop.PageObjects.Cart.CartPage _cartPage;
        public AddAProductToCart()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
            _computersPage = new PageObjects.Computers.ComputersPage(_driver);
            _desktopsPage = new PageObjects.Desktops.DesktopsPage(_driver);
            _simpleComputer = new PageObjects.SimpleComputer.SimpleComputerPage(_driver);
            _cartPage = new PageObjects.Cart.CartPage(_driver);
        }
        public void Dispose()
        {
            _driver.Quit();
        }
        [Test]
        public void AddTheSimpleComputerToCart()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheComputeresCategoryLink();
            _computersPage.ClickOnTheDesktopLink();
            _desktopsPage.ClickOnTheSimpleComputerLink();
            _simpleComputer.ClickOnTheSlowProcessorCheckBox();
            _simpleComputer.ClickOnTheAddToCartButton();
            _mainPage.ClickOnTheShoppingCartLink();
            _cartPage.Assertions.AssertAddToCartSimpleComputer();
            Dispose();
        }
    }
}
