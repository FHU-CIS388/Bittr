using System;
namespace Bittr.Models
{
    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get => FirstName + " " + LastName;
        }
        public string Avatar { get; set; }
        public string Bio { get; set; }

    }
}
