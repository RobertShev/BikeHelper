using bikeHelper.iOS;
using bikeHelper.Services;
using SQLite;
using System;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(DbConnection_iOS))]
namespace bikeHelper.iOS
{
    public class DbConnection_iOS: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "BikesDb.db3";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}