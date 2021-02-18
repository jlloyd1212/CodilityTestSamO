using Com.Test.SamuelOkunusi.BaseFolder;
using Com.Test.SamuelOkunusi.ComponentHelpers;
using Com.Test.SamuelOkunusi.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Test.SamuelOkunusi.Pages
{
    public class YourLogoPage : BaseClass
    {
        public YourLogoPage yourLogoPage;

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[3]/a]")]
        private IWebElement tShirtTab;

        [FindsBy(How = How.CssSelector, Using = ".product_img_link")]
        private IWebElement clickImageDisplayed;

        [FindsBy(How = How.XPath, Using = "//p[@id='add_to_cart']/button")]
        private IWebElement selectAddToCart;

        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to checkout']")]
        private IWebElement proceedToCheckout;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[2]/a[1]")]
        private IWebElement proceedToCheckout2;

        [FindsBy(How = How.CssSelector, Using = "#email_create")]
        private IWebElement emailCreate;

        [FindsBy(How = How.CssSelector, Using = "#SubmitCreate")]
        private IWebElement submitCreate;

        [FindsBy(How = How.CssSelector, Using = "#id_gender1")]
        private IWebElement title;

        [FindsBy(How = How.CssSelector, Using = "#customer_firstname")]
        private IWebElement firstname;

        [FindsBy(How = How.CssSelector, Using = "##customer_lastname")]
        private IWebElement lastname;

        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        private IWebElement password_;

        [FindsBy(How = How.CssSelector, Using = "#days")]
        private IWebElement days;

        [FindsBy(How = How.CssSelector, Using = "#months")]
        private IWebElement monthOfBirth;

        [FindsBy(How = How.CssSelector, Using = "#uniform-years")]
        private IWebElement yearOfBirth;

        [FindsBy(How = How.CssSelector, Using = "#address1")]
        private IWebElement address_;

        [FindsBy(How = How.CssSelector, Using = "#city")]
        private IWebElement city_;

        [FindsBy(How = How.XPath, Using = "#uniform-id_state")]
        private IWebElement state_;

        [FindsBy(How = How.CssSelector, Using = "#postcode")]
        private IWebElement zipcode;

        [FindsBy(How = How.CssSelector, Using = "#phone_mobile")]
        private IWebElement mobilePhone;

        [FindsBy(How = How.CssSelector, Using = "#submitAccount")]
        private IWebElement registerButton;

        [FindsBy(How = How.XPath, Using = "//button[@name='processAddress']")]
        private IWebElement proceedToCheckout3;

        [FindsBy(How = How.CssSelector, Using = "#cgv")]
        private IWebElement termsOfServiceBox;

        [FindsBy(How = How.XPath, Using = "//button[@name='processCarrier']")]
        private IWebElement proceedToCheckout4;

        [FindsBy(How = How.XPath, Using = "//a[@title='Pay by check.']")]
        private IWebElement selectPayByCheck;

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn btn-default button-medium']")]
        private IWebElement confirmOrder;

        [FindsBy(How = How.XPath, Using = "//a[@title='My orders']")]
        private IWebElement myOrdersLink;

        [FindsBy(How = How.XPath, Using = "//a[@class='color-myaccount']")]
        private IWebElement orderReferenceNumber;

        public YourLogoPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        public void ClickTShirtTab()
        {
            tShirtTab = ObjectRepository.Driver.FindElement(By.XPath("*[@id='block_top_menu']/ul/li[3]/a]"));
            MethodHelpers.WaitForElementToBeDisplayed(tShirtTab);
            tShirtTab.Click();
        }
        public void SelectImage()
        {
            clickImageDisplayed = ObjectRepository.Driver.FindElement(By.CssSelector(".product_img_link"));
            MethodHelpers.WaitForElementToBeDisplayed(clickImageDisplayed);
            clickImageDisplayed.Click();
        }

        public void AddToCart()
        {
            selectAddToCart = ObjectRepository.Driver.FindElement(By.XPath("//p[@id='add_to_cart']/button"));
            MethodHelpers.WaitForElementToBeDisplayed(selectAddToCart);
            selectAddToCart.Click();
        }
        public void ClickProceedToCheckOut()
        {
            proceedToCheckout = ObjectRepository.Driver.FindElement(By.XPath("//a[@title='Proceed to checkout']"));
            MethodHelpers.WaitForElementToBeDisplayed(proceedToCheckout);
            proceedToCheckout.Click();
        }
        public void ClickProceedToCheckOut2()
        {
            proceedToCheckout2 = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
            MethodHelpers.WaitForElementToBeDisplayed(proceedToCheckout2);
            proceedToCheckout2.Click();
        }
        public void EnterEmail(string email)
        {
            emailCreate = ObjectRepository.Driver.FindElement(By.CssSelector("#email_create"));
            MethodHelpers.WaitForElementToBeDisplayed(emailCreate);
            emailCreate.SendKeys(email);
        }
        public void ClickSubmitCreate()
        {
            submitCreate = ObjectRepository.Driver.FindElement(By.CssSelector("#SubmitCreate"));
            MethodHelpers.WaitForElementToBeDisplayed(submitCreate);
            submitCreate.Click();
        }
        public void ClickTitle()
        {
            title = ObjectRepository.Driver.FindElement(By.CssSelector("# id_gender1"));
            MethodHelpers.WaitForElementToBeDisplayed(title);
            title.Click();
        }
        public void EnterFirstName(string first_name)
        {
            firstname = ObjectRepository.Driver.FindElement(By.CssSelector("#customer_firstname"));
            MethodHelpers.WaitForElementToBeDisplayed(firstname);
            firstname.SendKeys(first_name);
        }
        public void EnterLastName(string last_name)
        {
            lastname = ObjectRepository.Driver.FindElement(By.CssSelector("#customer_lastname"));
            MethodHelpers.WaitForElementToBeDisplayed(lastname);
            lastname.SendKeys(last_name);
        }
        public void EnterPassword(string password)
        {
            password_ = ObjectRepository.Driver.FindElement(By.CssSelector("#passwd"));
            MethodHelpers.WaitForElementToBeDisplayed(password_);
            password_.SendKeys(password);
        }
        public void SelectDay(string day)
        {
            days = ObjectRepository.Driver.FindElement(By.CssSelector("#days"));
            driver = ObjectRepository.Driver;
            SelectElement selectElement = new SelectElement(driver.FindElement(By.CssSelector("#days")));
            MethodHelpers.WaitForPageToLoad(days);
            selectElement.SelectByText(day);
        }
        public void SelectMonth(string month)
        {
            monthOfBirth = ObjectRepository.Driver.FindElement(By.CssSelector("#months"));
            driver = ObjectRepository.Driver;
            SelectElement selectElement = new SelectElement(driver.FindElement(By.CssSelector("#months")));
            MethodHelpers.WaitForPageToLoad(monthOfBirth);
            selectElement.SelectByValue(month);
        }
        public void SelectYear(string year)
        {
            yearOfBirth = ObjectRepository.Driver.FindElement(By.CssSelector("#uniform-years"));
            driver = ObjectRepository.Driver;
            SelectElement selectElement = new SelectElement(driver.FindElement(By.CssSelector("#uniform-years")));
            MethodHelpers.WaitForPageToLoad(yearOfBirth);
            selectElement.SelectByValue(year);
        }
        public void EnterAddress (string address)
        {
            address_ = ObjectRepository.Driver.FindElement(By.CssSelector("#address1"));
            MethodHelpers.WaitForElementToBeDisplayed(address_);
            address_.SendKeys(address);
        }
        public void EnterCity(string city)
        {
            city_ = ObjectRepository.Driver.FindElement(By.CssSelector("#city"));
            MethodHelpers.WaitForElementToBeDisplayed(city_);
            city_.SendKeys(city);
        }
        public void SelectState(string state)
        {
            state_ = ObjectRepository.Driver.FindElement(By.CssSelector("#uniform-id_state"));
            driver = ObjectRepository.Driver;
            SelectElement selectElement = new SelectElement(driver.FindElement(By.CssSelector("#uniform-id_state")));
            MethodHelpers.WaitForPageToLoad(state_);
            selectElement.SelectByValue(state);
        }
        public void EnterPostCode(string zip_code)
        {
            zipcode = ObjectRepository.Driver.FindElement(By.CssSelector("#postcode"));
            MethodHelpers.WaitForElementToBeDisplayed(zipcode);
            zipcode.SendKeys(zip_code);
        }
        public void EnterMobileNumber(string mobile_phone)
        {
            mobilePhone = ObjectRepository.Driver.FindElement(By.CssSelector("#phone_mobile"));
            MethodHelpers.WaitForElementToBeDisplayed(mobilePhone);
            mobilePhone.SendKeys(mobile_phone);
        }
        public void ClickRegisterButton()
        {
            registerButton = ObjectRepository.Driver.FindElement(By.CssSelector("#submitAccount"));
            MethodHelpers.WaitForElementToBeDisplayed(registerButton);
            mobilePhone.Click();
        }
        public void ClickProceedToCheckOut3()
        {
            proceedToCheckout3 = ObjectRepository.Driver.FindElement(By.XPath("//button[@name='processAddress']"));
            MethodHelpers.WaitForElementToBeDisplayed(proceedToCheckout3);
            proceedToCheckout3.Click();
        }
        public void ClickTickbox()
        {
            termsOfServiceBox = ObjectRepository.Driver.FindElement(By.CssSelector("#cgv"));
            MethodHelpers.WaitForElementToBeDisplayed(termsOfServiceBox);
            termsOfServiceBox.Click();
        }
        public void ClickProceedToCheckOut4()
        {
            proceedToCheckout4 = ObjectRepository.Driver.FindElement(By.XPath("//button[@name='processCarrier']"));
            MethodHelpers.WaitForElementToBeDisplayed(proceedToCheckout4);
            proceedToCheckout4.Click();
        }
        public void ClickPayByCheck()
        {
            selectPayByCheck = ObjectRepository.Driver.FindElement(By.XPath("//a[@title='Pay by check.']"));
            MethodHelpers.WaitForElementToBeDisplayed(selectPayByCheck);
            selectPayByCheck.Click();
        }
        public void SelectConfirmOrder()
        {
            confirmOrder = ObjectRepository.Driver.FindElement(By.XPath("//button[@class='button btn btn-default button-medium']"));
            MethodHelpers.WaitForElementToBeDisplayed(confirmOrder);
            confirmOrder.Click();
        }
        public void ClickMyOrderLink()
        {
            myOrdersLink = ObjectRepository.Driver.FindElement(By.XPath("//a[@title='My orders']"));
            MethodHelpers.WaitForElementToBeDisplayed(myOrdersLink);
            myOrdersLink.Click();
        }
        public void SelectOrderRefNumber()
        {
            orderReferenceNumber = ObjectRepository.Driver.FindElement(By.XPath("//a[@class='color-myaccount']"));
            MethodHelpers.WaitForElementToBeDisplayed(orderReferenceNumber);
            orderReferenceNumber.Click();
            Console.WriteLine("orderReferenceNumber dispplays as " + orderReferenceNumber.Text);
        }

    }


}
