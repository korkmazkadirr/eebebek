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
        async void yeniurunlerbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yeniurunlersayfasixaml());
        }
        async void giyimtekstilbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new giyimtekstilsayfasi());

        }
        async void bebekodasibutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new bebekodasisayfasi());

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
        async void beslenmebutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new beslenmesayfasi());
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