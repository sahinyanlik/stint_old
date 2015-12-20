using Newtonsoft.Json;
using stint.Models;
using stint.Services;
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
        

        public App ()
		{
			InitializeComponent ();

            if (Properties.ContainsKey("User"))
            {
                LoginUser();
                 
            }

            MainPage = new RootPage();
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
