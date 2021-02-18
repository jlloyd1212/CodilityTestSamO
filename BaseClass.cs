using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Com.Test.SamuelOkunusi.Settings;
using TechTalk.SpecFlow;

namespace Com.Test.SamuelOkunusi.BaseFolder
{
    [Binding]
    public class BaseClass
    {
        protected IWebDriver driver;
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy.Equals(1);
            //options.AddArguments("--headless");
            options.AddArguments("incognito");
            options.AddArguments("start-maximized", "-no-sandbox");
            options.Proxy = null;
            return options;
        }
        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            driver.Manage().Window.Maximize();
            return driver;
        }

        [BeforeTestRun]
        public static void DoSetup()
        {
            //AppDriver.InitBrowser(ObjectRepository.Config.GetBrowserType());
            ObjectRepository.Config.GetBrowserType();
        }

        [AfterTestRun]
        public static void CloseDriver()
        {
            //AppDriver.CloseDriver();
        }

    }
}
