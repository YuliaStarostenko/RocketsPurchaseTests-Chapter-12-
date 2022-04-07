using NUnit.Framework;
using WebDriverManager.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RocketsPurchaseTests.Pages.MainPage;
using RocketsPurchaseTests.Pages.CartPage;
using RocketsPurchaseTests.Pages.CheckoutPage;
using RocketsPurchaseTests.Pages.MyAccountPage;

namespace RocketsPurchaseTests
{
    [TestFixture]
    public class PurchaseOfARocketWithAnExistingBuyer
    {
        private static IWebDriver _driver;
        private static MainPage _mainPage;
        private static CartPage _cartPage;
        private static CheckoutPage _checkoutPage;
        private static MyAccountPage _myAccountPage;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
            _mainPage = new MainPage(_driver);
            _cartPage = new CartPage(_driver);
            _checkoutPage = new CheckoutPage(_driver);
            _myAccountPage = new MyAccountPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void PurchaseARocketByNameWithAnExistingBuyer()
        {
            var productName = "Falcon 9";
            _mainPage.GoTo();
            _mainPage.AddARocketToCart(productName);
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.AssertCouponAppliedSuccessfully("54.00€");
            var cartPageTotalAmount = _cartPage.TotalAmout.Text;
            _cartPage.ProceedToCheckOutButton.Click();
            _checkoutPage.LoginWithExistingClient("test_email_address37@yahoo.com", "12345TestPassword");
            _checkoutPage.AssertTotalAmountOnCartPageAndCheckoutPageCoinside(cartPageTotalAmount, _checkoutPage.TotalAmount.Text);
            _checkoutPage.PlaceTheOrder();
            _checkoutPage.AssertOrderReceivedMessageAppears(_checkoutPage.OrderReceivedMessage.Text);
        }
        [Test]
        public void OrderWasSuccesfullyAddedToMyAccountOfTheExistingClient()
        {
            var productName = "Falcon 9";
            _mainPage.GoTo();
            _mainPage.AddARocketToCart(productName);
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.AssertCouponAppliedSuccessfully("54.00€");
            var cartPageTotalAmount = _cartPage.TotalAmout.Text;
            _cartPage.ProceedToCheckOutButton.Click();

            _checkoutPage.LoginWithExistingClient("test_email_address37@yahoo.com", "12345TestPassword");
            _checkoutPage.AssertTotalAmountOnCartPageAndCheckoutPageCoinside(cartPageTotalAmount, _checkoutPage.TotalAmount.Text);
            _checkoutPage.PlaceTheOrder();
            var orderNumberOnCheckOutPage = _checkoutPage.OrderNumber.Text;
            _mainPage.NavMenuButtonByName("My account").Click();
            _myAccountPage.AssertOrderIsInTheListAtMyAccount("#" + orderNumberOnCheckOutPage, _myAccountPage.TakeLatestOrderNumberInMyAccount());
        }
    }
}