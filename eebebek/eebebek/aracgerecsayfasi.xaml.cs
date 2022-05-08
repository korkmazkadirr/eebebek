using eebebek.DtoObjects;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eebebek.Common;

namespace eebebek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aracgerecsayfasi : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=24,
                Brand = "Very Important Baby",
                Description ="Vib Time Mama Sandalyesi",
                ImageSource = "mamasandalyesi",
                Price = 169.99
            },
            new Urun
            {
                Id=25,
                Brand = "Very Important Baby",
                Description ="Vib 360 Derece Dönebilen Puset Kancası",
                ImageSource = "pusetkancasi",
                Price = 36.99
            },
            new Urun
            {
                Id=26,
                Brand = "Baby Plus",
                Description ="Star Mama Sandalyesi",
                ImageSource = "starmamasandalyesi",
                Price = 179.99
            },
            new Urun
            {
                Id=27,
                Brand = "Babyjem",
                Description ="Lüks Bebek Arabası Yağmurluğu",
                ImageSource = "luksbebekarabasi",
                Price = 109.99
            }
        };
        public aracgerecsayfasi()
        {
            InitializeComponent();
            DynamicListView.ItemsSource = _stocks;
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void AddToCart(object sender, EventArgs e)
        {
            int stockId = (int)((Button)sender).BindingContext;
            var stock = _stocks.Where(x => x.Id == stockId).FirstOrDefault();
            Cart.AddToStocks(stock);
        }
        async void sepetegecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SepetSayfasi());
        }
    }
}