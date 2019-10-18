using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bittr.Models;
using Xamarin.Forms;

namespace Bittr.ViewModels
{
    public class ProfileViewModel : ContentView
    {
        public User PrimaryUser;
        public string Name
        {
            get { return PrimaryUser.FullName; }
        }
        public string Bio
        {
            get { return PrimaryUser.Bio; }
        }
        public ProfileViewModel()
        {
            PrimaryUser = new User() { Avatar = "reecenoel.png", Bio = "Hello there", Username = "imbatman", FullName = "Reece Noel" };
        }
    }
}