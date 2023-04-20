using SQLite;

namespace DaVinci.Data
{
    public static class DatabaseHelper
    {
        private static SQLiteConnection connection;

        public static void Connect()
        {
            string connectionString = "Data Source=/Users/mehtabsingh/Projects/DaVinci/DaVinci/Library.sql;Version=3;";
            connection = new SQLiteConnection(connectionString);
            //connection.Open();
        }

        public static void Disconnect()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
        }

        // Add methods to perform database operations
    }
}
