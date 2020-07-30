using FashionApp.Models;
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
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            List<Products> products = new List<Products>
            {
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
                new Products()
                {
                    ProductDescription = "lorem ipsum are vadicea siner"+"...",
                    ProductName = "SCOTCH & SODA",
                    ProductPic = "smallT.png",
                    ProductPrice = "₹1995",
                    ProductOriginalPrice = "₹3990",
                    ProductPriceOff = "(50% off)",
                },
            };
            ProductsView.ItemsSource = products;
        }
        private void Product_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Product.ProductDetailsPageAlt());
        }
    }
}