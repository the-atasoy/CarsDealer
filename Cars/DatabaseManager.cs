using System.IO;

namespace Cars
{
    public static class DatabaseManager
    {

        public static string GetConnectionString()
        {
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(directory, @"..\..\..\Cars\conn.txt");

            string connectionString = File.ReadAllText(filePath);

            return connectionString;
        }

    }
}
