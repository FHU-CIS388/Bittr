using Bittr.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bittr.ViewModels
{
    class Complaint: BaseViewModel
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ImageName { get; set; }

        public User Creator { get; set; }

        private int upvotes = 0;

        public int Upvotes
        {
            get { return upvotes; }
            set { SetProperty(ref upvotes, value); }
        }
        private string upvoteImageName = "up.png";
        public string UpvoteImageName
        {
            get
            {
                return upvoteImageName;
            }
            set
            {
                SetProperty(ref upvoteImageName, value);
            }
        }
        public int Downvotes { get; set; }

        private bool hasUpvoted = false;
        public bool HasUpvoted
        {
            get { return hasUpvoted; }
            set { SetProperty(ref hasUpvoted, value); }
        }
        public bool HasDownvoted { get; set; }

        public bool isFavorite { get; set; }

        //public List<Tag> Tags { get; set; }

        public Complaint()
        {

        }

    }
}
