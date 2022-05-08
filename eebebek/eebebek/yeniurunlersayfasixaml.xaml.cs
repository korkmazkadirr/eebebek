﻿using eebebek.DtoObjects;
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
        public ObservableCollection<Urun> _cartList = new ObservableCollection<Urun>();

        public ObservableCollection<Urun> _stocks = new ObservableCollection<Urun>()
        {
            new Urun
            {
                Brand = "marka",
                Description ="acıklama1",
                ImageSource = "metalaraba",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="acıklama2",
                ImageSource = "aracgerec",
                Price = 19.99
            },
            new Urun
            {
                Brand = "marka",
                Description ="acıklama3",
                ImageSource = "bebekodasi",
                Price = 19.99
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
            await Navigation.PushAsync(new SepetSayfasi(_cartList));
        }  
        async void AddToCart(object sender, EventArgs e)
        {
            
            //_cartList.Add();
        }
    }
}