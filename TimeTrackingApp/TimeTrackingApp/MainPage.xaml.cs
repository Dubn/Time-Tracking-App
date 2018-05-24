using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace TimeTrackingApp
{
	public partial class MainPage : ContentPage
	{
        readonly SQLiteAsyncConnection database;
        private string databasePath;
        Entry entry = new Entry();

        public MainPage()
		{
			InitializeComponent();
    
        }

 
    }
}
