using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.MyAccountPage
{
    public partial class MyAccountPage : BasePage
    {
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => "http://demos.bellatrix.solutions/my-account/";

        public string TakeLatestOrderNumberInMyAccount()
        {
            OrdersLink.Click();
            return IOrderNumberorLatest().Text;
        }
    }
}