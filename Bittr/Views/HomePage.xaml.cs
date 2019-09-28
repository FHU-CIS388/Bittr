using System;
using System.Collections.Generic;
using Bittr.ViewModels;
using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}