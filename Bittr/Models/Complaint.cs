using System;
using System.Collections.Generic;
namespace Bittr.Models
{
    public class Complaint
    {
        public string Text { get; set; }

        public DateTime Timestamp { get; set; }
        public string TimeString { get; }

        public string ImageName { get; set; }

        public User Creator { get; set; }

        public double Progress { get; set; }

        public List<int> UpVotes { get; set; }
        public string UpVoteCount { get; set; }
        
        public List<int> DownVotes { get; set; }
        public string DownVoteCount { get; set; }

        public string Tags { get; set; }
        
        
        public Complaint()
        {

            TimeSpan timeDelta = DateTime.Now - Timestamp;
            if(timeDelta.TotalSeconds < 60)
            {
                TimeString = "Just now";
            } 
            else if(timeDelta.TotalMinutes < 60){
                TimeString = Math.Floor(timeDelta.TotalMinutes).ToString() + " minutes ago";
            }
            else if(timeDelta.TotalHours < 24)
            {
                TimeString = Math.Floor(timeDelta.TotalHours).ToString() + " hours ago";
            }
            else if(timeDelta.TotalHours <= 48)
            {
                TimeString = "Yesterday";
            }
            else
            {
                TimeString = Timestamp.ToString("ddd, MMM d");
                if (timeDelta.TotalDays > 364) TimeString += Timestamp.ToString(", yyyy");
            }
            
            
        }
    }
}
