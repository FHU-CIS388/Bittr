using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Bittr.ViewModels
{
    public class Complaint : BaseViewModel
    {
        public string Id { get; set; }

        public string Text { get; set; }
        public FormattedString FancyText { get; set; }

        public DateTime Timestamp { get; set; }

        public string ImageName { get; set; }

        public Models.User Creator { get; set; }
        public int Upvotes { get; set; }

        public string UpvoteImageName = "lemonup.png";
        

        public string DownVoteImageName = "lemondown.png";

        public int Downvotes { get; set; }

        
        public bool HasUpvoted { get; set; }

        public bool HasDownvoted { get; set; }

        public bool IsFavorite { get; set; }

        public List<Models.Tag> Tags { get; set; }

        public string FavoriteImageSource = "favorite.png";

        public Complaint()
        {
            Upvotes = Downvotes = 0;
            HasDownvoted = HasUpvoted = IsFavorite = false;
        }
        public Complaint(string s)
        {
            Upvotes = Downvotes = 0;
            HasDownvoted = HasUpvoted = IsFavorite = false;

            FormattedString temp = new FormattedString();
            string[] splitter = { " ", ",", "!", ".", "#", "?" };
            string[] arr = s.Split(splitter, StringSplitOptions.None);
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("#"))
                {
                    if(i + 1 < arr.Length)
                    {
                        temp.Spans.Add(new Span() { Text = "#" + arr[i + 1], TextColor=Color.Blue, FontSize=13.5, FontFamily = "NormalFont" });
                        i++;
                    }
                    else { temp.Spans.Add(new Span() { Text = "#", TextColor=Color.Black, FontSize=14, FontFamily="NormalFont" }); }
                }
                else
                {
                    temp.Spans.Add(new Span() { Text = arr[i], FontSize = 14, FontFamily = "NormalFont", TextColor=Color.Black });
                }
            }
            FancyText = temp;

        }

        public void UpVote()
        {
            if (HasUpvoted) { HasUpvoted = false; Upvotes--; }
            else if (HasDownvoted) { HasUpvoted = true; HasDownvoted = false; Upvotes++; Downvotes--; }
            else { HasUpvoted = true; Upvotes++; }

            if (HasUpvoted)
            {
                DownVoteImageName = "lemondown.png";
                UpvoteImageName = "lemonupfilled.png";
            }
            else
            {
                UpvoteImageName = "lemonup.png";
            }
        }

        public void DownVote()
        {
            if (HasDownvoted) { HasDownvoted = false; Downvotes--; }
            else if (HasUpvoted) { HasUpvoted = false; HasDownvoted = true; Upvotes--; Downvotes++; }
            else { HasDownvoted = true; Downvotes++; }

            if (HasDownvoted)
            {
                UpvoteImageName = "lemonup.png";
                DownVoteImageName = "lemondownfilled.png";
            }
            else
            {
                DownVoteImageName = "lemondown.png";
            }
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
