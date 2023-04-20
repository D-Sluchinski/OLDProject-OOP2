using System;
using SQLite;
namespace DaVinci.Data
{
    //EDIT ONLY TO ATTEMPT CONNECTING IT WITH DATABASE
    namespace DaVinci.Data
    {
        public class DatabaseService
        {
            private SQLiteConnection _connection;

            public DatabaseService()
            {
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydatabase.db");
                _connection = new SQLiteConnection(dbPath);
            }


        }
    }



}


