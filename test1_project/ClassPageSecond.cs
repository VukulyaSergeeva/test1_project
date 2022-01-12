﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test1_project
{
	public class FormPageSecond
	{
		IWebDriver driver;
		public FormPageSecond(string url)
		{
			driver = new ChromeDriver();
			driver.Url = url;
		}

		private readonly string formCheckSelector = "//*[contains(@class,'field-error')]";//?
		private readonly string fullNameLocator = "userName";
		private readonly string emailLocator = "userEmail";
		private readonly string currentAdressLocator = "currentAddress";
		private readonly string permanentAddressLocator = "permanentAddress";
		private readonly string submitLocator = "submit";

		public void fullName(string fullNameString)
        {
			var fullName = driver.FindElement(By.Id(fullNameLocator));
			fullName.SendKeys(fullNameString);
        }

		public void  fillEmail(string emailString)
        {
			var email = driver.FindElement(By.Id(emailLocator));
			email.SendKeys(emailString);
        }

		public void currentAddress(string currentAddressString)
        {
			var currentAddress = driver.FindElement(By.Id(currentAdressLocator));
			currentAddress.SendKeys(currentAddressString);
        }

		public void permamentAddress(string permamentAddressString)
        {
			var permanentAddress = driver.FindElement(By.Id(permanentAddressLocator));
			permanentAddress.SendKeys(permamentAddressString);
        }

		public bool CheckForn()
        {
            try
            {

				var element = driver.FindElement(By.XPath(formCheckSelector));
				return false;
            }	
			catch(OpenQA.Selenium.NoSuchElementException e)
            {
				
				return true;
            }
        }
	}
}

