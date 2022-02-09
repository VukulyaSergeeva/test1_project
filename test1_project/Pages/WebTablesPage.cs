using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class WebTablesPage :BasePage
    {
        public static string URL = "https://demoqa.com/webtables";

        public WebTablesPage(IWebDriver driver) : base(driver)
        {

        }
        private readonly string addButtonSelector = "addNewRecordButton";//Id
        private readonly string submitButtonSelector = "//button[@id = 'submit']";//Xpath

        public void PressAddButton()
        {
            var addButtonInput = new driver.FindElement(By.Id(addButtonSelector));
            addButtonInput.Click();
        }

        public void PressSubmitButton()
        {
            var submitbuttonInput = new driver.FindElement(By.XPath(submitButtonSelector));
            submitbuttonInput.Click();
        }
    }
}
