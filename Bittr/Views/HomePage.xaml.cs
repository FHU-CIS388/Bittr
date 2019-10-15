using Bittr.ViewModels;
using System;
using System.Collections.Generic;

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
        public async void OnUpvoteButtonClicked(object sender, EventArgs args)
        {
            Console.WriteLine("You upvoted this complaint.");
        }


       

    }
}
