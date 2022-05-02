using System;
using System.Collections.Generic;

namespace test1_project.Steps.HelperTree
{
	public class DownloadsClass:HomeClass
	{
		
		//List<string> Download = new List<string> { "Word File.doc", "Excel File.doc" };
		public string worldFile
        {
            get
            {
				return GetPath() + "word file";

			}
            set { }
        }
		public string excelFile
        {
			get
            {
				return GetPath() + "excel file";

			}
			set { }
        }
		public new string GetPath()
		{
			return base.GetPath() + "downloads";
		}
	}
}

