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
    public partial class altkategori2 : ContentPage
    {
        public altkategori2()
        {
            InitializeComponent();
        }
        
        async void banyobakimbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new banyobakimsayfasi());

        }
        async void bezmendilbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new bezmendilsayfasi());
        }
        async void oyuncakkitapbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new oyuncakkitapsayfasi());

        }
        async void aracgerecbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new aracgerecsayfasi());
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}