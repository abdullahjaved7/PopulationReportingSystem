using MySql.Data.MySqlClient;
using System;

namespace PopulationApp
{
    public class Database
    {
        private string connectionString = "server=localhost;user=root;password=123456789;database=world;";

        public MySqlConnection? GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                Console.WriteLine("✅ Connected to MySQL Database!");
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Database connection failed: " + ex.Message);
                return null;
            }
        }
    }
}
