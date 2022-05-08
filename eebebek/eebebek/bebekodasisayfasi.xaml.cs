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
    public partial class bebekodasisayfasi : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=8,
                Brand = "Little Dreams",
                Description ="Limon Yastık",
                ImageSource = "limonyastik",
                Price = 29.99
            },
            new Urun
            {
                Id=9,
                Brand = "Little Dreams",
                Description ="Lavanta Battaniye",
                ImageSource = "lavantabattaniye",
                Price = 69.90
            },
            new Urun
            {
                Id=10,
                Brand = "Elifa Baby",
                Description ="70x140 Yaprak Çarşaf",
                ImageSource = "carsaf",
                Price = 19.90
            },
            new Urun
            {
                Id=11,
                Brand = "Little Dreams",
                Description ="Bebek Salıncağı",
                ImageSource = "sirkhayvanlaribattaniye",
                Price = 69.90
            }
        };
        public bebekodasisayfasi()
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