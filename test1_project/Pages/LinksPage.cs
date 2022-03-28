using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class LinksPage : BasePage
    {
        private readonly string homeLocator = "#simpleLink";
        private readonly string noContentLocator = "#no-content";
        private readonly string badrequestLocator = "#bed-request";
        public static string URL = "https://demoqa.com/links";

        public LinksPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
