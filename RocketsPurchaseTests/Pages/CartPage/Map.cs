using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public IWebElement CouponBox => WaitAndFindElement(By.Id("coupon_code"));
        public IWebElement ApplyCouponButton => WaitAndFindElement(By.XPath("//div[@class='coupon']/button"));
        public IWebElement ProceedToCheckOutButton => WaitAndFindElement(By.XPath("//a[@class='checkout-button button alt wc-forward']"));
        public IWebElement CouponAppliedMessage => WaitAndFindElement(By.XPath("//div[@class='woocommerce']//div[@role='alert']"));
        public IWebElement TableLineShowingCoupon => WaitAndFindElement(By.XPath("//table[@class='shop_table shop_table_responsive']/tbody/tr[2]/th"));
        public IWebElement TotalAmout => WaitAndFindElement(By.XPath("//tr[@class='order-total']/td//span/bdi"));
        public IWebElement QuantityInCartBox => WaitAndFindElement(By.XPath("//input[@title='Qty']"));
        public IWebElement UpdateCartButton => WaitAndFindElement(By.XPath("//button[@name='update_cart']"));
    }
}
