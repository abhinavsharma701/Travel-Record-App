using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_Record_App
{
    public partial class App : Application
    {
        public static string databaseLocation = string.Empty;
       

        public App(string DatabaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;

            MainPage = new NavigationPage(new MainPage());

           
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
