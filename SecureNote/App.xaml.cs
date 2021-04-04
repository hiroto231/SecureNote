﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SecureNote.View;

namespace SecureNote
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
