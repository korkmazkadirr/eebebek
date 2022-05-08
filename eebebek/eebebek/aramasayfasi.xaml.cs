using eebebek.DtoObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
                Brand = "Vardem",
                Description ="1:64 Kapıları Açılır Metal Araba",
                ImageSource = "metalaraba",
                Price = 19.99
            },
            new Urun
            {
                Brand = "Chicco",
                Description ="Fold Go I-Size Oto Koltuğu-Mavi",
                ImageSource = "maviotokoltugu",
                Price = 3699
            },
            new Urun
            {
                Brand = "Chicco",
                Description ="Fold Go I-Size Oto Koltuğu-Siyah",
                ImageSource = "siyahotokoltugu",
                Price = 3699
            },
            new Urun
            {
                Brand = "Pasha",
                Description ="Bebek Salıncağı",
                ImageSource = "bebeksalincagi",
                Price = 699
            },
            new Urun
            {
                Brand = "Bebbek",
                Description ="Kapüşonlu Patiksiz Tulum",
                ImageSource = "kapusonlupatiktulum",
                Price = 42.99
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

            if (string.IsNullOrEmpty(SearchEntry.Text))
            {
                DynamicListView.ItemsSource = _stocks;
            }
            else
            {
                var tempResultHolder = _stocks.Where(x => x.Description.Contains(SearchEntry.Text) || x.Brand.Contains(SearchEntry.Text)).ToList();
                DynamicListView.ItemsSource = new ObservableCollection<Urun>(tempResultHolder);
            }

        }


    }
}



