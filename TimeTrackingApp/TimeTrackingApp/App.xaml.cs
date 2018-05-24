using System;
using TimeTrackingApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TimeTrackingApp
{
	public partial class App : Application
	{
        static EntryDatabaseController entryDatabase;
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static EntryDatabaseController EntryDatabase
        {
            get
            {
                if(entryDatabase == null)
                {
                    entryDatabase = new EntryDatabaseController();
                }
                return entryDatabase;
            }
        }
	}
}
