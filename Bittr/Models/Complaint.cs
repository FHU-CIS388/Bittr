﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Bittr.ViewModels
{
    public class Complaint : BaseViewModel
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string ImageName { get; set; }

        public Models.User Creator { get; set; }

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

        public bool IsFavorite { get; set; }

        public List<Models.Tag> Tags { get; set; }

        public Complaint()
        {
        }

        public static List<Models.Tag> ExtractTags(string s)
        {
            List<Models.Tag> list = new List<Models.Tag>();
            char[] splitter = { ' ', ',', ';', '.', '!', '?', '\\' };
            string[] r = s.Split(splitter);
            foreach(string i in r)
            {
                if (i.StartsWith("#")) list.Add(new Models.Tag() { Text = i.ToLower() });
            }
            return list;
        }

    }

}
