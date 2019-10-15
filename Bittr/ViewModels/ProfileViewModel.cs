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
        public ProfileViewModel()
        {
            PrimaryUser = new User() { Avatar = "reecenoel.png", Bio = "Hello there", Username = "imbatman", FullName = "Reece Noel" };
            MessagingCenter.Subscribe<PostViewModel, string>(this, "PostString", (sender, arg) =>
            {
                MessagingCenter.Send<ProfileViewModel, Complaint>(this, "PostComplaint",
                    new Complaint() { Creator = PrimaryUser, Downvotes = 0, Upvotes = 0, HasDownvoted = false, HasUpvoted=false, Id=this.GetHashCode().ToString(), Text=arg, Tags=Complaint.ExtractTags(arg) }) ;
            });

        }
    }
}