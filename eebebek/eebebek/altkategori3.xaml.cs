using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class altkategori3 : ContentPage
    {
        public altkategori3()
        {
            InitializeComponent();
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void emzirmebutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new emzirmesayfasi());
        }
        async void guvenlikbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new guvenliksayfasi());

        }
        async void outletbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new outletsayfasi());
        }
    }
}