using Com.Test.SamuelOkunusi.BaseFolder;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Test.SamuelOkunusi.Pages
{
    public class YourPersonalInfoPage : BaseClass
    {
        public YourPersonalInfoPage yourPersonalInfoPage;

        [FindsBy(How = How.CssSelector, Using = "#firstname")]
        private IWebElement firstname;

        [FindsBy(How = How.CssSelector, Using = "#old_passwd")]
        private IWebElement oldPaswd;

        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        private IWebElement newPaswd;

        [FindsBy(How = How.CssSelector, Using = "#confirmation")]
        private IWebElement confirmationpaswd;

        [FindsBy(How = How.XPath, Using = "//a[@title='Manage my personal information'] ")]
        private IWebElement myPersonalInfoLink;

        [FindsBy(How = How.XPath, Using = "//button[@name='submitIdentity']")]
        private IWebElement savePageButton;

        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement loginEmail;

        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        private IWebElement loginPaswd;

        [FindsBy(How = How.CssSelector, Using = "#SubmitLogin")]
        private IWebElement signinButton;

        [FindsBy(How = How.XPath, Using = "/a[@title='Log in to your customer account']")]
        private IWebElement loginButton;

        public YourPersonalInfoPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

    }
}
