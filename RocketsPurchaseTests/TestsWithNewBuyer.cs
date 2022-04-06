using NUnit.Framework;
using WebDriverManager.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RocketsPurchaseTests.Pages.MainPage;
using RocketsPurchaseTests.Pages.CartPage;
using RocketsPurchaseTests.Pages.CheckoutPage;
using RocketsPurchaseTests.Pages;

namespace RocketsPurchaseTests
{
    [TestFixture]
    public class PurchaseOfARocketWithANewBuyer
    {
        private static IWebDriver _driver;
        private static MainPage _mainPage;
        private static CartPage _cartPage;
        private static CheckoutPage _checkoutPage;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
            _mainPage = new MainPage(_driver);
            _cartPage = new CartPage(_driver);
            _checkoutPage = new CheckoutPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void PurchaseARocketByNameWithANewBuyer()
        {
            _mainPage.AddARocketToTheCartByRocketName("Falcon 9");
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.AssertCouponAppliedMessageAppears();
            _cartPage.AssertTotalAmountIsCorrect("54.00€");
            _cartPage.InsertNeededQuantityToCart("3");
            _cartPage.AssertTotalAmountIsCorrect("174.00€");
            var cartPageTotalAmount = _cartPage.TotalAmout.Text;
            _cartPage.ProceedToCheckOutButton.Click();
            _checkoutPage.FillInBillingDetailsInfo(CreateAClient());
            _checkoutPage.AssertTotalAmountOnCartPageAndCheckoutPageCoinside(cartPageTotalAmount, _checkoutPage.TotalAmount.Text);
            _checkoutPage.PlaceTheOrder();
            _checkoutPage.AssertOrderReceivedMessageAppears(_checkoutPage.OrderReceivedMessage.Text);

        }
        public BillingDetailsDTO CreateAClient()
        {
            var client = new BillingDetailsDTO();
            client.FirstName = "Daniel";
            client.LastName = "Donchev";
            client.CountryRegion = "Bulgaria";
            client.StreetAddress = "Lazur";
            client.TownCity = "Burgas";
            client.StateCounty = "Burgas";
            client.PostcodeZip = "8000";
            client.Phone = "+359888745896";
            client.EmailAddress = "test_email_address@yahoo.com";
            if (client.CreateAnAccount)
            {
                _checkoutPage.CreateAccountCheckBox.Click();
            }
            return client;
        }
    }
}