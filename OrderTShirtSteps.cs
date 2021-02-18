using System;
using TechTalk.SpecFlow;
using Com.Test.SamuelOkunusi.ComponentHelpers;
using Com.Test.SamuelOkunusi.Pages;
using Com.Test.SamuelOkunusi.Settings;
using OpenQA.Selenium;

namespace RER.FunctionalTests.StepDefinitions
{
    [Binding]
    public class OrderTShirtSteps
    {
        public readonly string Url = ObjectRepository.Config.Url;
        public static YourLogoPage yourLogoPage;
        public IWebDriver driver = ObjectRepository.Driver;

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            BrowserHelper.RunBrowser();
            NavigationHelper.NavigateToUrl(Url);
        }
        
        [When(@"I click on T-Shirts tab")]
        public void WhenIClickOnT_ShirtsTab()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickTShirtTab();
        }
        
        [When(@"I select the image displayed")]
        public void WhenISelectTheImageDisplayed()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.SelectImage();
        }
        
        [When(@"select add to cart")]
        public void WhenSelectAddToCart()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.AddToCart();
        }
        
        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickProceedToCheckOut();
        }
        
        [When(@"user proceed to check out again")]
        public void WhenUserProceedToCheckOutAgain()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickProceedToCheckOut2();
        }
        
        [When(@"I enter an email address to create an account '(.*)'")]
        public void WhenIEnterAnEmailAddressToCreateAnAccount(string email)
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.EnterEmail(email);
        }
        
        [When(@"user select Create an account button")]
        public void WhenUserSelectCreateAnAccountButton()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickSubmitCreate();
        }
        
        [When(@"user fills the personal information '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenUserFillsThePersonalInformation(string title, string first_name, string last_name, string password, string day, string month, string year)
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickTitle();
            yourLogoPage.EnterFirstName(first_name);
            yourLogoPage.EnterLastName(last_name);
            yourLogoPage.EnterPassword(password);
            yourLogoPage.SelectDay(day);
            yourLogoPage.SelectMonth(month);
            yourLogoPage.SelectYear(year);
        }
        
        [When(@"fills the Address section '(.*)', '(.*)', '(.*)', '(.*)','(.*)'")]
        public void WhenFillsTheAddressSection(string address, string city, string state, string zip_code, string mobile_phone)
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.EnterAddress(address);
            yourLogoPage.EnterCity(city);
            yourLogoPage.SelectState(state);
            yourLogoPage.EnterPostCode(zip_code);
            yourLogoPage.EnterMobileNumber(mobile_phone);
        }
        
        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickRegisterButton();
        }
        
        [When(@"I select the tick box for terms of service and proceed to checkout")]
        public void WhenISelectTheTickBoxForTermsOfServiceAndProceedToCheckout()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickTickbox();
            yourLogoPage.ClickProceedToCheckOut3();
        }
        
        [When(@"I select pay by check")]
        public void WhenISelectPayByCheck()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickPayByCheck();
        }
        
        [When(@"I select I confirm my order")]
        public void WhenISelectIConfirmMyOrder()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.SelectConfirmOrder();
        }
        
        [When(@"I select My Orders at the bottom of the screen")]
        public void WhenISelectMyOrdersAtTheBottomOfTheScreen()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.ClickMyOrderLink();
        }
        
        [Then(@"I click the order reference number and primt out order ref number")]
        public void ThenIClickTheOrderReferenceNumberAndPrimtOutOrderRefNumber()
        {
            yourLogoPage = new YourLogoPage(driver);
            yourLogoPage.SelectOrderRefNumber();
        }
    }
}
