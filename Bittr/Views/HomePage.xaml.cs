using Bittr.ViewModels;
using Bittr.Models;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {
        public ICommand HashtagCommand { get; set; }

        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }

        void ComplaintTapped(object sender, System.EventArgs e)
        {
            Complaint complaint = (Complaint)(sender as Image).BindingContext;
            Navigation.PushAsync(new ComplaintPage(complaint));
        }

        void Upvote(object sender, System.EventArgs e)
        {
            var userId = 0; // quick hack, will grab from usersession later

            Label l = sender as Label;
            Complaint complaint = (Complaint)l.BindingContext;
            var sl = l.Parent as StackLayout;

            Interaction upvote = new Interaction
            {
                Type = InteractionType.UPVOTE,
                ComplaintId = complaint.Id,
                UserId = userId
            };

            Label upvotecountlabel = sl.FindByName("UpvoteCount") as Label;

            if (!complaint.Upvotes.Any(item => item.UserId == userId))
            {
                complaint.Upvotes.Add(upvote);
                upvotecountlabel.Text = complaint.Upvotes.Count.ToString();
            }
            else // un-upvote
            {
                complaint.Upvotes.RemoveAll(u => u.UserId == userId);
                upvotecountlabel.Text = complaint.Upvotes.Count.ToString();
            }

            Interaction hasDownvote = complaint.Downvotes.Find(item => item.UserId == userId);

            if (hasDownvote != null)
            {
                complaint.Downvotes.RemoveAll(u => u.UserId == userId);
                Label downvotecountlabel = sl.FindByName("DownvoteCount") as Label;
                downvotecountlabel.Text = complaint.Downvotes.Count.ToString();
            }
        }

        void Downvote(object sender, System.EventArgs e)
        {
            var userId = 0; // quick hack, will grab from usersession later

            Label l = sender as Label;
            Complaint complaint = (Complaint)l.BindingContext;
            var sl = l.Parent as StackLayout;

            Interaction downvote = new Interaction
            {
                Type = InteractionType.DOWNVOTE,
                ComplaintId = complaint.Id,
                UserId = userId
            };

            Label downvotecountlabel = sl.FindByName("DownvoteCount") as Label;

            if (!complaint.Downvotes.Any(item => item.UserId == userId))
            {
                complaint.Downvotes.Add(downvote);
                downvotecountlabel.Text = complaint.Downvotes.Count.ToString();
            }
            else // un-downvote
            {
                complaint.Downvotes.RemoveAll(u => u.UserId == userId);
                downvotecountlabel.Text = complaint.Downvotes.Count.ToString();
            }

            Interaction hasUpvote = complaint.Upvotes.Find(item => item.UserId == userId);

            if (complaint.Upvotes.Any(item => item.UserId == userId))
            {
                complaint.Upvotes.RemoveAll(u => u.UserId == userId);
                Label upvotecountlabel = sl.FindByName("UpvoteCount") as Label;
                upvotecountlabel.Text = complaint.Upvotes.Count.ToString();
            }
        }

        void Favorite(object sender, System.EventArgs e)
        {
            var userId = 0; // quick hack, will grab from usersession later

            Label l = sender as Label;
            Complaint complaint = (Complaint)l.BindingContext;
            var sl = l.Parent as StackLayout;

            Interaction favorite = new Interaction
            {
                Type = InteractionType.FAVORITE,
                ComplaintId = complaint.Id,
                UserId = userId
            };

            Label favoritecountlabel = sl.FindByName("FavoriteCount") as Label;

            if (!complaint.Favorites.Any(item => item.UserId == userId))
            {
                complaint.Favorites.Add(favorite);
                favoritecountlabel.Text = complaint.Favorites.Count.ToString();
            }
            else
            {
                complaint.Favorites.RemoveAll(u => u.UserId == userId);
                favoritecountlabel.Text = complaint.Favorites.Count.ToString();
            }
        }

        void ScrollToTop(object sender, System.EventArgs e)
        {
            var lvs = (ObservableCollection<Complaint>)ComplaintFeed.ItemsSource;
            ComplaintFeed.ScrollTo(lvs[0], ScrollToPosition.MakeVisible, false);
        }
    }
}
