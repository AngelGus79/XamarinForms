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
            //MainPage = new StackLayoutPage();
            //MainPage = new StackLayoutPage02();
            //MainPage = new GridLayoutPage();
            //MainPage = new GridLayoutPage02();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new AbsoluteLayoutPage02();
            MainPage = new RelativeLayoutPage();

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
