using System;
namespace Bittr.Models
{
    public class Complaint
    {
        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string ImageName { get; set; }

        public int voteNumber { get; set; }

        public User Creator { get; set; }
        
        public Complaint()
        {
        }
    }
}
