using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FashionApp.UserChoice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetPhysique : ContentPage
    {
        public SetPhysique()
        {
            InitializeComponent();
            List<string> millis = new List<string>
            {
                "a","b","c","d","e","f","g","h","i","j","l","m","n"
            };
            Ruler.ItemsSource = millis;
        }
        private void Ruler_ScrollToRequested_1(object sender, ScrollToRequestEventArgs e)
        {
            Ruler.ScrollTo(e.Index);
        }

        private async void Continue_Tapped(object sender, EventArgs e)
        {
            await Continue.ScaleTo(.95);
            Loading.IsVisible = true;
            await Continue.ScaleTo(1);
            Navigation.PushAsync(new SelectCategories());
            Loading.IsVisible = false;

        }
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Male_Tapped(object sender, EventArgs e)
        {

            Female.BackgroundColor = Color.FromHex("#1D212C");
            Female.Border.Color = Color.FromHex("#33394a");
            Trans.BackgroundColor = Color.FromHex("#1D212C");
            Trans.Border.Color = Color.FromHex("#33394a");
            await Male.ScaleTo(0.85);
            Male.BackgroundColor = Color.FromHex("#6d54f8");
            Male.Border.Color = Color.FromHex("#6d54f8");
            await Male.ScaleTo(1);
        }
        private async void Female_Tapped(object sender, EventArgs e)
        {

            Male.BackgroundColor = Color.FromHex("#1D212C");
            Male.Border.Color = Color.FromHex("#33394a");
            Trans.BackgroundColor = Color.FromHex("#1D212C");
            Trans.Border.Color = Color.FromHex("#33394a");
            await Female.ScaleTo(0.85);
            Female.BackgroundColor = Color.FromHex("#6d54f8");
            await Female.ScaleTo(1);
        }
        private async void Trans_Tapped(object sender, EventArgs e)
        {

            Male.BackgroundColor = Color.FromHex("#1D212C");
            Male.Border.Color = Color.FromHex("#33394a");
            Female.BackgroundColor = Color.FromHex("#1D212C");
            Female.Border.Color = Color.FromHex("#33394a");
            await Trans.ScaleTo(0.85);
            Trans.BackgroundColor = Color.FromHex("#6d54f8");
            await Trans.ScaleTo(1);

        }
        private async void Skinny_Tapped(object sender, EventArgs e)
        {

            Fatty.BackgroundColor = Color.FromHex("#1D212C");
            Fatty.Border.Color = Color.FromHex("#33394a");
            Average.BackgroundColor = Color.FromHex("#1D212C");
            Average.Border.Color = Color.FromHex("#33394a");
            await Skinny.ScaleTo(0.85);
            Skinny.BackgroundColor = Color.FromHex("#6d54f8");
            await Skinny.ScaleTo(1);

        }
        private async void Fatty_Tapped(object sender, EventArgs e)
        {

            Skinny.BackgroundColor = Color.FromHex("#1D212C");
            Skinny.Border.Color = Color.FromHex("#33394a");
            Average.BackgroundColor = Color.FromHex("#1D212C");
            Average.Border.Color = Color.FromHex("#33394a");
            await Fatty.ScaleTo(0.85);
            Fatty.BackgroundColor = Color.FromHex("#6d54f8");
            await Fatty.ScaleTo(1);

        }
        private async void Average_Tapped(object sender, EventArgs e)
        {

            Skinny.BackgroundColor = Color.FromHex("#1D212C");
            Skinny.Border.Color = Color.FromHex("#33394a");
            Fatty.BackgroundColor = Color.FromHex("#1D212C");
            Fatty.Border.Color = Color.FromHex("#33394a");
            await Average.ScaleTo(0.85);
            Average.BackgroundColor = Color.FromHex("#6d54f8");
            await Average.ScaleTo(1);

        }

        private async void Frame1_Tapped(object sender, EventArgs e)
        {
            CheckCircle2.IsVisible = false;
            CheckCircle3.IsVisible = false;
            CheckCircle4.IsVisible = false;

            await Frame1.ScaleTo(0.85);
            CheckCircle1.IsVisible = true;
            await CheckCircle1.ScaleTo(1);
        }
        private async void Frame2_Tapped(object sender, EventArgs e)
        {
            CheckCircle1.IsVisible = false;
            CheckCircle3.IsVisible = false;
            CheckCircle4.IsVisible = false;

            await Frame2.ScaleTo(0.85);
            CheckCircle2.IsVisible = true;
            await Frame2.ScaleTo(1);
        }
        private async void Frame3_Tapped(object sender, EventArgs e)
        {
            CheckCircle2.IsVisible = false;
            CheckCircle1.IsVisible = false;
            CheckCircle4.IsVisible = false;

            await Frame3.ScaleTo(0.85);
            CheckCircle3.IsVisible = true;
            await Frame3.ScaleTo(1);
        }
        private async void Frame4_Tapped(object sender, EventArgs e)
        {
            CheckCircle2.IsVisible = false;
            CheckCircle3.IsVisible = false;
            CheckCircle1.IsVisible = false;

            await Frame4.ScaleTo(0.85);
            CheckCircle4.IsVisible = true;
            await Frame4.ScaleTo(1);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }

        private void Ruler_ScrollToRequested(object sender, ScrollToRequestEventArgs e)
        {

        }

    }
}