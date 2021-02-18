using Com.Test.SamuelOkunusi.BaseFolder;
using Com.Test.SamuelOkunusi.Configurations;
using Com.Test.SamuelOkunusi.Settings;
using System;

namespace Com.Test.SamuelOkunusi.ComponentHelpers
{
    public class BrowserHelper
    {
        public static void RunBrowser()
        {
            switch (ObjectRepository.Config.GetBrowserType())

            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = BaseClass.GetChromeDriver();
                    break;
                default:
                    throw new Exception("Provided driver in App.config file is not supported " + ObjectRepository.Config.GetBrowserType());
            }
            MethodHelpers.WaitForPageToLoad();
        }
    }
}
