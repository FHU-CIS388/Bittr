using System;
using System.Collections.Generic;

namespace Bittr.Models
{
    public class Complaint
    {
        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string ImageName { get; set; }

        public User Creator { get; set; }
        public string Id { get; internal set; }
        internal List<Tag> Tags { get; set; }

        public Complaint()
        {
        }
    }
}
