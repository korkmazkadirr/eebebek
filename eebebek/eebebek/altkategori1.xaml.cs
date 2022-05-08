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
    public partial class altkategori1 : ContentPage
    {
        public altkategori1()
        {
            InitializeComponent();
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void yeniurunlerbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yeniurunlersayfasixaml());
        }
        async void giyimtekstilbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new giyimtekstilsayfasi());
        }

        async void beslenmebutonu(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new beslenmesayfasi());
        }
       
          
         
         async void bebekodasibutonu(object sender, EventArgs e)
          {
              await Navigation.PushAsync(new bebekodasisayfasi());

          }
            
        }
    }

