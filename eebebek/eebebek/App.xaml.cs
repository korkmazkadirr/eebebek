﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eebebek
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            
                MainPage = new NavigationPage(new Page1());
        }
    }

        
    }


