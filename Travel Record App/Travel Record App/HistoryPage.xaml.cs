using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Travel_Record_App.Model;

namespace Travel_Record_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();
    }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            SQLiteConnection conn = new SQLiteConnection(App.databaseLocation);
            {
                conn.CreateTable<Post>();
                var tableList = conn.Table<Post>().ToList();
                conn.Close();
                
                if(tableList.Count > 0)
                {
                    DisplayAlert("Something Found", "VeryGood", "ok");
                }
                else
                {
                    DisplayAlert("Nothing Found", "Koi Baat nhi", "ok");
                }
                postListView.ItemsSource = tableList;



            }
        }
    }
}