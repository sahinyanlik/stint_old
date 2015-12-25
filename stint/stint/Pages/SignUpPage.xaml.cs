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
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}


        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new User()
            {
                UserName = usernameEntry.Text,
                
            };

            // Sign up logic goes here
            if (CrossConnectivity.Current.IsConnected == true)
            {
                var signUpSucceeded = AreDetailsValid(user);
                if (signUpSucceeded)
                {
                    var rootPage = Navigation.NavigationStack.FirstOrDefault();
                    if (rootPage != null)
                    {
                        // Flow is now on email.
                        HttpResponseModel result = await UserService.createUserSendMail(user);
                        if ( result.succeeded)
                        {
                            AlertServices.Alert(Constants.userCreatingCheckYourMail);
                            MainServices.GotoMainPage();
                        }
                        else
                        {
                            AlertServices.Alert(Constants.cannotSave +" "+result.message);
                        }

                        // App.IsUserLoggedIn = true;
                        // Navigation.InsertPageBefore(new RootPage(), Navigation.NavigationStack.First());
                        // await Navigation.PopToRootAsync();
                    }
                }
                else {
                    AlertServices.Alert(Constants.userNameNotEmail);
                    //messageLabel.Text = "Sign up failed";
                }
            }
            else
            {
                AlertServices.Alert(Constants.noInternetConnection);
            }
        }


        bool AreDetailsValid(User user)
        {
            return (!string.IsNullOrWhiteSpace(user.UserName) && user.UserName.Contains("@"));
            
        }

    }
}
