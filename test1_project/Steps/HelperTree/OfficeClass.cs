using System;
using System.Collections.Generic;
namespace test1_project.Steps.HelperTree
{
	public class OfficeClass : DocumentsClass
	{

		//List<string> Office = new List<string> { "Public", "Private", "Classified", "General" };
		public string Public
        {
            get
            {
                return GetPath() + "public";
            }
            set { }
        }
        public string Private
        {    get
            {
                return GetPath() + "private";
            }
            set { }
        }
        public string classified
        {
            get
            {
                return GetPath() + "classified";
            }
            set { }
        }
        public string general
        {
            get
            {
                return GetPath() + "general";
            }
            set { }
        }
        public new string GetPath()
        {
            return base.GetPath() + "office";
        }
    }
}

