using OpenQA.Selenium;

namespace RocketsPurchaseTests.Pages.CheckoutPage
{
    public partial class CheckoutPage : BasePage
    {
        public IWebElement FirstNameBox => WaitAndFindElement(By.Id("billing_first_name"));
        public IWebElement LastNameBox => WaitAndFindElement(By.Id("billing_last_name"));
        public IWebElement CompanyNameBox => WaitAndFindElement(By.Id("billing_company"));
        public IWebElement CountryRegionBox => WaitAndFindElement(By.Id("select2-billing_country-container"));
        public IWebElement CountrySelectByName(string countryName)
        { 
            return WaitAndFindElement(By.XPath($"//li[text()='{countryName}']"));
        } 
        public IWebElement StreetAddressBox => WaitAndFindElement(By.Id("billing_address_1"));
        public IWebElement ApartmentBox => WaitAndFindElement(By.Id("billing_address_2"));
        public IWebElement TownCityBox => WaitAndFindElement(By.Id("billing_city"));
        public IWebElement StateCountyBox => WaitAndFindElement(By.Id("select2-billing_state-container"));
        public IWebElement StateCountySelectByName(string countyName)
        {
            return WaitAndFindElement(By.XPath($"//li[text()='{countyName}']"));
        }
        public IWebElement PostcodeBox => WaitAndFindElement(By.Id("billing_postcode"));
        public IWebElement PhoneBox => WaitAndFindElement(By.Id("billing_phone"));
        public IWebElement EmailBox => WaitAndFindElement(By.Id("billing_email"));
        public IWebElement CreateAccountCheckBox => WaitAndFindElement(By.Id("createaccount"));
        public IWebElement DirectBankTransferCheckBox => WaitAndFindElement(By.Id("payment_method_bacs"));
        public IWebElement PlaceOrderButton => WaitAndFindElement(By.Id("place_order"));
        public IWebElement TotalAmount => WaitAndFindElement(By.XPath("//*[@id='order_review']/table/tfoot/tr[4]/td/strong/span/bdi"));
        public IWebElement OrderReceivedMessage => WaitAndFindElement(By.XPath("//header[@class='entry-header']/h1[@class='entry-title']"));
        public IWebElement LinkToLogIn => WaitAndFindElement(By.XPath("//a[text()='Click here to login']"));
        public IWebElement LoginUsernameOrEmailBox => WaitAndFindElement(By.Id("username"));
        public IWebElement LoginPasswordBox => WaitAndFindElement(By.Id("password"));
        public IWebElement LoginButton => WaitAndFindElement(By.XPath("//button[text()='Login']"));
        public IWebElement OrderNumber => WaitAndFindElement(By.XPath("//*[@id='post-7']/div/div/div/ul/li[1]/strong"));
        public IWebElement NavMenuButtonByName(string buttonName)
        {
            return WaitAndFindElement(By.XPath($"//ul[@class='nav-menu']//a[text()='{buttonName}']"));
        }
            
    }
}
