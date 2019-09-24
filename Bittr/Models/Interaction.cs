using System;
namespace Bittr.Models
{
    public enum InteractionType
    {
        UPVOTE,
        DOWNVOTE,
        FAVORITE,
        REPORT
    }

    public class Interaction
    {
        public InteractionType Type { get; set; } // InteractionType
        public int ComplaintId { get; set; } // might not be needed
        public int UserId { get; set; }
    }
}
