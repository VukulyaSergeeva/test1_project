using System;
using System.Collections.Generic;
using System.Text;
using test1_project.Pages;

namespace test1_project
{
    public class User
    {
        public BrokenLinksImagesPage brokenLinksPage;
        public ButtonsPage buttonsPage;
        public CheckBoxPage checkBoxPage;
        public DynamicPropertiesPage dynamicPropertiesPage;
        public LinksPage linksPage;
        public RadioButtonPage radioButtonPage;
        public TextBoxPage textBoxPage;
        public UploadandDownlandPage uploadandDownlandPage;
        public WebTablesPage webTablesPage;

        public PageProvider pageProvider;
        public User()
        {

        }

        public User(PageProvider pageProvider)
        {
            this.pageProvider = pageProvider;

        }
    }
}
