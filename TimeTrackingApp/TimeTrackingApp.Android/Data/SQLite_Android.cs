using System.IO;
using SQLite;
using TimeTrackingApp.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace TimeTrackingApp.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {

        }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Time_trackDB.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLiteConnection(path);

            return conn;
        }
    }
}