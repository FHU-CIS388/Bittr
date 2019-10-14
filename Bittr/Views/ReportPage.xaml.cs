using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bittr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        public async void OnSubmitButtonCLicked(object sender, EventArgs args)
        {
            //submit the report to whatever

            await Navigation.PopModalAsync(true);
        }

        public async void OnCLosedButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}