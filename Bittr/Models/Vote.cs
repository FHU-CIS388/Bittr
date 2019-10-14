using System;
using System.Collections.Generic;
using System.Text;

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
        public User USer { get; set; }
        public Complaint Complaint { get; set; }
        public DateTime TimeStamp { get; set; }
        public VoteType Type { get; set; }
    }
}
