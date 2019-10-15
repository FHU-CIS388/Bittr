using System;
using System.Collections.Generic;
using Bittr.ViewModels;
using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }
    }
}
