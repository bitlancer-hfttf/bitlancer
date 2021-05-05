using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

public sealed class SingletonDB
{
	private static SingletonDB instance = null;

	public static SingletonDB GetInstance
	{
		get
		{
			if (instance == null)
				instance = new SingletonDB();
			return instance;
		}
	}

	private SingletonDB()
	{
	}
	public MySqlConnection getConnection()
	{
		MySqlConnection connection = null;
		try
		{
			connection = new MySqlConnection("server=localhost;user=root;pwd=;database=bitlancer;charset=utf8");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		return connection;
	}
	public int getId(string sql)
	{
		int id = 0;
		MySqlConnection connection = null;
		MySqlCommand command = null;
		try
		{
			connection = getConnection();
			connection.Open();
			command = new MySqlCommand(sql, connection);
			id = Convert.ToInt32(command.ExecuteScalar());
			command.ExecuteNonQuery();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			if (connection != null)
			{
				try
				{//bağlantıları kapat
					connection.Close();
					command.Dispose();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
		return id;
	}
	public int loginCheck(string userName, string password, string table)
	{
		bool state = false;
		MySqlConnection connection = null;
		MySqlCommand command = null;
		try
		{
			connection = getConnection();
			connection.Open();
			command = new MySqlCommand("select user_name, user_password from " + table, connection);
			command.Connection = connection;
			MySqlDataReader read = command.ExecuteReader();
			while (read.Read())
			{
				if (read[0].ToString() == userName && read[1].ToString() == password)
				{
					state = true;
					break;

				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("hata: " + e.Message);
		}
		finally
		{
			if (connection != null)
			{
				try
				{
					connection.Close();
					command.Dispose();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
		return state ? getId("select id from " + table + " " + (!table.Contains("where") ? " where " : " and ") + "user_name='" + userName + "'") : 0;
		
	}
}
