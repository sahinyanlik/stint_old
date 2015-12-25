
using stint.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace stint
{
    class RootPage : MasterDetailPage
    {
        MenuPage menuPage;
        public RootPage()
        {
            menuPage = new MenuPage();
            IsGestureEnabled = true;
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;

            Detail = new NavigationPage(new ContentPage());


        }

        public void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);


            if (Detail != null && Device.OS == TargetPlatform.WinPhone)
            {
                Detail.Navigation.PopToRootAsync();
            }

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
