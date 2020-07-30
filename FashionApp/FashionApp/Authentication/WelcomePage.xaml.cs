using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void Continue_Tapped(object sender, EventArgs e)
        {
            await Continue.ScaleTo(.95);
            Loading.IsVisible = true;
            await Continue.ScaleTo(1);
            Navigation.PushAsync(new SendOtpPage());
            Loading.IsVisible = false;

        }
        private async void Google_Tapped(object sender, EventArgs e)
        {

            await Google.ScaleTo(.95);
            GoogleLoading.IsVisible = true;
            GoogleText.IsVisible = false;
            await Google.ScaleTo(1);
            GoogleLoading.IsVisible = false;
            GoogleText.IsVisible = true;
        }
        private async void Insta_Tapped(object sender, EventArgs e)
        {

            await Insta.ScaleTo(.95);
            InstaLoading.IsVisible = true;
            InstaText.IsVisible = false;
            await Insta.ScaleTo(1);
            InstaLoading.IsVisible = false;
            InstaText.IsVisible = true;
        }
    }
}