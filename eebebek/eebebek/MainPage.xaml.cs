using eebebek.DtoObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eebebek
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Brand = "marka",
                Description ="cokucuz",
                ImageSource = "metalaraba",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="normal",
                ImageSource = "aracgerec",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="cokpahalı",
                ImageSource = "bebekodasi",
                Price = 19.99
            }
        };

        public MainPage()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){Title="Image 1", Url="carousel1"},
                new Image(){Title="Image 2", Url="carousel2"},
                new Image(){Title="Image 3", Url="carousel3"},
                new Image(){Title="Image 4", Url="carousel4"},
                new Image(){Title="Image 5", Url="carousel5"}
            };
            Carousel.ItemsSource = images;


        }
        async void uyegirisinegecis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        async void konumizni(object sender, EventArgs e)
        {
            await DisplayAlert("Uyarı", "Yakındaki mağazaları görüntülemek için konum izni vermeniz gerekmektedir.", "İptal");
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
        async void kategorilerbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kategoriler());

        }
        async void aramasayfasigecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new aramasayfasi());






        }
    }
}