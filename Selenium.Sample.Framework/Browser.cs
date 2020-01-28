using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Sample.Framework
{
    public static class Browser
    {
        private static ChromeOptions setOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            return options;
        }
        public static IWebDriver driver = new ChromeDriver(setOptions());

        public static void Goto(string url)
        {
            driver.Url = url;        
        }

        public static string Title
        {
            get { return driver.Title; }
        }
        public static void Close()
        {
            driver.Close();
        }
    }
}
