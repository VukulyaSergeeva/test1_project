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
		List<string> addressList;

		[SetUp]
		public void Setup()
		{

			var db = new DbClass();
			addressList =  db.getAddress();
			//TODO: Move DB logic to the separate class

			var addresses = new List<string>();
			using (var conn = new MySqlConnection("Server=localhost;User ID=newuser;Password=123;Database=user_db"))
			{
				conn.Open();
				using (var command = new MySqlCommand("SELECT * FROM client_table", conn))
				using (var result = command.ExecuteReader())
					while (result.Read())
					{
						addresses.Add(result.GetString(3));
					}

			}
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

