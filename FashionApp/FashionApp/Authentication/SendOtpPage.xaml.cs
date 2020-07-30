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
    public partial class SendOtpPage : ContentPage
    {
        public SendOtpPage()
        {
            InitializeComponent();
        }
        private async void SendOtp_Tapped(object sender, EventArgs e)
        {
            await SendOtp.ScaleTo(.95);
            Loading.IsVisible = true;
            await SendOtp.ScaleTo(1);
            Navigation.PushAsync(new VerifyOtpPage());
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

        private void OpenEye_Tapped(object sender, EventArgs e)
        {
            CloseEye.IsVisible = true;
            OpenEye.IsVisible = false;
        }
        private void CloseEye_Tapped(object sender, EventArgs e)
        {
            CloseEye.IsVisible = false;
            OpenEye.IsVisible = true;
        }

        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}