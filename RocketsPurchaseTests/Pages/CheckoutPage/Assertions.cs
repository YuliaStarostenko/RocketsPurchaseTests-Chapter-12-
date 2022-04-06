using NUnit.Framework;

namespace RocketsPurchaseTests.Pages.CheckoutPage
{
    public partial class CheckoutPage : BasePage
    {
        
        public void AssertTotalAmountOnCartPageAndCheckoutPageCoinside(string cartPageAmount, string checkoutPageAmount)
        {
            Assert.AreEqual(cartPageAmount, checkoutPageAmount);
        }
        public void AssertOrderReceivedMessageAppears(string message)
        {
            Assert.AreEqual("Order received", message);
        }
    }
}