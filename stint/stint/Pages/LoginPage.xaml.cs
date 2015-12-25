using Newtonsoft.Json;
using Plugin.Connectivity;
using stint.Interfaces;
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
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();

        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }


        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                UserName = usernameEntry.Text,
                UserPassword = passwordEntry.Text
            };
            if (CrossConnectivity.Current.IsConnected == true)
            {


                bool result = await UserService.loginUser(user);

                if (result == true)
                {
                    MainServices.GotoMainPage();
                    // HttpResponseModel content = await UserService.CredentialControl(user);

                    // Navigation.InsertPageBefore(new ContentPage(), this);
                    //  MessagingCenter.Send<ContentPage>(this, "Create");
                    //Page displayPage = (Page)Activator.CreateInstance(typeof(ContractsPage));
                    //NavigationPage page = new NavigationPage(new ContractsPage());
                    // var homeNav = new NavigationPage(RootPage.)

                    // await Navigation.PopAsync();

                    // await Navigation.PopAsync();
                    // ilm.ShowLoggedInRootPage();
                    // await this.Navigation.PushAsync(new ContractsPage());
                    //MenuListData data = new MenuListData();

                }
                else
                {
                    messageLabel.Text = "Login Failed";
                    passwordEntry.Text = string.Empty;
                }
            }
            else
            {
                AlertServices.Alert(Constants.noInternetConnection);
            }

        }


        bool AreCredintialsCorrect(User user)
        {
            UserService service = new UserService();
            //service.controlUser(user);

            return true;
            //return user.Username == Constants.Username && user.Password == Constants.Password;
        }

    }
}
