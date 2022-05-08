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
    public partial class SepetSayfasi : ContentPage
    {
        List<Urun> stockCopy;
        public SepetSayfasi()
        {
            InitializeComponent();
            stockCopy = Cart.Stocks;
            DynamicListView.ItemsSource = new ObservableCollection<Urun>(Cart.Stocks);
        }

        async void RemoveFromCart(object sender, EventArgs e)
        {
            int stockId = (int)((Button)sender).BindingContext;
            var stock = stockCopy.Where(x => x.Id == stockId).FirstOrDefault();
            Cart.RemoveFromStocks(stockId);
            DynamicListView.ItemsSource = Cart.Stocks;
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}