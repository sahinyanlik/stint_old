using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Pages
{
	public partial class hh_description_entry : ContentPage
	{
		public hh_description_entry ()
		{

            Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);
            InitializeComponent ();
		}
	}
}
