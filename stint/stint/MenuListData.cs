﻿using stint.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace stint
{
    class MenuListData : List<MenuItem>
    {
        public static List<MenuItem> menuItems { get; set; }
        public MenuListData()
        {
            menuItems = new List<MenuItem>();
            if (App.IsUserLoggedIn)
            {
               
                menuItems.Add(new MenuItem()
                {
                    Title = "Contracts",
                    IconSource = "Images/appbar.debug.step.out.png",
                    TargetType = typeof(ContractsPage)
                });

                menuItems.Add(new MenuItem()
                {
                    Title = "Finance",
                    IconSource = "/Images/menuIcon.png",
                    TargetType = typeof(Finance)
                });

                menuItems.Add(new MenuItem()
                {
                    Title = "Logout",
                    IconSource = "Images/logout.png",
                    TargetType = typeof(Profile)
                });

            }
            else
            {
                menuItems.Add(new MenuItem()
                {
                    Title = "Login",
                    IconSource = "/Images/menuIcon.png",
                    TargetType = typeof(LoginPage)
                });

                menuItems.Add(new MenuItem()
                {
                    Title = "Signup",
                    IconSource = "/Images/signup.png",
                    TargetType = typeof(SignUpPage)
                });
            }

            AddMenuItems(menuItems);



            /* 
            this.Add(new MenuItem()
            {
                Title = "Leads",
                IconSource = "Lead.png",
                TargetType = typeof(LoginPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Accounts",
                IconSource = "Accounts.png",
                TargetType = typeof(AccountsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Opportunities",
                IconSource = "Opportunity.png",
                TargetType = typeof(OpportunitiesPage)
            });
            */
        }
        public void AddMenuItems(List<MenuItem> menuItems)
        {
            foreach (var item in menuItems)
            {
                this.Add(new MenuItem()
                {
                    Title = item.Title,
                    IconSource = item.IconSource,
                    TargetType = item.TargetType
                });
            }
            
        }

    }
}
