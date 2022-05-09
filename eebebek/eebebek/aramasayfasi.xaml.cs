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
            },

            new Urun
            {
                
                Brand = "baby mom",
                Description ="Çevreci Çanta XL",
                ImageSource = "cevrecicanta",
                Price = 9.99
            },
            new Urun
            {
                
                Brand = "HelloBaby",
                Description ="Bebek Atlet Body",
                ImageSource = "bebekatlet",
                Price = 17.99
            },
            new Urun
            {
                
                Brand = "HelloBaby",
                Description ="Bebek Kısa Kol Body",
                ImageSource = "bebekkisakol",
                Price = 17.99
            },
            new Urun
            {
                
                Brand = "HelloBaby",
                Description ="Bebek Atlet Body",
                ImageSource = "bebekatlet",
                Price = 17.99
            },
            new Urun
            {
                
                Brand = "Little Dreams",
                Description ="Limon Yastık",
                ImageSource = "limonyastik",
                Price = 29.99
            },
            new Urun
            {
               
                Brand = "Little Dreams",
                Description ="Lavanta Battaniye",
                ImageSource = "lavantabattaniye",
                Price = 69.90
            },
            new Urun
            {
                
                Brand = "Elifa Baby",
                Description ="70x140 Yaprak Çarşaf",
                ImageSource = "carsaf",
                Price = 19.90
            },
            new Urun
            {
                
                Brand = "Little Dreams",
                Description ="Bebek Salıncağı",
                ImageSource = "sirkhayvanlaribattaniye",
                Price = 69.90
            },
            new Urun
            {
                Brand = "Babyjem",
                Description ="Bebek Kulak Çubuğu 60 adet",
                ImageSource = "kulakcopu",
                Price = 12.99
            },
            new Urun
            {
                Brand = "Uni Baby",
                Description ="Şampuan 700 ml",
                ImageSource = "sampuan",
                Price = 27.99
            },
            new Urun
            {
                Brand = "Baby Plus",
                Description ="Bebek Burun Aspiratörü 10 adet",
                ImageSource = "aspirator",
                Price = 19.99
            },
            new Urun
            {
                Brand = "Baby Me",
                Description ="Bebek Pudra Kokusu 50 ml",
                ImageSource = "pudrakokusu",
                Price = 32.99
            },
            new Urun
            {
                Brand = "Babyjem",
                Description ="Bebek Kulak Çubuğu 60 adet",
                ImageSource = "kulakcopu",
                Price = 12.99
            },
            new Urun
            {
                Brand = "Uni Baby",
                Description ="Şampuan 700 ml",
                ImageSource = "maviotokoltugu",
                Price = 27.99
            },
            new Urun
            {
                Brand = "Baby Plus",
                Description ="Bebek Burun Aspiratörü 10 adet",
                ImageSource = "aspirator",
                Price = 19.99
            },
            new Urun
            {
                Brand = "Baby Me",
                Description ="Bebek Pudra Kokusu 50 ml",
                ImageSource = "pudrakokusu",
                Price = 32.99
            },
            new Urun
            {
                Brand = "Sleepy",
                Description ="Natural Yenidogan 1 Beden Bebek Bezi",
                ImageSource = "yenidoganbez",
                Price = 57.99
            },
            new Urun
            {
                Brand = "Sleepy",
                Description ="Natural Midi 3 Beden Bebek Bezi",
                ImageSource = "ucbedenbez",
                Price = 57.99
            },
            new Urun
            {
                Brand = "Sleepy",
                Description ="Natural Mini 2 Beden Bebek Bezi",
                ImageSource = "ikibedenbez",
                Price = 57.99
            },
            new Urun
            {
                Brand = "Baby Me",
                Description ="Bebek Temizleme Pamuğu 60 adet",
                ImageSource = "temizlemepamugu",
                Price = 15.99
            },
            new Urun
            {
                Brand = "Baby Toys",
                Description ="Eğitici Eğlenceli top 5 inch",
                ImageSource = "top",
                Price = 12.99
            },
            new Urun
            {
                Brand = "Disney",
                Description ="Lisanslı Toplar 10 cm",
                ImageSource = "lisanslitop",
                Price = 19.99
            },
            new Urun
            {
                Brand = "Pilsan",
                Description ="Dynamic Oyuncak Araba Asortili",
                ImageSource = "oyuncakaraba",
                Price = 34.99
            },
            new Urun
            {
                Brand = "Bebek",
                Description ="Dergisi Nisan 2022",
                ImageSource = "dergi",
                Price = 9.99
            },
            new Urun
            {
                Brand = "Very Important Baby",
                Description ="Vib Time Mama Sandalyesi",
                ImageSource = "mamasandalyesi",
                Price = 169.99
            },
            new Urun
            {
                Brand = "Very Important Baby",
                Description ="Vib 360 Derece Dönebilen Puset Kancası",
                ImageSource = "pusetkancasi",
                Price = 36.99
            },
            new Urun
            {
                Brand = "Baby Plus",
                Description ="Star Mama Sandalyesi",
                ImageSource = "starmamasandalyesi",
                Price = 179.99
            },
            new Urun
            {
                Brand = "Babyjem",
                Description ="Lüks Bebek Arabası Yağmurluğu",
                ImageSource = "luksbebekarabasi",
                Price = 109.99
            },
            


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



