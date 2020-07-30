using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.UserChoice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectBrands : ContentPage
    {
        public SelectBrands()
        {
            InitializeComponent();
        }
        private async void Continue_Tapped(object sender, EventArgs e)
        {
            await Continue.ScaleTo(.95);
            Loading.IsVisible = true;
            await Continue.ScaleTo(1);
            Navigation.PushAsync(new Follow());
            Loading.IsVisible = false;

        }
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}