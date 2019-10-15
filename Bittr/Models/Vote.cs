using System;

namespace Bittr.Models
{
    public enum VoteType
    {
        UP,
        DOWN
    }

    public class Vote
    {
        public string Id { get; set; }
        public User User { get; set; }
        public Complaint Complaint { get; set; }
        public DateTime Timestamp { get; set; }
        public VoteType Type { get; set; }

    }
}