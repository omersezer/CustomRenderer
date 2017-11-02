using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinCustomRenderers.Droid.CustomRenderers;
using XamarinCustomRenderers.CustomControls;

[assembly : Xamarin.Forms.ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace XamarinCustomRenderers.Droid.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control!=null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.AntiqueWhite);
                Control.SetTextColor(Android.Graphics.Color.Black);
            }
        }
    }
}