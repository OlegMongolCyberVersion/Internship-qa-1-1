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

namespace DemoWebShop.PageObjects.Cart
{
    internal class Assertions
    {
        private readonly Map _map;
        public Assertions(Map map)
        {
            _map = map;
        }

        public void AssertAddToCartSimpleComputer()
        {
            Assert.AreEqual("Simple Computer", _map.SimpleComputerLink.Text);
        }
    }
}
