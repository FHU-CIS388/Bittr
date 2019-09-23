using System;

namespace Bittr.Models
{
    public class Complaint
    {
        public string Text { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ImageName { get; set; }

        public User Creator { get; set; }

        public Complaint()
        {

        }
    }
}
