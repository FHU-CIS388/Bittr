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

        public async void OnUpvoteButtonClicked(object sender, EventArgs args)
        {
            Console.WriteLine("You upvoted this complaint.");
        }


        public async void OnReportButtonClicked(object sender, EventArgs args)
        {
            var reportPage = new ReportPage();

            await Navigation.PushModalAsync( new NavigationPage( reportPage) );
        }
    }
}
