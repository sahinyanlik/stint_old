using stint.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace stint.Services
{
    public class MainServices
    {
        
        public static void GotoMainPage()
        {
            RootPage mv = new RootPage();
            mv.Detail = new NavigationPage(new ContractsPage());
            App.Current.MainPage = mv;
        }

        public static void GotoHiredHandMenu()
        {
            if (App.IsUserLoggedIn)
            {
                RootPage mv = new RootPage();
                mv.Detail = new NavigationPage(new HiredHandMenu());
                App.Current.MainPage = mv;
            }
            else
            {
                AlertServices.Alert(Constants.pleaseLoginFirst);
            }
        }

        public static void GotoHostMenu()
        {
            if (App.IsUserLoggedIn)
            {
                RootPage mv = new RootPage();
                mv.Detail = new NavigationPage(new HostMenu());
                App.Current.MainPage = mv;
            }
            else
            {
                AlertServices.Alert(Constants.pleaseLoginFirst);
            }
        }
    }
}
