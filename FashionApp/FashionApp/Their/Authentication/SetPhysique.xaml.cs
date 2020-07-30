using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;

namespace FashionApp.Their.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetPhysique : ContentPage
    {
        public SetPhysique()
        {
            InitializeComponent();
        }
        private async void Male_Tapped(object sender, EventArgs e)
        {

            Female1.IsVisible = false;
            Trans1.IsVisible = false;
            await Male.ScaleTo(0.85);
            Male1.IsVisible = true;
            await Male.ScaleTo(1);
        }
        private async void Female_Tapped(object sender, EventArgs e)
        {

            Male1.IsVisible = false;
            Trans1.IsVisible = false;
            await Female.ScaleTo(0.85);
            Female1.IsVisible = true;
            await Female.ScaleTo(1);
        }
        private async void Trans_Tapped(object sender, EventArgs e)
        {

            Male1.IsVisible = false;
            Female1.IsVisible = false;
            await Trans.ScaleTo(0.85);
            Trans1.IsVisible = true; 
            await Trans.ScaleTo(1);

        }
        
        private async void Skinny_Tapped(object sender, EventArgs e)
        {

            Fatty.Border.Color = Color.FromHex("#f1f1f1");
            Average.Border.Color = Color.FromHex("#f1f1f1");
            await Skinny.ScaleTo(0.85);
            Skinny.Border.Color = Color.LightGray;
            await Skinny.ScaleTo(1);

        }
        private async void Fatty_Tapped(object sender, EventArgs e)
        {

            Skinny.Border.Color = Color.FromHex("#f1f1f1");
            Average.Border.Color = Color.FromHex("#f1f1f1");
            await Fatty.ScaleTo(0.85);
            Fatty.Border.Color = Color.LightGray;
            await Fatty.ScaleTo(1);

        }

        private async void Average_Tapped(object sender, EventArgs e)
        {

            Skinny.Border.Color = Color.FromHex("#f1f1f1");
            Fatty.Border.Color = Color.FromHex("#f1f1f1");
            await Average.ScaleTo(0.85);
            Average.Border.Color = Color.LightGray;
            await Average.ScaleTo(1);

        }
        private async void Next_Tapped(object sender, EventArgs e)
        {
            await Next.ScaleTo(.95);
            await Next.ScaleTo(1);
            Navigation.PushAsync(new SkinTone());
        }
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}