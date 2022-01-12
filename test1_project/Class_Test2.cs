using System;
using NUnit.Framework;
using test1_project;
using MySql.Data;
using MySqlConnector;

namespace test1_project
{
	public class Class_Test2
	{
		FormPageSecond page;

		[SetUp]
		public void Setup()
		{
			//TODO: Connect to DB and get form data
		}

		[Test]
		public void SecondTest()
		{
			using (var conn = new MySqlConnection("Server=localhost;User ID=novyi_polzovatel;Password=123;Database=local_db"))
            {
				conn.Open();
				using(var command = new MySqlCommand("SELECT * FROM client_table", conn))
				using(var result = command.ExecuteReader())
                    while (result.Read())
                    {
						Console.WriteLine(result.GetString(3));
                    }

			}
				
			//page = new FormPageSecond("https://demoqa.com/text-box");
			//page.
		}
	}
}

