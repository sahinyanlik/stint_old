using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace stint
{
	public class ContractsPage : ContentPage
	{
		public ContractsPage ()
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
            };

        }
	}
}
