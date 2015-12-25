using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace stint.Services
{
    public class AlertServices
    {
        public  static void Alert(String alert)
        {
            var page =  new Page().DisplayAlert("Alert",alert, "OK");
        }

    }
}
