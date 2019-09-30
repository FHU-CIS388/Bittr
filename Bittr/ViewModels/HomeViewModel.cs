﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Bittr.Models;
using Xamarin.Forms;

namespace Bittr.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        public ObservableCollection<Complaint> Complaints { get; set; }

        public User User { get; set; }

        private Complaint newComplaint;
        public Complaint NewComplaint {
            get
            {
                return newComplaint;
            }
            set
            {
                SetProperty(ref newComplaint, value);
            }
        }

        public ICommand PostComplaintCommand { get; set; }

        public HomeViewModel()
        {
            User = new User() { Username="IdontHAVEone", FirstName="Lexi", LastName="Hudgins"};

            Complaints = new ObservableCollection<Complaint>();
            User jack = new User() { FirstName="Reece", LastName="Jack", Username="gamblt589", Avatar="LemonFace.png" };
            Complaints.Add( new Complaint() { Text= "Loyd is cold!!!!! 🥶", Timestamp=DateTime.Now, Creator=jack, ImageName= "http://static.vibe.com/uploads/2014/01/VIBE-Vixen-Cold-Weather-Meme-7.png" } );
            Complaints.Add(new Complaint() { Text = "😠 Reece always takes my seat.😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠😠", Timestamp = DateTime.Now, Creator = jack, ImageName= "https://scontent-atl3-1.xx.fbcdn.net/v/t1.0-9/44735374_2144069972587194_8140258589919936512_n.jpg?_nc_cat=109&_nc_oc=AQnhFDWDeCvtLyo7RC9QtX8YUrLx_B5R1NlEyqSIsEycDyRxB2lb1jJppVWkqoooeZQ&_nc_ht=scontent-atl3-1.xx&oh=417f8001dbd45b3f8bc9e6ecef54771f&oe=5E28FD70" });

            NewComplaint = new Complaint();

            PostComplaintCommand = new Command(PostComplaint);

        }


        private void PostComplaint()
        {
            NewComplaint.Creator = User;
            NewComplaint.Timestamp = DateTime.Now;

            //Complaints.Add(NewComplaint);
            Complaints.Insert(0, NewComplaint);

            NewComplaint = new Complaint();

        }


    }
}
