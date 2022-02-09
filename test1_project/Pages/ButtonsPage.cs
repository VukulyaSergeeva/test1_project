using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class ButtonsPage :BasePage
    {
        public static string URL = "https://demoqa.com/buttons";

        public ButtonsPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
