using System;
using NUnit.Framework;

namespace test1_project.Pages
{
	public class AtButtonPage
	{
		ButtonsPage atPage;

		public AtButtonPage(ButtonsPage page)
		{
			atPage = page;
		}

		public void CheckFuncOfDoubleButton()
        {
			atPage.Clickdoublebutton();
        }

		public void CheckFuncOfRightButton()
        {
			atPage.Clickrightbutton();
        }

		public void CheckFuncOfDynamicButton()
        {
			atPage.Clickdynamicbutton();
        }
		public void ConfirmAtButtonPage()
        {
			Assert.That(atPage.IsOnPage(ButtonsPage.URL));
        }
	}
}

