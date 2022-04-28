using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace test1_project.Pages
{
	public class AtCheckBoxPage
	{
		CheckBoxPage atPage;
		public AtCheckBoxPage(CheckBoxPage page)
		{
			atPage = page;
		}

		List<string> existingValueslist = new List<string>//
		{"Home","Desktop","Notes","Commands","Documents",
		"WorkSpace","React","Angular","Veu","Office","Public","Private",
		"Classified","General","Downloads","Word File.doc","Excel File.doc"
		};

		List<string> topicalValueslist = new List<string>
		{
			"Notes","WorkSpace","Excel File.doc"
		};

		Dictionary<string, Dictionary<string, string[]>> TreedropdownDictionary =
			new Dictionary<string, string[]>
			{
				{"Home" ,
					new Dictionary <string,string[]>
					{
						{ "Desktop",new string[]{"Notes","Commands"}},

						{"Documents",
							new Dictionary<string,string[]>
							{
								{"WorkSpace",new string[]{"React","Angular","Veu"} } ,
								{"Office",new string[]{"Public","Private","Classified","General"} }
							}
                        },
							{"Downloads",new string[]{"Word File.doc","Excel File.doc"} }
						 
                    }
                }
			};


        public void ExpandTree()
        {
			atPage.ClickDropDownHome();
			atPage.ClickDropDownDeskTop();
			atPage.ClickDropDownDocuments();
			atPage.ClickDropDownDownload();
        }

		public void ValueSelection()
        {
			atPage.Clicknotes();
			atPage.Clickworkspace();
			atPage.ClickexselFile();
        }

		
	}
}

