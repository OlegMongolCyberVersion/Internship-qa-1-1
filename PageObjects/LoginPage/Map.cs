using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoWebShop.PageObjects.Login
{
    public class Map : BaseMap
    {
        public Map(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement EmailField => WaitAndFindElement(By.XPath("//input[@id='Email']"));
        public IWebElement PasswordField => WaitAndFindElement(By.XPath("//input[@id='Password']"));
        public IWebElement RememberMeCheckBox => WaitAndFindElement(By.XPath("//input[@id='RememberMe']"));
        public IWebElement ForgotPasswordLink => WaitAndFindElement(By.XPath("//a[text()='Forgot password?']"));
        public IWebElement LoginButton => WaitAndFindElement(By.XPath("//input[@value='Log in']"));
        public IWebElement CustomerInfo => WaitAndFindElement(By.XPath("//a[text()='AleksandrPotapov01.01.1992@gmail.com']"));
    }
}
