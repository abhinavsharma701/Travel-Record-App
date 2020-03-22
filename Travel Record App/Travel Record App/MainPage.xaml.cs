using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Travel_Record_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isUserNameEmpty = string.IsNullOrEmpty(usernameText.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordText.Text);

            if(isUserNameEmpty == true || isPasswordEmpty == true)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
            
        }
    }
}
