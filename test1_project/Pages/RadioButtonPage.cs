using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class RadioButtonPage :BasePage
    {
        private readonly string impressiveLocator = "impressiveRadio";
        public static string URL = "https://demoqa.com/radio-button";

        public RadioButtonPage(IWebDriver driver) : base(driver)
        {

        }
        public void Clickimpressivebutton()
        {
            var impressivebutton = driver.FindElement(By.Id(impressiveLocator));
            impressivebutton.Click();
        }
    }
}
