using SQLite;
using bikeHelper.Droid;
using System.IO;
using bikeHelper.Services;

[assembly: Xamarin.Forms.Dependency(typeof(DbConnection_Android))]
namespace bikeHelper.Droid
{
    public class DbConnection_Android : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "BikesDb.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}