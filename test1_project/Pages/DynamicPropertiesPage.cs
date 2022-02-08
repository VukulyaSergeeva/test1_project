using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class DynamicPropertiesPage :BasePage
    {
        public static string URL = "https://demoqa.com/dynamic-properties";

        public DynamicPropertiesPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
