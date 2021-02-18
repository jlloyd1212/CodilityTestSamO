using Com.Test.SamuelOkunusi.Interfaces;
using Com.Test.SamuelOkunusi.Settings;
using System;
using System.Configuration;

namespace Com.Test.SamuelOkunusi.Configurations
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowserType()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppsConfigKeys.Browser);

            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
        public string emailLoginName => ConfigurationManager.AppSettings.Get(AppsConfigKeys.emailLoginName);

        public string passwordLoginName => ConfigurationManager.AppSettings.Get(AppsConfigKeys.passwordLoginName);

        public string ChromeSettingsUrl => ConfigurationManager.AppSettings.Get(AppsConfigKeys.ChromeSettingsUrl);

        public string Url => ConfigurationManager.AppSettings.Get(AppsConfigKeys.Url);
    }
}
