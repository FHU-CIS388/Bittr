﻿using Xamarin.Forms;
using Bittr.Models;

namespace Bittr.Views
{
    public partial class ComplaintPage : ContentPage
    {
        public ComplaintPage(Complaint complaint)
        {
            InitializeComponent();

            Title = complaint.Title;

            ImageName.Source = complaint.ImageName;
            Timestamp.Text = complaint.Timestamp.ToString();
            Description.Text = complaint.Text;
            Upvotes.Text = "👍 " + complaint.Upvotes.Count;
            Downvotes.Text = "👎 " + complaint.Downvotes.Count;
        }

        void Report(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ReportPage()));
        }
    }
}