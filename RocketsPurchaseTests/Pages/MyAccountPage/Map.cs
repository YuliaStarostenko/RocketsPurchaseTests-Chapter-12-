using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.MyAccountPage
{
    public partial class MyAccountPage : BasePage
    {
        public IWebElement OrdersLink => WaitAndFindElement(By.XPath("//*[contains(@class,'woocommerce-MyAccount-navigation')]//a[contains(text(),'Orders')]"));
        public IWebElement IOrderNumberorLatest(int i = 0) => WaitAndFindElement(By.XPath($"//*[@id='post-8']/div/div/div/table/tbody/tr[{i+1}]/td[1]/a"));
    }
}