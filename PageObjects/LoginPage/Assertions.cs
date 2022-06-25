using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DemoWebShop.PageObjects.Login
{
    public class Assertions
    {
        private readonly Map _map;
        public Assertions(Map map)
        {
            _map = map;
        }

        public void AssertAuthorizationSuccessfully()
        {
            Assert.AreEqual("AleksandrPotapov01.01.1992@gmail.com", _map.CustomerInfo.Text);
        }
    }
}
