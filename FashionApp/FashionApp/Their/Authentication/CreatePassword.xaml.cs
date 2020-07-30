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
    public partial class CreatePassword : ContentPage
    {
        public CreatePassword()
        {
            InitializeComponent();
        }

        private async void Done_Tapped(object sender, EventArgs e)
        {
            await Done.ScaleTo(0.95);
            await Done.ScaleTo(1);
        }
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}