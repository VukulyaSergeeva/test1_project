using System;
using NUnit.Framework;

namespace test1_project.Pages//Steps
{
	public class AtBrokenLinksImagesPage
	{
		BrokenLinksImagesPage atPage;

		public AtBrokenLinksImagesPage(BrokenLinksImagesPage page)
		{
			atPage = page;
		}

		public void CheckValidLink()
        {
			atPage.ClickvalidLink();
        }

		public void CheckBrokenLink()
        {
			atPage.ClickbrokenLinlk();
        }
		 public void ConfirmAtBrokenLinksImagesPage()//
        {
			Assert.That(atPage.IsOnPage(BrokenLinksImagesPage.URL));
        }
	}
}

