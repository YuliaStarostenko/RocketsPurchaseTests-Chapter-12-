using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RocketsPurchaseTests.Pages.CheckoutPage
{
    public partial class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => "http://demos.bellatrix.solutions/checkout/";

        public void FillInBillingDetailsInfo(BillingDetailsDTO clientInfo)
        {
            FirstNameBox.SendKeys(clientInfo.FirstName);
            LastNameBox.SendKeys(clientInfo.LastName);
            CountryRegionBox.Click();
            CountrySelectByName(clientInfo.CountryRegion).Click();
            StreetAddressBox.SendKeys(clientInfo.StreetAddress);
            TownCityBox.SendKeys(clientInfo.TownCity);
            StateCountyBox.Click();
            StateCountySelectByName(clientInfo.StateCounty).Click();
            PostcodeBox.SendKeys(clientInfo.PostcodeZip);
            PhoneBox.SendKeys(clientInfo.Phone);
            EmailBox.SendKeys(clientInfo.EmailAddress);
            WaitForAjax();
        }
        public void PlaceTheOrder()
        {
            HoverOverPlaceOrderButton();
            PlaceOrderButton.Click();
            WaitForAjax();
        }
        public void HoverOverPlaceOrderButton()
        {
            var actions = new Actions(Driver);
            actions.MoveToElement(PlaceOrderButton).Perform();
        }
        public void LoginWithExistingClient(string email, string password)
        {
            LinkToLogIn.Click();
            WaitForAjax();
            LoginUsernameOrEmailBox.SendKeys(email);
            LoginPasswordBox.SendKeys(password);
            LoginButton.Click();
            WaitForAjax();
        }
    }
}
