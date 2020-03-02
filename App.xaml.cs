using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.Services;
using ExplorAppTeo.Views;

namespace ExplorAppTeo
{
    public partial class App : Application
    {
        static SQLDatabase database;

        public static SQLDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExploraAppSQLite.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            // Método para carga de datos de SQLite
            App.Database.LoadDatabaseAsync();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
