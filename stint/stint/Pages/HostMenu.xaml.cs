using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Pages
{
	public partial class HostMenu : ContentPage
	{
		public HostMenu ()
		{
			InitializeComponent ();
		}

        async void OnHandStintClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
            await this.Navigation.PushModalAsync(new ContractsPage());
        }

    }


}
