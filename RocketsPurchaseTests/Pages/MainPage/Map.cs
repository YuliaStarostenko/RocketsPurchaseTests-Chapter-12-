using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public IWebElement AddToCartButtonByproduct(string productname)
        {
            return WaitAndFindElement(By.XPath($"//h2[text()='{productname}']/parent::a/following-sibling::a"));
        }
        public IWebElement RocketPriceByRocketName(string productname)
        {
            return WaitAndFindElement(By.XPath($"//h2[text()='{productname}']/following-sibling::span[@class='price']//ins//span//bdi"));
        }

        public IWebElement ViewCartButton() => WaitAndFindElement(By.CssSelector("[title='View cart']"));

    }
}