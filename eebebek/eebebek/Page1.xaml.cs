using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    public partial class Page1 : ContentPage
    {
        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Uyarı", "Giriş Yapılamadı, Hatalı kullanıcı adı ya da şifre!", "ANLADIM");
        }

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save?", "Would you like to save your data?", "Yes", "No");
            Console.WriteLine("Save data: " + response);


        }
        async void Vazgecbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        public Page1()
        {
            InitializeComponent();
        }
    }
}






