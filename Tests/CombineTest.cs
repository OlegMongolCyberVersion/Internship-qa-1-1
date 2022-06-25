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
    internal class CombineTest
    {
        public IWebDriver _driver;
        public DemoWebShop.PageObjects.Main.MainPage _mainPage;
        public DemoWebShop.PageObjects.Login.LoginPage _loginPage;
        public DemoWebShop.PageObjects.GiftCardsPage.GiftCardsPage _giftCardsPage;
        public DemoWebShop.PageObjects.PhysicalGiftCardPage100Dollar.CardPage _cardPage;
        public DemoWebShop.PageObjects.BooksPage.BooksPage _booksPage;
        public DemoWebShop.PageObjects.Computers.ComputersPage _computersPage;
        public DemoWebShop.PageObjects.NotebooksPage.NotebooksPage _notebooksPage;
        public DemoWebShop.PageObjects.ApparelAndShoesPage.ApparelAndShoes _apparelAndShoes;
        public DemoWebShop.PageObjects.JewelryPage.JewelryPage _jewelryPage;
        public DemoWebShop.PageObjects.Cart.CartPage _cartPage;
        public DemoWebShop.PageObjects.CheckOutGest.CheckOutGestPage _checkOutGestPage;
        public DemoWebShop.PageObjects.OnePageCheckOut.OnePageCheckOut _onePageCheckOut;
        public DemoWebShop.PageObjects.MyAccountPage.MyAccountPage _myAccountPage;
        public DemoWebShop.PageObjects.AddressPage.AddressPage _addressPage;
        public CombineTest()
        {
            _driver = new ChromeDriver();
            _mainPage = new PageObjects.Main.MainPage(_driver);
            _loginPage = new PageObjects.Login.LoginPage(_driver);
            _giftCardsPage = new PageObjects.GiftCardsPage.GiftCardsPage(_driver);
            _cardPage = new PageObjects.PhysicalGiftCardPage100Dollar.CardPage(_driver);
            _booksPage = new PageObjects.BooksPage.BooksPage(_driver);
            _computersPage = new PageObjects.Computers.ComputersPage(_driver);
            _notebooksPage = new PageObjects.NotebooksPage.NotebooksPage(_driver);
            _apparelAndShoes = new PageObjects.ApparelAndShoesPage.ApparelAndShoes(_driver);
            _jewelryPage = new PageObjects.JewelryPage.JewelryPage(_driver);
            _cartPage = new PageObjects.Cart.CartPage(_driver);
            _checkOutGestPage = new PageObjects.CheckOutGest.CheckOutGestPage(_driver);
            _onePageCheckOut = new PageObjects.OnePageCheckOut.OnePageCheckOut(_driver);
            _myAccountPage = new PageObjects.MyAccountPage.MyAccountPage(_driver);
            _addressPage = new PageObjects.AddressPage.AddressPage(_driver);
        }
        public void Dispose()
        {
            _driver.Quit();
        }
        [Test]
        public void CombineTest1()
        {
            _mainPage.GoTo();
            _mainPage.ClickOnTheGiftCardsLink();
            _giftCardsPage.ClickOnThePhysicalGiftCard100DollarLink();
            var personalDetailsForSendMessage = new PageObjects.PhysicalGiftCardPage100Dollar.TestData.PersonalDetails()
            {
                RecipientName = "Sergey",
                YourName = "Aleksandr",
                Message = "Happy New Year!",
            };
            _cardPage.FillingPersonalDetails(personalDetailsForSendMessage);
            _cardPage.ClickOnTheAddToCartButton();
            _mainPage.ClickOnTheBooksCategoryLink();
            _booksPage.ClickOnTheAddToCartComputingAndInternetBookButton();
            _mainPage.ClickOnTheComputeresCategoryLink();
            _computersPage.ClickOnTheNotebooksLink();
            _notebooksPage.ClickOnTheLaptopAddToCartButton();
            _mainPage.ClickOnTheApparelAndShoesCategoryLink();
            _apparelAndShoes.ClickOnBlueJeansAddToCartButton();
            _mainPage.ClickOnTheJewelryCategoryLinks();
            _jewelryPage.ClickOnTheBlackAndWhiteDimondHeartAddToCartButton();
            _mainPage.ClickOnTheShoppingCartLink();
            _cartPage.ClickOnTheCheckBoxIAgreeWithTheTermsOfService();
            _cartPage.ClickOnTheCheckOutButton();
            var personalDetailsForLogIn = new PageObjects.CheckOutGest.TestData.PersonalDetails()
            {
                Email = "AleksandrPotapov01.01.1992@gmail.com",
                Password = "AleksandrPotapov1992",
            };
            _checkOutGestPage.FillingPersonalDetails(personalDetailsForLogIn);
            _checkOutGestPage.ClickOnTheLogInButton();
            _mainPage.ClickOnTheMyAccountButton();
            _myAccountPage.ClcikOnTheAddressButton();
            _addressPage.ClickOnTheDeletButton();
            _mainPage.ClickOnTheShoppingCartLink();
            _cartPage.ClickOnTheCheckBoxIAgreeWithTheTermsOfService();
            _cartPage.ClickOnTheCheckOutButton();
            var personalDetailsForBillingAddressFields = new PageObjects.OnePageCheckOut.TestData.PersonalDetails()
            {
                City = "Kostroma",
                Address1 = "Lenina str. 15",
                ZipPostalCode = "156000",
                PhoneNumber = "8 956 345 23 24",
            };
            _onePageCheckOut.FillingBillingAddressFields(personalDetailsForBillingAddressFields);
            _onePageCheckOut.FillingShippingAddressFields();
            _onePageCheckOut.FillingShippingMethodFields();
            _onePageCheckOut.FillingPaymentMethodFields();
            var paymentInfomation = new PageObjects.OnePageCheckOut.TestData.PaymentInformation()
            {
                CardholderName = "Aleksandr Potapov",
                CardNumber = "4539809130360726",
                CardCode = "746",
            };
            _onePageCheckOut.FillingPaymentInformationFields(paymentInfomation);
            _onePageCheckOut.ClickOnTheConfirmOrderContinueButton();
            _onePageCheckOut.ClickOnTheContinueButtonAtTheCompletedPage();
            Dispose();
        }
    }

}
