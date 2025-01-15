using System;
using MySql.Data.MySqlClient;

namespace App
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=transportcompany;";
			MySqlConnection databaseConnection = new MySqlConnection(connectionString);

			Console.WriteLine("Введите SQL-запрос:\n");
			var query = Console.ReadLine();

			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			
			MySqlDataReader reader;

			try
			{
				databaseConnection.Open();

				reader = commandDatabase.ExecuteReader();

				databaseConnection.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
