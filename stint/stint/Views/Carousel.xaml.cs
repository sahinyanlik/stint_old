using stint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Views
{
	public partial class Carousel : CarouselPage
	{
		public Carousel()
		{
			InitializeComponent ();

            // Console.Write(CurrentPage.StyleId);
            // we like to watch if it is working.

            

		}

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (CurrentPage.StyleId.Equals("third"))
            {
                App.IsFirstTime = "false";
                App.Current.Properties["IsFirstTime"] = "false";
                MainServices.GotoMainPage();
            }
            
        }
    }
}
