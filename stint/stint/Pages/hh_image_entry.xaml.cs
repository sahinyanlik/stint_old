using stint.Interfaces;
using stint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace stint.Pages
{
	public partial class hh_image_entry : ContentPage
	{
		public hh_image_entry ()
		{
			InitializeComponent ();

           BindingContext = new TakePictureViewModel(DependencyService.Get<ICameraProvider>());

		}
	}
}
