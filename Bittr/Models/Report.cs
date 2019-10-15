using System;
using System.Collections.Generic;
using System.Text;

namespace Bittr.Models
{
    public class Report
    {
        public string Id { get; set; }
        public User User { get; set; }
        public Complaint Complaint { get; set; }
        public DateTime Timestamp { get; set; }
        public string Reason { get; set; }
    }
}
