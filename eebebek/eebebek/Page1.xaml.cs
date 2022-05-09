using Firebase.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace eebebek
{
    public partial class Page1 : ContentPage
    {
        public string WebAPIkey = "AIzaSyC3wgLwj-HrCaP9CEFCDpeuh8S4tsmvxNA";
        public Page1()
        {
            InitializeComponent();
        }
        

        async void loginbutton_Clicked(object sender, EventArgs e)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(UserLoginEmail.Text, UserLoginPassword.Text);
                var content = await auth.GetFreshAuthAsync();
                var serializedcontnet = JsonConvert.SerializeObject(content);
                Preferences.Set("MyFirebaseRefreshToken", serializedcontnet);
                await Navigation.PushAsync(new Uyeolmaasamasi());
            }
            catch (Exception ex)
            {

                await App.Current.MainPage.DisplayAlert("Uyarı", "Hatalı E-posta ya da şifre", "Tamam");
            }
        }

        async private void uyeolsayfasinagecis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}







