using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class ButtonsPage :BasePage
    {
        private readonly string doubleClickLocator = "#doubleClickBtn";
        private readonly string rightClickLocator = "#rightClickBtn";
        private readonly string dynamicClickLocator = "#P2nkr";


        public static string URL = "https://demoqa.com/buttons";

        public ButtonsPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
