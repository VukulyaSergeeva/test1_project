using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace test1_project.Pages
{
    public class CheckBoxPage : BasePage
    {
        private readonly string homebuttonLocator = "//ol//label[contains(@for, 'home')]//preceding-sibling::button[@type='button']";
        private readonly string desktopsbuttonLocator = "//ol//label[contains(@for, 'desktop')]//preceding-sibling::button[@type='button']";
        private readonly string documentsbuttonLocator = "//ol//label[contains(@for, 'documents')]//preceding-sibling::button[@type='button']";
        private readonly string downloadsbuttonLocator = "//ol//label[contains(@for, 'downloads)]//preceding-sibling::button[@type='button']";

        private readonly string notesLocator = "//label[@for='tree-node-notes']//span[@class='rct-checkbox']";
        private readonly string workSpaceLocator = "//label[@for='tree-node-workspace']//span [@class='rct-checkbox']";
        private readonly string exselFileLocator = "//label[@for='tree-node-wordFile']//span [@class='rct-checkbox']";

        private readonly string selectionElementsLocator = "//div/span[@class='text-success']";
        public static string URL = "https://demoqa.com/checkbox";

        public CheckBoxPage(IWebDriver driver) : base(driver)
        {

        }
        private readonly string tree_node_homeLocator = "tree-node-home";

        public void ClickDropDownHome()
        {
            var homebutton = driver.FindElement(By.XPath(homebuttonLocator));
            homebutton.Click();
        }
        public void ClickDropDownDeskTop()
        {
            var desktopbutton = driver.FindElement(By.XPath(desktopsbuttonLocator));
            desktopbutton.Click();
        }
        public void ClickDropDownDocuments()
        {
            var documentsbutton = driver.FindElement(By.XPath(documentsbuttonLocator));
            documentsbutton.Click();
        }
        public void ClickDropDownDownload()
        {
            var downloadbutton = driver.FindElement(By.XPath(downloadsbuttonLocator));
            downloadbutton.Click();
        }


        public void Clicknotes()
        {
            var notes = driver.FindElement(By.XPath(notesLocator));
            notes.Click();
        }

        public void Clickworkspace()
        {
            var workspace = driver.FindElement(By.XPath(workSpaceLocator));
            workspace.Click();
        }

        public void ClickexselFile()
        {
            var exselfile = driver.FindElement(By.XPath(exselFileLocator));
            exselfile.Click();     
        }

        List<string> elementTextList;

        public List<string> GetValuesElements() 
        {
            var elementsList = driver.FindElement(By.XPath(selectionElementsLocator));
            foreach (var item in elementsList)
            {
                elementTextList.Add(item.Text());
            }
            return elementTextList;     
        }
    }
}
