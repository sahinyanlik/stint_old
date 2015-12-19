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
        public MenuPage(){
            //Icon = "settings.png";
            Title = "menu";
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
                        Text = "MENU"
                    }

                };
                layout.Children.Add(menuLabel);
            




            layout.Children.Add(Menu);

            Content = layout;

        }

	}
}
