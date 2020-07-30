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
    public partial class EditAddress : ContentPage
    {
        public EditAddress(string name, string pin, string address, string landmark, string city, string state, string phone)
        {
            InitializeComponent();
            Name.Text = name;
            Pincode.Text = pin;
            Address.Text = address;
            Landmark.Text = landmark;
            City.Text = city;
            State.Text = state;
            PhoneNumber.Text = phone;

        }

        private void Save_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}