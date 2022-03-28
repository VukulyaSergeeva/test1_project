using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class CheckBoxPage : BasePage
    {
        private readonly string bottonLocator = "//ol//label[contains(@for, 'home')]//preceding-sibling::button[@type='button']";
        private readonly string notesLocator = "#//label[@for='tree-node-notes']//span[@class='rct-checkbox']";
        private readonly string workSpaceLocator = "//label[@for='tree-node-workspace']//span [@class='rct-checkbox']";
        private readonly string exselFileLocator = "//label[@for='tree-node-wordFile']//span [@class='rct-checkbox']";
        public static string URL = "https://demoqa.com/checkbox";

        public CheckBoxPage(IWebDriver driver) : base(driver)
        {

        }
        private readonly string tree_node_homeLocator = "tree-node-home";
    }
}
