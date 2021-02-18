using OpenQA.Selenium;
using Com.Test.SamuelOkunusi.Configurations;
using Com.Test.SamuelOkunusi.Interfaces;


namespace Com.Test.SamuelOkunusi.Settings
{
    public static class ObjectRepository
    {
        public static IWebDriver Driver {get; set;}

        public static IConfig Config = new AppConfigReader();

    }

}
