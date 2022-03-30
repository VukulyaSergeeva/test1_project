using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class MainPage :BasePage
    {

        private readonly string elementLocator = "//h5[text()='Elements']";

        public static string URL = "https://demoqa.com/";

        public MainPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
