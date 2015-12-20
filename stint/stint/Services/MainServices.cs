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
    }
}
