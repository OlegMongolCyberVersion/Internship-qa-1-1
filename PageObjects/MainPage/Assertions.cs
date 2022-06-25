using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace DemoWebShop.PageObjects.Main
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
