using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace DemoWebShop.PageObjects.Main
{
    internal class MainPage : WebPage
    {
        public MainPage(IWebDriver driver)
            : base(driver)
        {
            Map = new Map(driver);
            Assertions = new Assertions(Map);
        }

        public Map Map { get; }
        public Assertions Assertions { get; }

        protected override string Url => "http://demowebshop.tricentis.com/";

        public void OpenBrowser()
        {
            GoTo();
        }
        public void ClickOnTheMyAccountButton()
        {
            Map.MyAccountButton.Click();
        }

        public void ClickOnTheRegisterLink()
        {
            Map.RegisterLinkInHeader.Click();   
        }

        public void ClickOnTheLoginLink()
        {
            Map.LoginLinkInHeader.Click();
        }

        public void ClickOnTheShoppingCartLink()
        {
            Map.ShoppingCartLinkInHeader.Click();
        }
        public void ClickOnTheWishListLink()
        {
            Map.WishListLinkInHeader.Click();
        }
        public void ClickOnTheBooksCategoryLink()
        {
            Map.BooksLinkInCategories.Click();
        }

        public void ClickOnTheComputeresCategoryLink()
        {
            Map.ComputeresLinkInCategories.Click();
        }

        public void ClickOnTheElectronicsCategoryLink()
        {
            Map.ElectronicsLinkInCategories.Click();
        }
        public void ClickOnTheApparelAndShoesCategoryLink()
        {
            Map.ApparelAndShoesInCategories.Click();
        }
        public void ClickonTheDigitalDownloadsCategoryLink()
        {
            Map.DigitalDownloadsInCategories.Click();
        }
        public void ClickOnTheJewelryCategoryLinks()
        {
            Map.JewelryInCategories.Click();
        }
        public void ClickOnTheGiftCardsLink()
        {
            Map.GiftCardsInCategories.Click();
        }
        public void ClickOnTheContactUsLink()
        {
            Map.ContactUsLink.Click();
        }
        static readonly HttpClient Client = new HttpClient();
        public void GetResponseFromFacebookLink()
        {
            string URL = Map.FacebookLink.GetAttribute("href");
            HttpWebRequest requeset = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)requeset.GetResponse();
            var statusCode = response.StatusCode;
            string _statusCode = Convert.ToString(statusCode);
            Assert.AreEqual("OK", _statusCode);
        }
        public void GetResponseFromTwitterlink()
        {
            string URL = Map.TwitterLink.GetAttribute("href");
            HttpWebRequest requeset = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)requeset.GetResponse();
            var statusCode = response.StatusCode;
            string _statusCode = Convert.ToString(statusCode);
            Assert.AreEqual("OK", _statusCode);
        }
        public void GetResponseFromRssLink()
        {
            string URL = Map.RSSLink.GetAttribute("href");
            HttpWebRequest requeset = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)requeset.GetResponse();
            var statusCode = response.StatusCode;
            string _statusCode = Convert.ToString(statusCode);
            Assert.AreEqual("OK", _statusCode);
        }
        public void GetResponseFromYouTubeLink()
        {
            string URL = Map.YouTubeLink.GetAttribute("href");
            HttpWebRequest requeset = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)requeset.GetResponse();
            var statusCode = response.StatusCode;
            string _statusCode = Convert.ToString(statusCode);
            Assert.AreEqual("OK", _statusCode);
        }
        public void GetResponseFromGoogleLink()
        {
            string URL = Map.GoogleLink.GetAttribute("href");
            HttpWebRequest requeset = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)requeset.GetResponse();
            var statusCode = response.StatusCode;
            string _statusCode = Convert.ToString(statusCode);
            Assert.AreEqual("OK", _statusCode);
        }
        protected override void WaitForPageToLoad()
        {
            base.WaitAndFindElement(By.XPath("//a[text()='Register']"));
        }
    }
}
