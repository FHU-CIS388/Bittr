using System;
using System.Collections.ObjectModel;
using Bittr.Models;

namespace Bittr.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Complaint> Complaints { get; set; }

        public User User { get; set; }

        public HomeViewModel()
        {
            Complaints = new ObservableCollection<Complaint>();
            User jack = new User() { FirstName = "Shannon", LastName = "David", Username = "NotDavidShannon", Avatar = "profile.png" };
            Complaints.Add(new Complaint() { Text = "Loyd is freezing!", Timestamp = DateTime.Now, Creator = jack, ImageName="loyd1.png"});
            Complaints.Add(new Complaint() { Text = "The paths to BK need to be more straightforward. I don't care about the scenic route when I have one minute to go up four flights of stairs.", Timestamp = DateTime.Now, Creator = jack });

        }
    }
}