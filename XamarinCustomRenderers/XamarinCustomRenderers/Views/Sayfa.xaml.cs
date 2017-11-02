using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCustomRenderers.CustomControls;
using XFShapeView;

namespace XamarinCustomRenderers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sayfa : ContentPage
    {
        public Sayfa()
        {
            InitializeComponent();
            //CustomEntry myEntry = new CustomEntry();

            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        myEntry
            //    }
            //};
            var box = new ShapeView
            {
                ShapeType = ShapeType.Oval,
                WidthRequest = 75,
                HeightRequest = 75,
                Color = Color.Red
            };
            Content = new StackLayout
            {
                Children =
                {
                    box
                }
            };
        }
    }
}