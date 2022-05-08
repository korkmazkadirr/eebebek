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
    public partial class aramasayfasi : ContentPage
    {
        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Brand = "marka",
                Description ="aciklama1",
                ImageSource = "metalaraba",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="fatihinoyuncagi",
                ImageSource = "aracgerec",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="kadirinoyuncagi",
                ImageSource = "bebekodasi",
                Price = 19.99
            }
        };


        public aramasayfasi()
        {

            InitializeComponent();
            DynamicListView.ItemsSource = _stocks;
        }


        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void SearchButton(object sender, EventArgs e)
        {
            var tempResultHolder = _stocks.Where(x => x.Description.Contains(SearchEntry.Text)).ToList();
            DynamicListView.ItemsSource = new ObservableCollection<Urun>(tempResultHolder);

        }


    }
}



