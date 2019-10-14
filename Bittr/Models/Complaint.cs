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

        private int upvotes = 0;

        //upvotes
        public int Upvotes
        {
            get { return upvotes; }
            set { SetProperty(ref upvotes, value); }
        }
        private bool hasUpvoted = false;
        public bool HasUpvoted
        {
            get { return hasUpvoted; }
            set { SetProperty(ref hasUpvoted, value); }
        }

        //downvotes
        private bool hasDownvoted = false;
        public bool HasDownvoted 
        {
            get { return hasDownvoted; }
            set { SetProperty(ref hasDownvoted, value); }
        }

        //favorites
        private bool isFavorite = false;
        public bool IsFavorite 
        {
            get { return isFavorite; }
            set { SetProperty(ref isFavorite, value); }
        }

        public List<Tag> Tags { get; set; }

        public Complaint()
        {
            Tags = new List<Tag>();
        }
    }

}
