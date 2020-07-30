using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.ShoppingBag
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectAddress : ContentPage
    {
        public SelectAddress()
        {
            InitializeComponent();
        }

        private async void DeliverHere_Tapped(object sender, EventArgs e)
        {
            await DeliverHereText.ScaleTo(0.95);
            await DeliverHereText.ScaleTo(1);
            Navigation.PushAsync(new OrderSummary());
        }

        private void EditAddress_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditAddress("", "", "", "", "", "", ""));
        }
        private void AddAddress_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditAddress("", "", "", "", "", "", ""));
        }
    }
}