using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TimeTrackingApp
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
