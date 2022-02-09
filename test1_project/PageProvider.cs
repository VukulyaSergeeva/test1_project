using NUnit.Framework;
using OpenQA.Selenium;
using System;
using test1_project.Pages;

namespace test1_project
{
    public class PageProvider
    {
        DriverProvider provider;
        public void Quit()
        {
            provider.Quit();
        }
        public IWebDriver setDriver()
        {
            if (provider == null)
            {
                provider = new DriverProvider();
            }
            return provider.GetDriver();
        }
    }
}
