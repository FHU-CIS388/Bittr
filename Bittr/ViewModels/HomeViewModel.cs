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
            User jack = new User() { FirstName = "Reece", LastName = "Jack", Username = "gamblt589", Avatar = "profile2.png" };
            Complaints.Add(new Complaint() { Text = "Loyd is cold!!!!! 🥶", TimeStamp = DateTime.Now, Creator = jack, ImageName= "download.jpg" });
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠 #MAD", TimeStamp = DateTime.Now, Creator = jack });

        }
    }
}
