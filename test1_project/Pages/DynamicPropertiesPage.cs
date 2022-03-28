using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class DynamicPropertiesPage :BasePage
    {
        private readonly string enableLocator = "#enableAfter";
        private readonly string colorLocator = "#colorChange";
        private readonly string visiblelocator = "#visibleAfter";
        public static string URL = "https://demoqa.com/dynamic-properties";

        public DynamicPropertiesPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
