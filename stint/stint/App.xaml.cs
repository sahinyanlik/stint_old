using Newtonsoft.Json;
using Plugin.Connectivity;
using stint.Models;
using stint.Services;
using stint.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace stint
{
	public partial class App : Application
    {
        public static bool IsUserLoggedIn{get; set;}
        public static User User { get; set; }
        public static string IsFirstTime { get; set; }

        public App ()
		{
			InitializeComponent ();
            IsFirstTime = "true";

            if (Properties.ContainsKey("IsFirstTime"))
            {
                IsFirstTime = "false";
            }

            if (Properties.ContainsKey("User"))
            {
                if ( CrossConnectivity.Current.IsConnected == true)
                {
                    if(IsFirstTime == "false")
                    {
                        LoginUser();
                    }
                }
                else
                {
                    AlertServices.Alert(Constants.noInternetConnection);
                }

                
            }


            if(IsFirstTime.Equals("false"))
            {
                MainPage = new RootPage();
            }
            else {
                MainPage = new Carousel();
            }



            /*MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };*/


        }

        public void ShowLoggedInRootPage()
        {
            MainPage = new RootPage();
        }
        private async void LoginUser()
        {
            User propertyUser = JsonConvert.DeserializeObject<User>((string)Properties["User"]);
            bool loginUser = await UserService.loginUser(propertyUser);
            if (loginUser == true)
            {
                MainServices.GotoMainPage();
            }
            return ;
        }

    }
}
