using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2.Database
{
    internal class Connect
    {
        private static MySqlConnection connection;
        private static string server = "103.183.120.142";
        private static string database = "accounts";
        private static string uid = "root";
        private static string password = "Rinhdz1@@";
        
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }
    }
}
