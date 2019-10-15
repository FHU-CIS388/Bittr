using System;
namespace Bittr.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User()
        {
        }
    }
}