using System;
using System.Collections.Generic;
using System.Text;

namespace Bittr.Models
{
    class Vote
    {
        public User VoteCaster { get; set; }
        public Vote(User _voteCaster)
        {
            VoteCaster = _voteCaster;
        }
    }
}
