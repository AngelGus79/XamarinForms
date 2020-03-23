﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new BindingSliderPage();
            //MainPage = new BindingContextPage();
            //MainPage = new XamlEssentialsPage();
            MainPage = new StackLayoutPage();
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
