using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.PhysicalGiftCardPage100Dollar
{
    internal class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {
            
        }
        public IWebElement RecipientsNameField => WaitAndFindElement(By.XPath("//input[@name='giftcard_4.RecipientName']"));
        public IWebElement YourNameField => WaitAndFindElement(By.XPath("//input[@name='giftcard_4.SenderName']"));
        public IWebElement MessageField => WaitAndFindElement(By.XPath("//textarea[@name='giftcard_4.Message']"));
        public IWebElement AddToCartButton => WaitAndFindElement(By.XPath("//input[@value='Add to cart']"));
    }
}
