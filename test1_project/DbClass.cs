using System;
using NUnit.Framework;
using test1_project;
using MySql.Data;
using MySqlConnector;
using System.Collections.Generic;

namespace test1_project
{
	public class DbClass
	{

		List<string> valuesList;

		public  List<string> GetValues(string val)
        {
			//var addresses = new List<string>();
			using (var conn = new MySqlConnection("Server=localhost;User ID=newuser;Password=123;Database=user_db"))
			{
				conn.Open();
				using (var command = new MySqlCommand("SELECT * FROM client_table", conn))
				using (var result = command.ExecuteReader())
					while (result.Read())
					{
						result.GetString(val);
						switch (val)
						{
							case (""):
								valuesList.Add(val);
								break;
							case ("1"):
								valuesList.Add(val);
								break;
							case ("2"):
								valuesList.Add(val);
								break;
							case ("3"):
								valuesList.Add(val);
								break;
							case ("4"):
								valuesList.Add(val);
								break;
							default: throw new Exception("Error!");

						}

					}
				
				conn.Close();
			}
			return valuesList;
		}
    }
			

}				 
		
			
    