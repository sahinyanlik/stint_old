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

        public App ()
		{
			InitializeComponent ();
            
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

	}
}
