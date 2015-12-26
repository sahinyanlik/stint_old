using stint.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace stint
{
    public class ContractsPage : ContentPage
    {
        public ContractsPage()
        {
           


            var hiredHand = new Image { Source = new Uri("http://dummyimage.com/600x400/ff7300/ffffff.png&text=Hired+Hand") }; 
            
            hiredHand.GestureRecognizers.Add(new TapGestureRecognizer(sender => {
                MainServices.GotoHiredHandMenu();
                
            }));

            var host = new Image { Source = new Uri("http://dummyimage.com/600x400/ff0000/ffffff.png&text=Host") }; // make your image your button should be
            host.GestureRecognizers.Add(new TapGestureRecognizer(sender => {
                MainServices.GotoHostMenu();

            }));

            Content = new StackLayout
            {
                Children =
                {
                    hiredHand,host
                }

            };

        }

        protected override bool OnBackButtonPressed()
        {
            // TODO: Sayfalama yapilacak tum sayfalar alinip, true olan bolumde IsOkToGoBack() gibi bir kontrolle bir onceki sayfaya bakilacak ve ona gore 
            // davranilacak.
            // http://stackoverflow.com/questions/28767357/prevent-closing-by-back-button-in-xamarin-forms-on-android

            if (true)
            {
                return base.OnBackButtonPressed();
            }
            else
            {
                // Take appropriate action here (i.e. close or dismiss UI elements)

                // Indicate that you handled the event, otherwise the HW back behavior will occur
                return true;
            }
        }

    }
}
