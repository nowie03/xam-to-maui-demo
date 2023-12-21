using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace counter
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;

        public int Count 
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            label.RelRotateTo(360, 1000);
        }

        public void OnChangeTextClicked(System.Object sender , EventArgs e)
        {
            textChangable.Text = "changed text";
        }

        public void Increase(System.Object sender,EventArgs e)
        {
            Count++;

        }

        public void Decrease(System.Object sender, EventArgs e)
        {
            Count--;

        }


    }
}

