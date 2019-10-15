using System;
using System.Collections.Generic;
using Bittr.ViewModels;

namespace Bittr.Models
{
    public class Complaint: BaseViewModel
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

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

        private string downvoteImageName = "down.png";
        public string DownvoteImageName
        {
            get
            {
                return downvoteImageName;
            }
            set
            {
                SetProperty(ref downvoteImageName, value);
            }
        }
        private string favoriteImageName = "lemon.jpg";

        public string FavoriteImageName
        {
            get
            {
                return favoriteImageName;
            }
            set
            {
                SetProperty(ref favoriteImageName, value);
            }
        }

        private int downvotes = 0;
        public int Downvotes { 
            get { return downvotes; }
            set { SetProperty(ref downvotes, value); }
        
        }

        private bool hasUpvoted = false;
        public bool HasUpvoted
        {
            get { return hasUpvoted; }
            set { SetProperty(ref hasUpvoted, value); }
        }

        private bool hasDownvoted = false;
        public bool HasDownvoted { 
            get { return hasDownvoted; }
            set { SetProperty(ref hasDownvoted, value); }
        
        }

        private bool isFavorite = false;
        public bool IsFavorite { 
            get { return isFavorite; }
            set { SetProperty(ref isFavorite, value); }
        
        }

        public List<Tag> Tags { get; set; }

        public Complaint()
        {
        }
    }

}
