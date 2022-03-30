using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace test1_project.Pages
{
    public class BasePage
    {
		

		public IWebDriver driver;
		public BasePage(string url)
		{
			driver = new ChromeDriver();
			driver.Url = url;
		}

		public bool IsOnPage(string pageUrl)//открыть стр
		{
			return driver.Url.Equals(pageUrl);
		}
		public void CloseAd()//закрыть реламу
		{
			var ad = driver.FindElements(By.Id("close-fixedban"))[0];
			if (ad != null)
				ad.Click();
		}

		public BasePage(IWebDriver driver)
		{
			this.driver = driver;
		}
	}
}
