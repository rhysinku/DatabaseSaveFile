using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace DatabaseSaveFile
{
    public partial class App : Application
    {
        static SQLHelper database;

        public static SQLHelper Sqldb
        {
            get
            {
                if (database == null)
                {
                    database = new SQLHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"db2.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
