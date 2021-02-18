using Com.Test.SamuelOkunusi.Pages;
using Com.Test.SamuelOkunusi.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RER.FunctionalTests.StepDefinitions
{
    public class UpdateInfoSteps
    {
        public readonly string Url = ObjectRepository.Config.Url;
        public readonly string emailLoginName = ObjectRepository.Config.emailLoginName;
        public readonly string passwordLoginName = ObjectRepository.Config.passwordLoginName;
        public static YourPersonalInfoPage yourPersonalInfoPage;
        public IWebDriver driver = ObjectRepository.Driver;



    }
}
