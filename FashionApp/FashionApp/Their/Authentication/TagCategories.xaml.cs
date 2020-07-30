using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Their.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TagCategories : ContentPage
    {
        public TagCategories()
        {
            InitializeComponent();
        }
        private async void Next_Tapped(object sender, EventArgs e)
        {
            //await Next.ScaleTo(.95);
            //await Next.ScaleTo(1);
            Navigation.PushAsync(new ChooseBrands());
        }
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}