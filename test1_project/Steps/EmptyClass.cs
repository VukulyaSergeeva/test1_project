using System;
using System.Collections.Generic;

namespace test1_project.Steps
{
	public class EmptyClass
	{
		List<string> itemList;
		public EmptyClass()
		{

			
		}
		public void TestCheckbox()
		{
			//<...>
			List<string> selection = new List<string> { "Desktop" };
            User.atCheckboxPage.SelectItems(selection);
			bool result = User.atCheckboxPage.CheckItems(selection);//test
			Assert.True(result);
		}

		public void SelectItems(List<string> selectionList)
        {
			Dictionary<string, string[]> dropdownDict =
				new Dictionary<string, string[]>
				{
					{"Desktop", new string[] {"Notes", "Commands" } },


					{"J",new string[]{"ng","lgne"} },

					{"slejdewf",new string[]{"Jfknjef","fnekfj"} }

				};

			foreach (var item in selectionList)
            {
				var dropdownItems = dropdownDict[item];
				atCheckboxPage.ClickCheckbox(item);

            }
			//DIC DESCRIPTION
			List<string> formattedList;//general list
			foreach (var item in selectionList)
            {
				formattedList.Add(item);
				formattedList.AddRange(dropdownDict[item]);
            }

        }

		public bool CheckItems(List<string> itemList)
        {		

			var elements = atCheckboxPage.GetSelectedElements();

			foreach (var item in elements)
            {
				if (!itemList.Contains(item))
                {
					return false;
                }
				if(itemList.Count != elements.Count)
                {
					return false;
                }
            }
			return true;

		}
		List<string> elementTextList;
		public List<string> GetSelectedElements()//page
        {
			var elementList = driver.FindElements(By.XPath("<...>"));
			
			foreach (var item in elementList)
            {
				elementTextList.Add(item.Text());
            }
			return elementTextList;
        }
	}
}

