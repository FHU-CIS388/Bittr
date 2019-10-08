using System;
using System.Collections.Generic;
using Bittr.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bittr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
            upvoteEvent();
        }
        

        void upvoteEvent()
        {
            btnUpvote.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    
                })
            });
        }
    }
}
