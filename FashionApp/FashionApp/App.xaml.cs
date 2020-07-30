using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Their.Authentication.ContactDetails());
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
