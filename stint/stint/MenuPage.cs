using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace stint
{

    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }
        public MenuPage()
        {
            if (Device.OS == TargetPlatform.Android)
            {
                // move layout under the status bar
                Icon = "menuIcon.png";
            }
            else
            {
                Icon = "/Images/menuIcon.png";
            }
            // 
            Icon = "menuIcon";
            string title = "MENU";
            Title = title;
            if (App.IsUserLoggedIn != true) { title = "Menu"; } else { title = "Menu - " + App.User.UserName; };
            BackgroundColor = Color.FromHex("3333333");
            Menu = new MenuListView();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
            var menuLabel = new ContentView
            {

                Padding = new Thickness(10, 36, 0, 5),
                Content = new Xamarin.Forms.Label
                {
                    TextColor = Color.FromHex("AAAAAA"),
                    Text = title
                }

            };
            layout.Children.Add(menuLabel);
            
            layout.Children.Add(Menu);

            Content = layout;

        }

    }
}
