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
    public partial class OrderSummary : ContentPage
    {
        public OrderSummary()
        {
            InitializeComponent();
        }
        private async void SelectPayment_Tapped(object sender, EventArgs e)
        {
            await SelectPayment.ScaleTo(0.85);
            await SelectPayment.ScaleTo(1);
            Navigation.PushAsync(new SelectPayment());
        }

        private void ChangeAddress_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}