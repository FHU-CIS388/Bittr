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
        public int Downvotes { get; set; }

        private bool hasUpvoted = false;
        public bool HasUpvoted
        {
            get { return hasUpvoted; }
            set { SetProperty(ref hasUpvoted, value); }
        }

        private bool hasDownvoted;
        public bool HasDownvoted
        {
            get { return hasDownvoted; }
            set { SetProperty(ref hasDownvoted, value); }
        }
        private bool displayUpBtn;
        public bool DisplayUpBtn
        {
            get { return displayUpBtn; }
            set { SetProperty(ref displayUpBtn, value); }
        }
        private bool displayUpFilledBtn;
        public bool DisplayUpFilledBtn
        {
            get { return displayUpFilledBtn; }
            set { SetProperty(ref displayUpFilledBtn, value); }
        }
        private bool displayDownBtn;
        public bool DisplayDownBtn
        {
            get { return displayDownBtn; }
            set { SetProperty(ref displayDownBtn, value); }
        }
        private bool displayDownFilledBtn;
        public bool DisplayDownFilledBtn
        {
            get { return displayDownFilledBtn; }
            set { SetProperty(ref displayDownFilledBtn, value); }
        }
        private bool isFavorite;
        public bool IsFavorite
        {
            get { return isFavorite; }
            set { SetProperty(ref isFavorite, value); }
        }

        public List<Tag> Tags { get; set; }
        public List<Vote> Votes { get; set; }
        private int voteScore;
        public int VoteScore
        {
            get { return voteScore; }
            set { SetProperty(ref voteScore, value); }
            
        }

        public Complaint()
        {
            HasDownvoted = false;
            HasUpvoted = false;
            DisplayUpBtn = true;
            DisplayUpFilledBtn = false;
            DisplayDownBtn = true;
            displayDownFilledBtn = false;
        }        
    }

}
