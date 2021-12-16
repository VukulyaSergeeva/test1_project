using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test1_project
{
    public class Tests
    {       

    IWebDriver driver = new ChromeDriver();
    

        [Test]
    public void FirstTest()
        {
            driver.Url = "https://google.com";//1
            var element = driver.FindElement(By.XPath("//input[@name='q']"));//2
            element.SendKeys("eggs");
            element.Submit();//3
            var result = driver.FindElement(By.XPath("//div[@class='g']//h3")).Text.ToLower();//4

            bool check = result.Contains("eggs");
            Assert.IsTrue(check);
            driver.Quit();
        }

        [Test]
    public void SecondTEst()
        {
            
                driver.Url = "https://demoqa.com/automation-practice-form";//1
                var firstname = driver.FindElement(By.Id("firstName"));//2
                firstname.SendKeys("Tom");
                var secondname = driver.FindElement(By.Id("lastName"));
                secondname.SendKeys("Sterlinge");
                var email = driver.FindElement(By.Id("userEmail"));//3
                email.SendKeys("vikulya.sergeeva99@inbox.ru");
                var gender = driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));//4
                gender.Click();
                var mobile = driver.FindElement(By.XPath("//input[@placeholder='Mobile Number']"));//5
                mobile.SendKeys("295235294");
                //var birthday = driver.FindElement(By.Id("dateOfBirthInput"));//6
                //birthday.Clear();
                //birthday.SendKeys("12 Nov 2000");
                var subjects = driver.FindElement(By.Id("subjectsInput"));//7
                subjects.SendKeys("maths, physics");
                var hobbies = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));//8
                hobbies.Click();
                var picture = driver.FindElement(By.Id("uploadPicture"));
                picture.SendKeys("/Users/viktoriasergeeva/Desktop/фото мои/198.jpg");
                var address = driver.FindElement(By.Id("currentAddress"));
                address.SendKeys("Могилев,ул.Челюскинцев 170В,62");
                var states = driver.FindElement(By.Id("state"));
                states.Click();
                states.FindElement(By.Id("react-select-3-option-0")).Click();
            //TODO:click for city
                var fieldCheck = driver.FindElement(By.CssSelector(".form-control.is-valid, .was-validated .form-control:valid"));
                bool result = fieldCheck == null;
                Assert.IsTrue(result);
            Assert.IsNotNull(fieldCheck);
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }

    
}
