using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bittr.Models;

namespace Bittr.Views
{
    public partial class ComplaintPage : ContentPage
    {
        public ComplaintPage(Complaint complaint)
        {
            InitializeComponent();

            Title = complaint.Title;

            ImageURL.Source = complaint.ImageURL;
            Timestamp.Text = complaint.Timestamp.ToString();
            Description.Text = complaint.Description;
            Upvotes.Text = "👍 " + complaint.Upvotes.Count;
            Downvotes.Text = "👎 " + complaint.Downvotes.Count;
        }
    }
}
