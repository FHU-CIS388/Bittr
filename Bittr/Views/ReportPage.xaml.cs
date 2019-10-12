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

        void CloseModal(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
