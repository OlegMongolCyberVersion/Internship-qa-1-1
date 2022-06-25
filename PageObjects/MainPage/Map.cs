using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using DemoWebShop.PageObjects;

namespace DemoWebShop.PageObjects.Main
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement RegisterLinkInHeader => WaitAndFindElement(By.XPath("//a[text()='Register']"));
        public IWebElement LoginLinkInHeader => WaitAndFindElement(By.XPath("//a[text()='Log in']"));
        public IWebElement ShoppingCartLinkInHeader => WaitAndFindElement(By.XPath("//span[text()='Shopping cart']"));
        public IWebElement WishListLinkInHeader => WaitAndFindElement(By.XPath("//span[text()='Wishlist']"));
        public IWebElement UserLoginInHeader => WaitAndFindElement(By.XPath("//a[@class='account']"));
        public IWebElement BooksLinkInCategories => WaitAndFindElement(By.XPath("//a[@href='/books']"));
        public IWebElement ComputeresLinkInCategories => WaitAndFindElement(By.XPath("//a[@href='/computers']"));
        public IWebElement ElectronicsLinkInCategories => WaitAndFindElement(By.XPath("//a[@href='/electronics']"));
        public IWebElement ApparelAndShoesInCategories => WaitAndFindElement(By.XPath("//a[@href='/apparel-shoes']"));
        public IWebElement DigitalDownloadsInCategories => WaitAndFindElement(By.XPath("//a[@href='/digital-downloads']"));
        public IWebElement JewelryInCategories => WaitAndFindElement(By.XPath("//a[@href='/jewelry']"));
        public IWebElement GiftCardsInCategories => WaitAndFindElement(By.XPath("//a[@href='/gift-cards']"));
        public IWebElement ContactUsLink => WaitAndFindElement(By.XPath("//a[text()='Contact us']"));
        public IWebElement VirtualGiftCardLink => WaitAndFindElement(By.XPath("//a[text()='$25 Virtual Gift Card']"));
        public IWebElement FacebookLink => WaitAndFindElement(By.XPath("//a[text()='Facebook']"));
        public IWebElement TwitterLink => WaitAndFindElement(By.XPath("//a[text()='Twitter']"));
        public IWebElement RSSLink => WaitAndFindElement(By.XPath("//a[text()='RSS']"));
        public IWebElement YouTubeLink => WaitAndFindElement(By.XPath("//a[text()='YouTube']"));
        public IWebElement GoogleLink => WaitAndFindElement(By.XPath("//a[text()='Google+']"));
        public IWebElement MyAccountButton => WaitAndFindElement(By.XPath("//a[text()='AleksandrPotapov01.01.1992@gmail.com']"));
    }
}
