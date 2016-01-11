using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Pages
{
	public partial class HiredHandMenu : ContentPage
	{
		public HiredHandMenu ()
		{
			InitializeComponent ();
		}

        async void OnGrabStintClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await this.Navigation.PushModalAsync(new ContractsPage());
        }

    }
}
