﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class banyobakimsayfasi : ContentPage
    {
        public banyobakimsayfasi()
        {
            InitializeComponent();
        }
        async void anasayfayagecisbutonu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}