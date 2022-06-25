﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DemoWebShop.Tests
{
    internal class AddAProductToCompareList
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;
        private static DemoWebShop.PageObjects.Computers.ComputersPage _computersPage;
        private static DemoWebShop.PageObjects.Desktops.DesktopsPage _desktopsPage;
        private static DemoWebShop.PageObjects.DesktopPCWithCDRWPage.ProductPage _productPage;
        private static DemoWebShop.PageObjects.CompareList.CompareListPage _compareListPage;
        public AddAProductToCompareList()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
            _computersPage = new PageObjects.Computers.ComputersPage(_driver);
            _desktopsPage = new PageObjects.Desktops.DesktopsPage(_driver);
            _productPage = new PageObjects.DesktopPCWithCDRWPage.ProductPage(_driver);
            _compareListPage = new PageObjects.CompareList.CompareListPage(_driver);
        }
        public void Dispose()
        {
            _driver.Quit();
        }
        [Test]
        public void AddProductToCompareList()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheComputeresCategoryLink();
            _computersPage.ClickOnTheDesktopLink();
            _desktopsPage.ChoiceSortByOption();
            _desktopsPage.ClickOnTheDesktopPCWithCDRWLink();
            _productPage.ClickOnTheAddToCompareListbutton();
            _compareListPage.Assertions.AsserAddProductToCompareListSuccess();
            Dispose();
        }
    }
}
