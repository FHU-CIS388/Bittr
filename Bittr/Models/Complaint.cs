using System;
using System.Collections.Generic;

namespace Bittr.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public double Progress { get; set; }
        public List<Interaction> Upvotes { get; set; }
        public List<Interaction> Downvotes { get; set; }
        public List<Interaction> Favorites { get; set; }
        public List<Interaction> Reports { get; set; }
        public List<Tag> Tags { get; set; }
        public bool Flagged { get; set; }

    }
}
