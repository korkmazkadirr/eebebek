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
    public partial class banyobakimsayfasi : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=12,
                Brand = "Babyjem",
                Description ="Bebek Kulak Çubuğu 60 adet",
                ImageSource = "kulakcopu",
                Price = 12.99
            },
            new Urun
            {
                Id=13,
                Brand = "Uni Baby",
                Description ="Şampuan 700 ml",
                ImageSource = "maviotokoltugu",
                Price = 27.99
            },
            new Urun
            {
                Id=14,
                Brand = "Baby Plus",
                Description ="Bebek Burun Aspiratörü 10 adet",
                ImageSource = "aspirator",
                Price = 19.99
            },
            new Urun
            {
                Id=15,
                Brand = "Baby Me",
                Description ="Bebek Pudra Kokusu 50 ml",
                ImageSource = "pudrakokusu",
                Price = 32.99
            }
        };
        public banyobakimsayfasi()
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