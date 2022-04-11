using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class LinksPage : BasePage
    {
        private readonly string homeLocator = "simpleLink";
        private readonly string noContentLocator = "no-content";
        private readonly string badrequestLocator = "bed-request";
        public static string URL = "https://demoqa.com/links";

        public LinksPage(IWebDriver driver) : base(driver)
        {

        }
        public void ClickhomeLocator()
        {
            var homebutton = driver.FindElement(By.Id(homeLocator));
            homebutton.Click();
        }
        public void ClicknoContentbutton()
        {
            var noContentbutton = driver.FindElement(By.Id(noContentLocator));
            noContentbutton.Click();
        }
        public void Clickbadrequestbutton()
        {
            var badrequestbutton = driver.FindElement(By.Id(badrequestLocator));
            badrequestbutton.Click();
        }
    }
}
