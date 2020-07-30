using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Widget;
using FashionApp.Droid.CustomRenderer;
using FashionApp.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

 [assembly: ExportRenderer(typeof(PlainEntry), typeof(PlainEntryRenderer))]
namespace FashionApp.Droid.CustomRenderer
{
    class PlainEntryRenderer : EntryRenderer
    {
        public PlainEntryRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}