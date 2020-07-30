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
    public partial class SelectPayment : ContentPage
    {
        public SelectPayment()
        {
            InitializeComponent();
        }
        private async void PlaceOrder_Tapped(object sender, EventArgs e)
        {
            await PlaceOrder.ScaleTo(0.85);
            await PlaceOrder.ScaleTo(1);
            Navigation.PushAsync(new Home.HomePage());
        }
    }
}