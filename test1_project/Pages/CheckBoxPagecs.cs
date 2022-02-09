using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class CheckBoxPage : BasePage
    {
        public static string URL = "https://demoqa.com/checkbox";

        public CheckBoxPage(IWebDriver driver) : base(driver)
        {

        }
        private readonly string tree_node_homeLocator = "tree-node-home";
    }
}
