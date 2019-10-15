using System;
using System.Collections.Generic;
using Bittr.ViewModels;

namespace Bittr.Models
{
    public class Complaint : BaseViewModel
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string ImageName { get; set; }

        public User Creator { get; set; }

        private int votes = 0;
        public int Votes
        {
            get { return votes; }
            set { SetProperty(ref votes, value); }
        }

        private bool hasUpvoted = false;
        public bool HasUpvoted
        {
            get { return hasUpvoted; }
            set { SetProperty(ref hasUpvoted, value); }
        }
        private bool hasDownvoted = false;
        public bool HasDownvoted
        {
            get { return hasDownvoted; }
            set { SetProperty(ref hasDownvoted, value); }
        }

        private bool hasFavorited = false;
        public bool HasFavorited
        {
            get { return hasFavorited; }
            set { SetProperty(ref hasFavorited, value); }
        }

        public bool IsFavorite { get; set; }

        public List<Tag> Tags { get; set; }

        public Complaint()
        {
            Tags = new List<Tag>();
        }
    }

}