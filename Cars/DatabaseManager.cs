using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
