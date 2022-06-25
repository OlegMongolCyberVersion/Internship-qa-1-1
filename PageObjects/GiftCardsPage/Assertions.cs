using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.GiftCardsPage
{
    internal class Assertions
    {
        private readonly Map _map;
        public Assertions(Map map)
        {
            _map = map;
        }
    }
}
