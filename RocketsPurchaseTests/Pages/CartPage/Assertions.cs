using NUnit.Framework;

namespace RocketsPurchaseTests.Pages.CartPage
{
    public partial class CartPage
    {
        public void AssertCouponAppliedMessageAppears()
        {
            Assert.AreEqual("Coupon code applied successfully.", CouponAppliedMessage.Text);
        }

        public void AssertTotalAmountIsCorrect(string totalAmountExpected)
        {
            Assert.AreEqual(totalAmountExpected, TotalAmout.Text);
        }
    }
}
