using Com.Test.SamuelOkunusi.Configurations;


namespace Com.Test.SamuelOkunusi.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowserType();
        string ChromeSettingsUrl { get; }
        string Url { get; }
        string emailLoginName { get; }
        string passwordLoginName { get; }
    }  
}
