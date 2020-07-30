using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Product
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPageAlt : ContentPage
    {
        public ProductDetailsPageAlt()
        {
            InitializeComponent();
        }

        private async void AddToBag_Tapped(object sender, EventArgs e)
        {
            await AddToBagText.ScaleTo(0.95);
            await AddToBagText.ScaleTo(1);
            Navigation.PushAsync(new ShoppingBag.ShopBagPage());
        }

        private async void TagToWishList_Tapped(object sender, EventArgs e)
        {
            await TagToWishList.ScaleTo(0.95);
            await TagToWishList.ScaleTo(1);
        }
    }
}