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

        void Update(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string name = b.Parent.FindByName<Entry>("username").Text;
            string bio = b.Parent.FindByName<Entry>("userbio").Text;

            ProfileViewModel pvm = BindingContext as ProfileViewModel;
            pvm.PrimaryUser.FullName = name;
            pvm.PrimaryUser.Bio = bio;

            MessagingCenter.Send<ProfilePage, Bittr.Models.User>(this, "HereYouGo", pvm.PrimaryUser);
        }
    }
}
