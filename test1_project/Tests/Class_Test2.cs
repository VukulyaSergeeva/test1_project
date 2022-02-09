using System;
using NUnit.Framework;
using test1_project;
using MySql.Data;
using MySqlConnector;
using System.Collections.Generic;

namespace test1_project
{
	public class Class_Test2
	{
		FormPageSecond page;
        private List<string> valuesList;

		[SetUp]
		public void Setup()
		{

			var db = new DbClass();
			valuesList = db.GetValues("email");

			//TODO: Move DB logic to the separate class


		}



		[Test]
		public void SecondTest()
		{
			
				
			//page = new FormPageSecond("https://demoqa.com/text-box");
			//page.
		}

		[TearDown]
		public void TearDown()
        {
			page.Close();

        }
	}
}

