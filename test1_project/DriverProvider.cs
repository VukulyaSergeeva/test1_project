using System;
using System.Collections.Generic;
using System.Text;
using test1_project.Pages;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test1_project
{
    public class DriverProvider
    {
        public static readonly ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();
        public IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                ChromeOptions options = new ChromeOptions();
                
                _storedDriver.Value = new ChromeDriver(@"C: \Users\Vikul\source\repos\test1_project\test1_project", options)
                {
                    Url = MainPage.URL//?page?
                };
            }
            return _storedDriver.Value;
        }

        public void Quit()
        {
            _storedDriver.Value.Quit();
        }
    }
}
