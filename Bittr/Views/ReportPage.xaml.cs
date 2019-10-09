using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        public async void OnSubmitButtonClicked(object sender, EventArgs args)
        {
            // submit the report to whatever

            await Navigation.PopModalAsync(true);
        }

        public async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
