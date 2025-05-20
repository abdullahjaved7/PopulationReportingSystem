Console.WriteLine("List of countries by population coming soon...");

namespace PopulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            var conn = db.GetConnection();

            if (conn != null)
            {
                Console.WriteLine("🎉 Connection works! You're ready to query.");
                conn.Close(); // Always close the connection when done
            }
        }
    }
}
