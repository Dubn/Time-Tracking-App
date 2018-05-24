using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackingApp
{
    class Entry
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Comment { get; set; }
        [MaxLength(60)]
        public string TaskTitle { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan WorkedHours { get; set; }
    }
}
