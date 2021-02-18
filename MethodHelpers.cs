using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Com.Test.SamuelOkunusi.Settings;
using System;

namespace Com.Test.SamuelOkunusi.ComponentHelpers
{

    public static class MethodHelpers
    {
        public static bool IsElementPresent(IWebElement element)
        {
            bool isDisplayed = false;
            try
            {
                isDisplayed = WaitForElementToBeVisible(element);
            }
            catch (NoSuchElementException e)
            {
                e.Message.ToString();
                e.GetBaseException();

            }
            return isDisplayed;
        }
        public static void WaitForPageToLoad()
        {
            IWait<IWebDriver> wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(20));
            wait.PollingInterval = TimeSpan.FromMilliseconds(20);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(PageLoaded()).Equals("complete");
        }
        public static bool ElementNotPresent(IWebElement element)
        {
            return !IsElementPresent(element);
        }
        //public static IWebElement GetElement(IWebElement element)
        //{
        //    if (IsElementPresent(element))
        //    {
        //        return element;
        //    }
        //    else
        //    {
        //        throw new RERException(message: $"{element.ToString()} not visible to be interacted with");
        //    }
        //}
        public static void PageLoadTimeout(string url)
        {
            ObjectRepository.Driver.Manage().Timeouts().PageLoad.TotalSeconds.Equals(TimeSpan.FromSeconds(10));
            NavigationHelper.NavigateToUrl(url);
        }
        public static void DynamicWait(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementSelectionStateToBe(element, true));
        }
       
        public static void WaitForElementToDisappear(IWebElement element)
        {
            IWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            wait.Until(WaitForElementToBeInvisible(element));
        }
        public static bool WaitForElementToBeDisplayed(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.PollingInterval = TimeSpan.FromMilliseconds(10000);
            wait.Timeout = TimeSpan.FromSeconds(10000);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(WaitForElementToBeSeen(element));
        }
        public static IWebElement WaitForElementToBeClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(3000));
            wait.PollingInterval = TimeSpan.FromMilliseconds(3000);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
        public static IWebElement WaitForLinkTextElementToBeClickable(string linkText)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromMilliseconds(10000);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ObjectRepository.Driver.FindElement(By.PartialLinkText(linkText))));
        }
        public static bool WaitForElementToBeVisible(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromMilliseconds(6000);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(WaitForElementVisibility(element));
        }
        private static Func<IWebElement, bool> WaitForElementToBeSeen(IWebElement element)
        {
            return ((x) =>      
            {
                return element.Displayed;

            });
        }
        private static Func<IWebElement, bool> WaitForElementToBeInvisible(IWebElement element)
        {
            return ((x) =>
            {
                try
                {
                    return !element.Displayed;
                }
                catch (Exception)
                {
                    return true;
                }
            });
        }
        private static Func<IWebDriver, bool> WaitForElementVisibility(IWebElement element)
        {
            return ((x) =>
            {
                return element.Enabled;

            });
        }
  
        public static void WaitForPageToLoad(IWebElement element)
        {
            IWait<IWebDriver> wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromMilliseconds(10000);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(PageLoaded()).Equals("complete");
        }
        private static Func<IWebDriver, string> PageLoaded()
        {
            return ((x) =>
            {
                return ExecuteScriptWithValueReturned("return document.readyState");
            });
        }
        public static void ExecuteScript(string script)
        {
            IJavaScriptExecutor scriptExecutor = (IJavaScriptExecutor)ObjectRepository.Driver;
            scriptExecutor.ExecuteScript(script);
        }
        private static string ExecuteScriptWithValueReturned(string script)
        {
            IJavaScriptExecutor scriptExecutor = (IJavaScriptExecutor)ObjectRepository.Driver;
            return scriptExecutor.ExecuteScript(script).ToString();
        }
        public static void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)ObjectRepository.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
      
        public static void AcceptAlertBox(IWebDriver driver)
        {
            _ = (IJavaScriptExecutor)ObjectRepository.Driver;
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        public static void DismissAlertBox(IWebDriver driver)
        {
            _ = (IJavaScriptExecutor)ObjectRepository.Driver;
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }
    
        public static void SelectDropdown(IWebElement element, String text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }
        public static void MoveToElementAndDoubleClick(this IWebElement element)
        {
            Actions actions = new Actions(ObjectRepository.Driver);
            actions.MoveToElement(element).DoubleClick().Perform();
        }
        public static void ScrollToView(this IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)ObjectRepository.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            ((IJavaScriptExecutor)ObjectRepository.Driver).ExecuteScript("arguments[0].click();", element);
        }

    }
}


