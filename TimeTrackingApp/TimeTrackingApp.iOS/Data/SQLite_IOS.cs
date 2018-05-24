using SQLite;
using System;
using System.IO;
using TimeTrackingApp.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace TimeTrackingApp.iOS.Data
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLiteConnection GetConnection()
        {
            var fileName = "TimeTrackDB.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}