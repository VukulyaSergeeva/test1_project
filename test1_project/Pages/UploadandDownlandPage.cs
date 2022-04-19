using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class UploadandDownlandPage :BasePage
    {
        private readonly string downloadLocator = "downloadButton";
        private readonly string uploadFileLocator = "uploadFile";
        public static string URL = "https://demoqa.com/upload-download";

        public UploadandDownlandPage(IWebDriver driver) : base(driver)
        {

        }
        public void Clickdownloadbutton()
        {
            var downloadbutton = driver.FindElement(By.Id(downloadLocator));
            downloadbutton.Click();
        }
        public void UploadFilebutton()
        {
            var uploadFilebutton = driver.FindElement(By.Id(uploadFileLocator));
            uploadFilebutton.SendKeys("</Users/alexanderpironen/Downloads>");
        }
    }
}
