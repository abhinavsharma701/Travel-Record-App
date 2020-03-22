using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_Record_App.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_Record_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceField.Text
            };
            SQLiteConnection conn = new SQLiteConnection(App.databaseLocation);
            {
                conn.CreateTable<Post>();
                int Rows = conn.Insert(post);
                conn.Close();
                

                if (Rows > 0)
                {
                    DisplayAlert("Successfull!!", "Experience Successfull", "Ok");

                }
                else
                {
                    DisplayAlert("Failed", "Try Again!!", "ok");
                }
            }
        }

        
    }
}