using Firebase.Auth;
using Newtonsoft.Json;
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
    public partial class Page5 : ContentPage
    {
        public string WebAPIkey = "AIzaSyC3wgLwj-HrCaP9CEFCDpeuh8S4tsmvxNA";
        public Page5()
        {
            InitializeComponent();
        }
        async void signupbutton_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(UserNewEmail.Text, UserNewPassword.Text);
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Merhaba", "Aramıza hoşgeldiniz", "Tamam");
            }
            catch (Exception ex)
            {

                await App.Current.MainPage.DisplayAlert("Uyarı", "Hatalı işlem", "Tamam");
            }

        }
    }
}