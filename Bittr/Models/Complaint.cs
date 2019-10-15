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
        private int downvotes = 0;
        public int Upvotes
        {
            get { return upvotes; }
            set { SetProperty(ref upvotes, value);
                OnPropertyChanged("NetVotes");
            }
        }
        public int Downvotes {
            get { return downvotes; }
            set { SetProperty(ref downvotes, value);
                OnPropertyChanged("NetVotes");
            }
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
            set { 
                SetProperty(ref hasDownvoted, value);
                
            }
        }

        public int NetVotes
        {
            get
            {
                return Upvotes - Downvotes;
            }
        }

        private bool isFavorite = false;
        public String imageSrc = "lemon3.jpg";
        public String ImageSrc {
            get
            {
                return imageSrc;
            }
            set
            {
                SetProperty(ref imageSrc, value);
            }
        
        }

        public bool IsFavorite
        {
            get { return isFavorite; }
            set { SetProperty(ref isFavorite, value); }
        }



        private List<Tag> tags;


        public List<Tag> Tags
        {
            get
            {
                return Tags;
            }

            set 
                { 
                SetProperty(ref tags, value);
        }
                
            }

        public Complaint()
        {
        }
    }

}
