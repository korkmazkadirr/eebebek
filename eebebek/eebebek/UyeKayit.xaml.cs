using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyeKayit : ContentView
    {
        public UyeKayit()
        {
            InitializeComponent();
        }
        async void geridonbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}