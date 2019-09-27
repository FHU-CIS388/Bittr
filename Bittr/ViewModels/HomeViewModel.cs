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
            Complaints.Add( new Complaint() { Text= "Loyd is cold!!!!! 🥶", Timestamp=DateTime.Now, Creator=jack, ImageName= "http://static.vibe.com/uploads/2014/01/VIBE-Vixen-Cold-Weather-Meme-7.png" } );
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠", Timestamp = DateTime.Now, Creator = jack, ImageName= "https://scontent-atl3-1.xx.fbcdn.net/v/t1.0-9/44735374_2144069972587194_8140258589919936512_n.jpg?_nc_cat=109&_nc_oc=AQnhFDWDeCvtLyo7RC9QtX8YUrLx_B5R1NlEyqSIsEycDyRxB2lb1jJppVWkqoooeZQ&_nc_ht=scontent-atl3-1.xx&oh=417f8001dbd45b3f8bc9e6ecef54771f&oe=5E28FD70" });

        }
    }
}
