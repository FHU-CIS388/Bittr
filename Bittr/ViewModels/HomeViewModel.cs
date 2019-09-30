using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Bittr.Models;

namespace Bittr.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Complaint> Complaints { get; set; }

        public User User { get; set; }

        public HomeViewModel()
        {
            List<int> yeets = new List<int>(); yeets.Add(1); yeets.Add(2); yeets.Add(3); yeets.Add(4); yeets.Add(5);
            Complaints = new ObservableCollection<Complaint>();
            User jack = new User() { FullName="Jack Cannon", Username="gamblt589", Avatar= "profile1.png" };
            Complaints.Add( new Complaint() { Text= "Loyd is cold!!!!! 🥶", Timestamp=DateTime.Now, Creator=jack, ImageName= "http://static.vibe.com/uploads/2014/01/VIBE-Vixen-Cold-Weather-Meme-7.png", Tags="#54, #yeet" } );
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠", Timestamp = DateTime.Now, Creator = jack, ImageName= "https://scontent-atl3-1.xx.fbcdn.net/v/t1.0-9/44735374_2144069972587194_8140258589919936512_n.jpg?_nc_cat=109&_nc_oc=AQnhFDWDeCvtLyo7RC9QtX8YUrLx_B5R1NlEyqSIsEycDyRxB2lb1jJppVWkqoooeZQ&_nc_ht=scontent-atl3-1.xx&oh=417f8001dbd45b3f8bc9e6ecef54771f&oe=5E28FD70", Progress=.7,});
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠😠😠😠", Timestamp = DateTime.Now, Creator = jack, ImageName= "https://scontent-atl3-1.xx.fbcdn.net/v/t1.0-9/44735374_2144069972587194_8140258589919936512_n.jpg?_nc_cat=109&_nc_oc=AQnhFDWDeCvtLyo7RC9QtX8YUrLx_B5R1NlEyqSIsEycDyRxB2lb1jJppVWkqoooeZQ&_nc_ht=scontent-atl3-1.xx&oh=417f8001dbd45b3f8bc9e6ecef54771f&oe=5E28FD70", Progress=.2,});

        }
    }
}
