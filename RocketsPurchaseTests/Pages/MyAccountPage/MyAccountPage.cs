using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RocketsPurchaseTests.Pages.MyAccountPage
{
    public partial class MyAccountPage : BasePage
    {
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => "http://demos.bellatrix.solutions/my-account/";

        public string GetOrderNumberInMyAccoun()
        {
            OrdersLink.Click();
            return LatestOrderNumber.Text;
        }
    }
}
