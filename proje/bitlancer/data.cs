using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace bitlancer{	
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
				connection = new MySqlConnection("server=localhost;user=root;pwd=;database=bitlancer;charset=utf8;pooling=false");
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
		public int loginCheck(string userName, string password)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select user_name, user_password from users", connection);
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
			return state ? getId("select id from users where user_name='" + userName + "'") : 0;

		}
		public DataTable getItems()
		{
			DataTable dt = new DataTable();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select (row_number() over (order by i.id))as 'No:', i.item_name,concat(min(f.unit_price),' ₺') as 'Fiyat' from items i, item_user_infos f where  i.id=f.item_id and i.id!=4 GROUP by f.item_id", connection);
				dt.Load(command.ExecuteReader());
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
			return dt;

		}

		public User getUser(int id)
		{
			User asd = new User(3, "Sezer Yıldırım", "sezer_admin", "Çanakkale", "asd@gmail.com", bitlancer.userTypes.admin);
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				//command = new MySqlCommand(sql, connection);
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
			return asd;
		}
	}
}
