using Assignment4_3.ViewModels;
using Assignment4_3.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Assignment4_3
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
