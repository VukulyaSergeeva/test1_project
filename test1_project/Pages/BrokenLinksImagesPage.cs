using System;
using System.Collections.Generic;
using System.Text;

namespace test1_project.Pages
{
    public class BrokenLinksImagesPage :BasePage
    {
        public static string URL = "https://demoqa.com/broken";

        public BrokenLinksImagesPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
