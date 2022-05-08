using eebebek.Common;
using eebebek.DtoObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class giyimtekstilsayfasi : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=4,
                Brand = "baby mom",
                Description ="Çevreci Çanta XL",
                ImageSource = "cevrecicanta",
                Price = 9.99
            },
            new Urun
            {
                Id=5,
                Brand = "HelloBaby",
                Description ="Bebek Atlet Body",
                ImageSource = "bebekatlet",
                Price = 17.99
            },
            new Urun
            {
                Id=6,
                Brand = "HelloBaby",
                Description ="Bebek Kısa Kol Body",
                ImageSource = "bebekkisakol",
                Price = 17.99
            },
            new Urun
            {
                Id=7,
                Brand = "HelloBaby",
                Description ="Bebek Atlet Body",
                ImageSource = "bebekatlet",
                Price = 17.99
            }
        };

        public giyimtekstilsayfasi()
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