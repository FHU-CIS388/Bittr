using System;
namespace Bittr.Models
{
    public class User
    {
        public int UserID { get; }
        public string Username { get; set; }

        public string Avatar { get; set; }

        public string FullName { get; set; }


        public string Bio { get; set; }

        public User()
        {
            UserID = 5;
        }

        
    }
}
