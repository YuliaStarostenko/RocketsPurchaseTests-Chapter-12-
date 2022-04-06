﻿using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => "http://demos.bellatrix.solutions/cart/";

        public void ApplyCoupon(string coupon)
        {
            CouponBox.Clear();
            CouponBox.SendKeys(coupon);
            ApplyCouponButton.Click();
            WaitForAjax();
        }

        public void InsertNeededQuantityToCart(string quantity)
        {
            QuantityInCartBox.Clear();
            QuantityInCartBox.SendKeys(quantity);
            UpdateCartButton.Click();
            WaitForAjax();
        }

    }
}
