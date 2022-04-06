using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.MyAccountPage
{
    public partial class MyAccountPage : BasePage
    {
        public IWebElement OrdersLink => WaitAndFindElement(By.XPath("//*[@id='post-8']/div/div/nav/ul/li[2]/a"));
        public IWebElement LatestOrderNumber => WaitAndFindElement(By.XPath("//*[@id='post-8']/div/div/div/table/tbody/tr[1]/td[1]/a"));
    }
}
