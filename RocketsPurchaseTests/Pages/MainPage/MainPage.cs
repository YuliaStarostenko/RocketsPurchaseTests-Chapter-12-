using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        protected override string Url => "http://demos.bellatrix.solutions/";

        public void AddARocketToTheCartByRocketName(string rocketName)
        {
           GoTo();
           AddToCartButtonByproduct(rocketName).Click();
           ViewCartButton().Click();
        }
    }
}