using System;
using System.Collections.Generic;

namespace test1_project.Steps.HelperTree
{
	public class DesktopClass : HomeClass
	{
		
		//List<string> Desktop = new List<string> { "Notes", "Commands" };
		public string notes
        {
            get
            {
				return GetPath() + "notes";
            }
            set { }
        }
		public string commands
        {
            get
            {
                return GetPath() + "commands";
            }
            set { }
        }
        public new string GetPath()
        {
            return base.GetPath() + "desktop";
        }

        
    }
}

