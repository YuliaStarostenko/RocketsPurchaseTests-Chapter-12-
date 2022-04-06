using NUnit.Framework;

namespace RocketsPurchaseTests.Pages.MyAccountPage
{
    public partial class MyAccountPage : BasePage
    {
        public void AssertOrderIsInTheListAtMyAccount(string orderNumberCheckoutpage, string orderNumberMyAccountPage)
        {
            Assert.AreEqual(orderNumberCheckoutpage, orderNumberMyAccountPage);
        }
    }
}
