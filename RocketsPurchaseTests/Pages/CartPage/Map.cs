using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public IWebElement CouponBox => WaitAndFindElement(By.Id("coupon_code"));
        public IWebElement ApplyCouponButton => WaitAndFindElement(By.XPath("//button[text()='Apply coupon']"));
        public IWebElement ProceedToCheckOutButton => WaitAndFindElement(By.XPath("//a[contains(text(),'Proceed to checkout')]"));
        public IWebElement CouponAppliedMessage => WaitAndFindElement(By.XPath("//*[@class='woocommerce-notices-wrapper']//*[@role='alert']"));
        public IWebElement TotalAmout => WaitAndFindElement(By.XPath("//*[text()='Cart totals']/following-sibling::table//td[@data-title='Total']"));
        public IWebElement QuantityInCartBox(string productName) => Driver.FindElement(By.XPath($"//a[text()='{productName}']/ancestor::td[@class='product-name']/following-sibling::td[@class='product-quantity']//input"));
        public IWebElement UpdateCartButton => WaitAndFindElement(By.XPath("//button[@name='update_cart']"));
    }
}
