using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            //InitializeComponent();
            
            
        }

        public async void CreatePost(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PostPage());
        }

    }
}
