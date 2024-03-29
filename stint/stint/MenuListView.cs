﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace stint
{
    public class MenuListView : ListView
    {

        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();
            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
            ItemTemplate = cell;
        }
        

    }
}
