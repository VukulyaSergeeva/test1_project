using System;
using NUnit.Framework;
using test1_project;

namespace test1_project
{
    public class TestClass
    {
        FormPage page;

        [SetUp]
        public void Setup()
        {
            //TODO: Connect to DB and get form data
        }

        [Test]
        public void FirstTest()
        {
            page = new FormPage("https://demoqa.com/automation-practice-form");
            page.fillName("Tom", "Sterling");
            page.fillEmail("jdgjksbgsj@jhdgfs.fe");
            page.selectGender("Male");
            page.uploadPicture("/Users/viktoriasergeeva/Desktop/фото мои/198.jpg");
            page.fillAddress("Могилев,ул.Челюскинцев 170В,62");
            page.fillPhone("1234567891");
            page.fillSubjects("maths, physics");
            page.selectCity("Karnal");
            page.hobbies("Music","Sports");
            page.clickSubmit();
            Assert.IsTrue(page.CheckForm(), "Form Is Not Valid");
            
        }
        [TearDown]
        public void TearDown()
        {
            page.Quit();
        }

    }
}
