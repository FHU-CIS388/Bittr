using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bittr.ViewModels;
using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {

        Models.User PrimaryUser = new Models.User() { Avatar = "reecenoel.png", Bio = "Hello there", Username = "imbatman", FullName = "Reece Noel" };

        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();

            //InitializeComponent();
            MessagingCenter.Subscribe<ProfilePage, Models.User>(this, "HereYouGo", (sender, args) =>
            {
                PrimaryUser = args;
            });

            
        }

        void UpVote(object sender, EventArgs e)
        {
            ImageButton i = sender as ImageButton;
            Complaint c = (Complaint)i.BindingContext;

            StackLayout s = i.Parent.Parent as StackLayout;

            c.UpVote();
            i.Source = c.UpvoteImageName;

            Label upcount = s.FindByName<Label>("UpVoteCount");
            upcount.Text = c.Upvotes.ToString();

            Label downcount = s.FindByName<Label>("DownVoteCount");
            downcount.Text = c.Downvotes.ToString();

            ImageButton d = s.FindByName<ImageButton>("DownVoteButton");
            d.Source = "lemondown.png";
            
        }

        void DownVote(object sender, EventArgs e)
        {
            ImageButton i = sender as ImageButton;
            Complaint c = (Complaint)i.BindingContext;

            StackLayout s = i.Parent.Parent as StackLayout;

            c.DownVote();
            i.Source = c.DownVoteImageName;

            Label downcount = s.FindByName<Label>("DownVoteCount");
            downcount.Text = c.Downvotes.ToString();

            Label upcount = s.FindByName<Label>("UpVoteCount");
            upcount.Text = c.Upvotes.ToString();

            ImageButton u = s.FindByName<ImageButton>("UpVoteButton");
            u.Source = "lemonup.png";
        }

        void Favorite(object sender, EventArgs e)
        {
            ImageButton i = sender as ImageButton;

            Complaint c = (Complaint)i.BindingContext;

            c.IsFavorite = !c.IsFavorite;

            if (c.IsFavorite) i.Source = "favoritefilled.png";
            else i.Source = "favorite.png";
        }

        public void PushPost(Complaint c)
        {
            HomeViewModel hvm = BindingContext as HomeViewModel;
            hvm.Complaints.Insert(0, c);
            
        }

        public async void CreatePost(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PostPage(this, PrimaryUser));
        }

        public async void Report(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReportPage());
        }

    }
}
