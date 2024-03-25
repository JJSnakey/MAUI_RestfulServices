using Assignment4Part3.Services;
using Assignment4Part3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment4Part3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
