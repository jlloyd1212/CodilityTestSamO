using OpenQA.Selenium;
using Com.Test.SamuelOkunusi.Settings;


namespace Com.Test.SamuelOkunusi.ComponentHelpers
{
    public class NavigationHelper
    {
        public static readonly string ChromeSettingsURL = ObjectRepository.Config.ChromeSettingsUrl;

        public static void NavigateToUrl(string URL)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(URL);
        }

    }
}

