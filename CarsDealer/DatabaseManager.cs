using System.IO;

namespace CarsDealer
{
    public static class DatabaseManager
    {

        public static string GetConnectionString()
        {
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(directory, @"..\..\..\Cars\conn.txt");

            string connectionString = "Server = .;Database = Cars; Integrated Security=True";

            return connectionString;
        }

    }
}
