﻿using System;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace counter
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

        public void Button_clicked()
        {
            Console.Out.WriteLine("button clicked");
        }
    }
}

