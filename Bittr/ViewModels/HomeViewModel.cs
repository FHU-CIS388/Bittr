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
            User jack = new User() { FirstName="Reece", LastName="Jack", Username="gamblt589", Avatar="LemonFace.png" };
            Complaints.Add( new Complaint() { Text= "Loyd is cold!!!!! 🥶", Timestamp=DateTime.Now, Creator=jack } );
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠", Timestamp = DateTime.Now, Creator = jack });

        }
    }
}
