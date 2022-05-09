using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(Preferences.Get("MyFirebaseRefreshToken", "")))
            {
                MainPage = new NavigationPage(new Uyeolmaasamasi());
            }
            else
            {
                MainPage = new NavigationPage(new Page1());
            }

            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}