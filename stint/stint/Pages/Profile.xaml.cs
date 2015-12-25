using Newtonsoft.Json;
using Plugin.Connectivity;
using stint.Models;
using stint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Pages
{
    public partial class Profile : ContentPage
    {
        
        public Profile()
        {
            InitializeComponent();
            //User propertyUser = new User();
            User propertyUser = JsonConvert.DeserializeObject<User>((string)App.Current.Properties["User"]);
            username.Text = propertyUser.UserName;
           
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            
            if (CrossConnectivity.Current.IsConnected == true)
            {
                 App.Current.Properties["User"] = "";
            }
            else
            {
                AlertServices.Alert(Constants.noInternetConnection);
            }
             App.IsUserLoggedIn = false;
             MainServices.GotoMainPage();
        }
    }
}
