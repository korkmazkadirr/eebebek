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
    public partial class yeniurunlersayfasixaml : ContentPage
    {

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Id=0,
                Brand = "Vardem",
                Description ="1:64 Kapıları Açılır Metal Araba",
                ImageSource = "metalaraba",
                Price = 19.99
            },
            new Urun
            {
                Id=1,
                Brand = "Chicco",
                Description ="Fold Go I-Size Oto Koltuğu-Mavi",
                ImageSource = "maviotokoltugu",
                Price = 3699
            },
            new Urun
            {
                Id=2,
                Brand = "Chicco",
                Description ="Fold Go I-Size Oto Koltuğu-Siyah",
                ImageSource = "siyahotokoltugu",
                Price = 3699
            },
            new Urun
            {
                Id=3,
                Brand = "Pasha",
                Description ="Bebek Salıncağı",
                ImageSource = "kapusonlupatiktulum",
                Price = 42.99
            }
        };
        public yeniurunlersayfasixaml()
        {
            InitializeComponent();
            DynamicListView.ItemsSource = _stocks;

        }

        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void sepetegecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SepetSayfasi());
        }  
        async void AddToCart(object sender, EventArgs e)
        {
            int stockId = (int) ((Button)sender).BindingContext ;
            var stock = _stocks.Where(x => x.Id == stockId).FirstOrDefault();
            Cart.AddToStocks(stock);
        }
    }
}