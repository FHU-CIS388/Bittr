using Bittr.ViewModels;
using Bittr.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {
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
            Label l = sender as Label;
            Complaint complaint = (Complaint)l.BindingContext;

            Interaction upvote = new Interaction
            {
                Type = InteractionType.UPVOTE,
                ComplaintId = complaint.Id,
                UserId = 0 // quick hack
            };
            complaint.Upvotes.Add(upvote);

            var sl = l.Parent as StackLayout;
            Label upvotecountlabel = sl.FindByName("UpvoteCount") as Label;
            upvotecountlabel.Text = complaint.Upvotes.Count.ToString();
        }

        void Downvote(object sender, System.EventArgs e)
        {
            Label l = sender as Label;
            Complaint complaint = (Complaint)l.BindingContext;

            Interaction upvote = new Interaction
            {
                Type = InteractionType.UPVOTE,
                ComplaintId = complaint.Id,
                UserId = 0 // quick hack
            };
            complaint.Upvotes.Add(upvote);

            var sl = l.Parent as StackLayout;
            Label upvotecountlabel = sl.FindByName("DownvoteCount") as Label;
            upvotecountlabel.Text = complaint.Upvotes.Count.ToString();
        }
    }
}
