using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace test1_project.Pages
{
    public class DynamicPropertiesPage :BasePage
    {
        private readonly string enableLocator = "enableAfter";
        private readonly string colorLocator = "colorChange";
        private readonly string visiblelocator = "visibleAfter";
        public static string URL = "https://demoqa.com/dynamic-properties";

        public DynamicPropertiesPage(IWebDriver driver) : base(driver)
        {

        }
        
        public void ClickwaitButton()
        {
            var enable = driver.FindElement(By.Id(enableLocator));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            enable = wait.Until(e=>e.FindElement(By.Id(visiblelocator)));
            enable.Click();
        }

        public void Clickcolorbutton()
        {
            var colorbutton = driver.FindElement(By.Id(colorLocator));
            colorbutton.Click();
        }

        public void Clickvisiblelocator()
        {
            var visiblebutton = driver.FindElement(By.Id(visiblelocator));
            visiblebutton.Click();
        }
    }
}
