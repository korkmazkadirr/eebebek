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
    public partial class Kategoriler : ContentPage
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void altkategori1egecis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new altkategori1());
        }

        async void altkategori2yegecis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new altkategori2());
        }

        async void altkategori3egecis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new altkategori3());
        }
    }
}