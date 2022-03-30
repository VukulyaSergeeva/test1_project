using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class BrokenLinksImagesPage :BasePage
    {
        //private readonly string formCheckCssSelector = "";
        private readonly string validLinkLocator = "//div//p[text()='Broken Link']//preceding-sibling::a";
        private readonly string brokenLinkLocator = "//div//p[text()='Broken Link']//following-sibling::a";


        public static string URL = "https://demoqa.com/broken";

        public BrokenLinksImagesPage(IWebDriver driver) : base(driver)
        {

        }
        public void ClickvalidLink()
        {
            var validLinkbutton = driver.FindElement(By.XPath(validLinkLocator));
            validLinkbutton.Click();
        }
        public void ClickbrokenLinlk()
        {
            var brokenLinkbutton=driver.FindElement(By.XPath(brokenLinkLocator));
            brokenLinkbutton.Click();
        }
    }
}
