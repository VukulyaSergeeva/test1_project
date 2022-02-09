using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test1_project
{
    public class FormPage
    {
        IWebDriver driver;
        public FormPage(string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }

        

        private readonly string formCheckCssSelector = ".form-control.is-invalid, .was-validated .form-control:invalid";
        private readonly string firstNameLocator = "firstName";
        private readonly string lastNameLocator = "lastName";
        private readonly string emailLocator = "userEmail";
        private readonly string genderSelectLocator = "//label[@for='{0}']";
        private readonly string phoneLocator = "//input[@placeholder='Mobile Number']";
        private readonly string uploatPictureLocator = "uploadPicture";
        private readonly string addressLocator = "currentAddress";
        private readonly string subjectsLocator = "subjectsInput";
        private readonly string statesLocator = "state";
        private readonly string stateLocatorFormat = "//div[@id='state']//*[text()='{0}']";
        private readonly string citiesLocator = "city";
        private readonly string cityLocatorFormat = "//div[@id='city']//*[text()='{0}']";
        private readonly string hobbyLocatorFormat = "//label[text() = '{0}']";
        private readonly string submitLocator = "submit";

        Dictionary<string, string[]> stateAndCity = new Dictionary<string, string[]>()
        {
            { "NCR", new string[]{"Delhi", "Gurgaon", "Noida" } },
            { "Uttar Pradesh", new string[]{"Agra", "Lucknow", "Merrut"} },
            {"Haryana", new string[]{"Karnal", "Panipat"} },
            {"Rajasthan", new string[]{"Jaipur","Jiselmer"} }

        };

        public void fillName(string firstNameString, string lastNameString)
        {

            var firstName = driver.FindElement(By.Id(firstNameLocator));
            var lastName = driver.FindElement(By.Id(lastNameLocator));

            firstName.SendKeys(firstNameString);
            lastName.SendKeys(lastNameString);
        }

        public void selectGender(string gender)
        {
            string genderSelector = "";
            switch(gender)
            {
                case "Male":
                    {
                        genderSelector = "gender-radio-1";
                        break;
                    }
                case "Female":
                    {
                        genderSelector = "gender-radio-2";
                            break;
                    }
                case "Other":
                    {
                        genderSelector = "gender-radio-3";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            var element = driver.FindElement(By.XPath(string.Format(genderSelectLocator, genderSelector)));
            if(element == null)
            {
                throw new System.Exception("No gender button clicked");
            }
            element.Click();
        }
        
        public void fillEmail(string emailString)
        {
            var emailInput = driver.FindElement(By.Id(emailLocator));//3
            emailInput.SendKeys(emailString);
        }
        
                
        public void fillPhone(string phoneString)
        {
            var mobileInput = driver.FindElement(By.XPath(phoneLocator));//5
            mobileInput.SendKeys(phoneString);
        }

        internal void uploadPicture(string picturePath)
        {
            var pictureInput = driver.FindElement(By.Id(uploatPictureLocator));
            pictureInput.SendKeys(picturePath);
        }

        internal void fillAddress(string addressString)
        {
            var addressInput = driver.FindElement(By.Id(addressLocator));
            addressInput.SendKeys(addressString);
        }

        internal void fillSubjects(string subjectString)
        {
            var subjectsInput = driver.FindElement(By.Id(subjectsLocator));//7
             subjectsInput.SendKeys(subjectString);
         }

        internal void selectCity(string cityString)
        {
            string state = "";
            foreach(var item in stateAndCity)
            {
                if (item.Value.Any(cityString.Contains))
                {
                    state = item.Key;
                }
                
            }
            var states = driver.FindElement(By.Id(statesLocator));
            states.Click();
            states.FindElement(By.XPath(string.Format(stateLocatorFormat, state))).Click();
            var cities = driver.FindElement(By.Id(citiesLocator));
            cities.Click();
            cities.FindElement(By.XPath(string.Format(cityLocatorFormat, cityString))).Click();

        }

        internal void hobbies(params string[] hobbies)
        {
            foreach(var hobby in hobbies)
            {
                driver.FindElement(By.XPath(string.Format(hobbyLocatorFormat, hobby))).Click();
            }
        }

        internal void clickSubmit()
        {
            driver.FindElement(By.Id(submitLocator)).Click();
        }

        public bool CheckForm()
        {
            try
            {
                var element = driver.FindElement(By.CssSelector(formCheckCssSelector));
                return false;
            }
            catch(OpenQA.Selenium.NoSuchElementException e)
            {
                return true;
            }
        }
        public void Quit()
        {
            driver.Quit();
        }
    }

    
}
