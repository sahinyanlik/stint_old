using stint.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace stint
{
    public class hh_tab_menu : TabbedPage
    {
        public hh_tab_menu()
        {
            var navigationPage_detail = new NavigationPage(new hh_detail_entry());
            var navitagionPage_description = new NavigationPage(new hh_description_entry());
            var navigationPage_image = new NavigationPage(new hh_image_entry());
            var navigationPage_pay = new NavigationPage(new hh_pay_entry());
            var navigationPage_preview = new NavigationPage(new hh_last_preview());
            // var navigationPage_full_preview = new NavigationPage(new hh_full_preview());
            
            navitagionPage_description.Icon = "description.png";
            navitagionPage_description.Title = "Description";
            
            navigationPage_detail.Icon = "detail.png";
            navigationPage_detail.Title = "Detail";

            navigationPage_image.Icon = "image.png";
            navigationPage_image.Title = "image";

            navigationPage_pay.Icon = "pay.png";
            navigationPage_pay.Title = "Pay";

            navigationPage_preview.Icon = "preview.png";
            navigationPage_preview.Title = "Preview";

            //navigationPage_full_preview.Icon = "full_preview.png";
            //navigationPage_full_preview.Title = "Fu"



            Children.Add(navitagionPage_description);
            Children.Add(navigationPage_detail);
            Children.Add(navigationPage_image);
            Children.Add(navitagionPage_description);
            Children.Add(navigationPage_pay);
            Children.Add(navigationPage_preview);
        }

    }
}
