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

namespace DemoWebShop.PageObjects.Register
{
    public class Map : BaseMap
    {
        public Map (IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement GenderMaleRadioButton => WaitAndFindElement(By.XPath("//input[@id='gender-male']"));
        public IWebElement GenderFemaleRadiobutton => WaitAndFindElement(By.XPath("//input[@id='gender-female']"));
        public IWebElement FisrtNameField => WaitAndFindElement(By.XPath("//input[@id='FirstName']"));
        public IWebElement LastNameField => WaitAndFindElement(By.XPath("//input[@id='LastName']"));
        public IWebElement EmailField => WaitAndFindElement(By.XPath("//input[@id='Email']"));
        public IWebElement PassworField => WaitAndFindElement(By.XPath("//input[@id='Password']"));
        public IWebElement ConfirmPasswordField => WaitAndFindElement(By.XPath("//input[@id='ConfirmPassword']"));
        public IWebElement RegisterButton => WaitAndFindElement(By.XPath("//input[@id='register-button']"));
        public IWebElement CustomerInfo => WaitAndFindElement(By.XPath("//a[text()='AleksandrPotapov01.01.1992@gmail.com']"));
        public IWebElement FirstNameIsRequiredMessage => WaitAndFindElement(By.XPath("//span[text()='First name is required.']"));
        public IWebElement LastNameIsRequiredMesssage => WaitAndFindElement(By.XPath("//span[text()='Last name is required.']"));
        public IWebElement EmailIsRequiredMessage => WaitAndFindElement(By.XPath("//span[text()='Email is required.']"));
        public IWebElement PasswordIsRequiredMessage => WaitAndFindElement(By.XPath("//span[text()='Password is required.']"));
        public IWebElement ConfirmPasswordIsRequiredMessage => WaitAndFindElement(By.XPath("//span[@for='ConfirmPassword'][text()='Password is required.']"));
        public IWebElement EmailAlreadyExistRequiredMessage => WaitAndFindElement(By.XPath("//li[text()='The specified email already exists']"));
    }
}
