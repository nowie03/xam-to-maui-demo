using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

