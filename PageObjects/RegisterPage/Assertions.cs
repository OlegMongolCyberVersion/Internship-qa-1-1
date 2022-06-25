using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace DemoWebShop.PageObjects.Register
{
    public class Assertions
    {
        private readonly Map _map;

        public Assertions(Map map)
        {
            _map = map;
        }
        public void AssertionRegistrationItNotSuccessfullWithExistingEmail()
        {
            Assert.AreEqual("The specified email already exists", _map.EmailAlreadyExistRequiredMessage.Text);
        }
        public void AssertionRegistrationIsNotSuccessfulWithoutFirstName()
        {
            Assert.AreEqual("First name is required.", _map.FirstNameIsRequiredMessage.Text, "Fail");
        }
        public void AssertionRegistrationIsNotSuccessfulWithoutLastName()
        {
            Assert.AreEqual("Last name is required.", _map.LastNameIsRequiredMesssage.Text);
        }
        public void AssertionRegistrationIsNotSuccessfulWitoutEmail()
        {
            Assert.AreEqual("Email is required.", _map.EmailIsRequiredMessage.Text);
        }
        public void AssertionRegistrationIsNotSuccessfulWithoutPassword()
        {
            Assert.AreEqual("Password is required.", _map.PasswordIsRequiredMessage.Text);
        }
        public void AssertionRegistrationIsNotSuccessfulWithoutConfirmPassword()
        {
            Assert.AreEqual("Password is required.", _map.ConfirmPasswordIsRequiredMessage.Text);
        }

    }
}
