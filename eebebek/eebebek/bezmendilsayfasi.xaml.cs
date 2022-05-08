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
    public partial class bezmendilsayfasi : ContentPage
    {
       

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=16,
                Brand = "Sleepy",
                Description ="Natural Yenidogan 1 Beden Bebek Bezi",
                ImageSource = "yenidoganbez",
                Price = 57.99
            },
            new Urun
            {
                Id=17,
                Brand = "Sleepy",
                Description ="Natural Midi 3 Beden Bebek Bezi",
                ImageSource = "ucbedenbez",
                Price = 57.99
            },
            new Urun
            {
                Id=18,
                Brand = "Sleepy",
                Description ="Natural Mini 2 Beden Bebek Bezi",
                ImageSource = "ikibedenbez",
                Price = 57.99
            },
            new Urun
            {
                Id=19,
                Brand = "Baby Me",
                Description ="Bebek Temizleme Pamuğu 60 adet",
                ImageSource = "temizlemepamugu",
                Price = 15.99
            }
        };
        public bezmendilsayfasi()
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