using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class WebTablesPage :BasePage
    {
        public static string URL = "https://demoqa.com/webtables";

        public WebTablesPage(IWebDriver driver) : base(driver)
        {

        }

        private readonly string addButtonLocator = "addNewRecordButton";
        private readonly string searchBoxLocator = "searchBox";
        private readonly string firstNameLocator = "firstName";
        private readonly string lastNameLocator = "lastName";
        private readonly string emailLocator = "userEmail";
        private readonly string ageLocator = "age";
        private readonly string salaryLocator = "salary";
        private readonly string departmentLocator = "department";
        private readonly string submitButtonLocator = "submit";
        private readonly string addButtonSelector = "addNewRecordButton";//Id
        private readonly string submitButtonSelector = "//button[@id = 'submit']";//Xpath

        public void ClickAddButton()
        {
            var addButton = driver.FindElement(By.Id(addButtonLocator));
            addButton.Click();
        }

        public void EnterFirsthName(string firstName)
        {
            var firstNamestr = driver.FindElement(By.Id(searchBoxLocator));
            firstNamestr.SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            var lastNamestr = driver.FindElement(By.Id(lastNameLocator));
            lastNamestr.SendKeys(lastName);
        }
        public void Enteremail(string email)
        {
            var emailstr = driver.FindElement(By.Id(emailLocator));
            emailstr.SendKeys(email);
        }
        public void Enterage(string age)
        {
            var agestr = driver.FindElement(By.Id(ageLocator));
            agestr.SendKeys(age);
        }
        public void Entersalary(string salary)
        {
            var salarystr = driver.FindElement(By.Id(salaryLocator));
            salarystr.SendKeys(salary);
        }
        public void Enterdepartment(string department)
        {
            var departmentstr = driver.FindElement(By.Id(departmentLocator));
            departmentstr.SendKeys(department);
        }

        public void ClickSubmitButton()
        {
            var submitbutton = driver.FindElement(By.XPath(submitButtonLocator));
            submitbutton.Click();
        }

        public void ClicksearchBox(string firstName)
        {
            var searchBox = driver.FindElement(By.Id(searchBoxLocator));
            searchBox.SendKeys(firstName);
        }
    }
}
