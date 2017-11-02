using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCustomRenderers.Views;

namespace XamarinCustomRenderers
{
    public class App : Application
    {
        public App()
        {
            MainPage = new Sayfa();
        }
    }
}
