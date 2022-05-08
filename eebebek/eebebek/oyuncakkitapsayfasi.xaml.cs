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
    public partial class oyuncakkitapsayfasi : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=20,
                Brand = "Baby Toys",
                Description ="Eğitici Eğlenceli top 5 inch",
                ImageSource = "top",
                Price = 12.99
            },
            new Urun
            {
                Id=21,
                Brand = "Disney",
                Description ="Lisanslı Toplar 10 cm",
                ImageSource = "lisanslitop",
                Price = 19.99
            },
            new Urun
            {
                Id=22,
                Brand = "Pilsan",
                Description ="Dynamic Oyuncak Araba Asortili",
                ImageSource = "oyuncakaraba",
                Price = 34.99
            },
            new Urun
            {
                Id=23,
                Brand = "Bebek",
                Description ="Dergisi Nisan 2022",
                ImageSource = "dergi",
                Price = 9.99
            }
        };
        public oyuncakkitapsayfasi()
        {
            InitializeComponent();
            DynamicListView.ItemsSource = _stocks;
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

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