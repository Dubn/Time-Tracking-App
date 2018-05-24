using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace TimeTrackingApp.Data
{
    public class EntryDatabaseController
    {
        static object locker = new object();
        SQLiteConnection database;
        public EntryDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Entry>();
        }

        public Entry GetEntry()
        {
            lock (locker)
            {
                if (database.Table<Entry>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Entry>().First();
                }
            }
        }

        public int SaveEntry(Entry entry)
        {
            lock (locker)
            {
                if (entry.Id != 0)
                {
                    database.Update(entry);
                    return entry.Id;
                }
                else
                {
                    return database.Insert(entry);
                }
            }
        }

        public int DeleteEntry(int id)
        {
            lock(locker)
            {
                return database.Delete<Entry>(id);
            }
        }
    }
}
