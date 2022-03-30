using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class ButtonsPage :BasePage
    {
        private readonly string doubleClickLocator = "doubleClickBtn";
        private readonly string rightClickLocator = "rightClickBtn";
        private readonly string dynamicClickLocator = "P2nkr";


        public static string URL = "https://demoqa.com/buttons";

        public ButtonsPage(IWebDriver driver) : base(driver)
        {

        }
        public void Clickdoublebutton()
        {
            var doublebutton = driver.FindElement(By.Id(doubleClickLocator));
            doublebutton.Click();
            doublebutton.Click();
        }
        public void Clickrightbutton()
        {
            var rightbutton = driver.FindElement(By.Id(rightClickLocator));
            rightbutton.Click();
        }
        public void Clickdynamicbutton()
        {
            var dynamicbutton = driver.FindElement(By.Id(dynamicClickLocator));
            dynamicbutton.Click();
        }
    }
}
