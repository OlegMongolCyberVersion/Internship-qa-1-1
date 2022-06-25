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
    internal class VerifyFollowUsLinks
    {
        private static IWebDriver _driver;
        private static DemoWebShop.PageObjects.Main.MainPage _mainPage;

        public VerifyFollowUsLinks()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
        }
        public void Dispose()
        {
            _driver.Quit();
        }
        [Test]
        public void VerifyFacebookLink()
        {
            _mainPage.GoTo();
            _mainPage.GetResponseFromFacebookLink();
        }
        [Test]
        public void VerifyTwitterLink()
        {
            _mainPage.GoTo();
            _mainPage.GetResponseFromTwitterlink();
            Dispose();
        }
        [Test]
        public void VerifyRSSLink()
        {
            _mainPage.GoTo();
            _mainPage.GetResponseFromRssLink();
            Dispose();
        }
        [Test]
        public void VerifyYouTubeLink()
        {
            _mainPage.GoTo();
            _mainPage.GetResponseFromYouTubeLink();
            Dispose();
        }
        [Test]
        public void VerifyGoogleLink()
        {
            _mainPage.GoTo();
            _mainPage.GetResponseFromGoogleLink();
            Dispose();
        }
    }
}
