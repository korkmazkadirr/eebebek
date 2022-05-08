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
        public SepetSayfasi(ObservableCollection<Urun> cartList)
        {
            InitializeComponent();
            DynamicListView.ItemsSource = cartList;
        }
    }
}