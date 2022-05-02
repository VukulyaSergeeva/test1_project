using System;
using System.Collections.Generic;
using System.Text;
using test1_project.Steps.HelperTree;

namespace test1_project.Steps
{
	public class HomeClass : IDropDownTree
	{

		private DocumentsClass documents = new DocumentsClass();
        private DesktopClass desktop = new DesktopClass();
        private DownloadsClass downloads = new DownloadsClass();

        public string GetPath()
        {
            return "home";
        }
        
    }
}

