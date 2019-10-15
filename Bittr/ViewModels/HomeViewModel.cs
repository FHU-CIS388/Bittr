using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Bittr.Models;
using Xamarin.Forms;
using Bittr.Services;
using System.Threading.Tasks;

namespace Bittr.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        public ObservableCollection<Complaint> Complaints { get; set; }

        public User User { get; set; }

        public IDataStore<Complaint> complaintsDataStore = new MockDataStoreComplaint();

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

        public ICommand LoadComplaintsCommand { get; set; }

        public ICommand UpvoteCommand
        {
            get
            {
                return new Command((c) =>
                {
                    var complaint = c as Complaint;
                    if (!complaint.HasUpvoted)
                    {
                        complaint.VoteScore++;                        
                        complaint.DisplayUpBtn = false;
                        complaint.DisplayUpFilledBtn = true;
                        complaint.HasUpvoted = true;
                        if (complaint.HasDownvoted)
                        {
                            complaint.VoteScore++;
                            complaint.DisplayDownBtn = true;
                            complaint.DisplayDownFilledBtn = false;
                            complaint.HasDownvoted = false;
                        }
                    }
                    else
                    {
                        complaint.VoteScore--;
                        complaint.DisplayUpBtn = true;
                        complaint.DisplayUpFilledBtn = false;
                        complaint.HasUpvoted = false;
                    }

                });
            }
        }
        public ICommand DownvoteCommand
        {
            get
            {
                return new Command((c) =>
                {
                    var complaint = c as Complaint;
                    if (!complaint.HasDownvoted)
                    {
                        complaint.VoteScore--;
                        complaint.DisplayDownBtn = false;
                        complaint.DisplayDownFilledBtn = true;
                        complaint.HasDownvoted = true;
                        if (complaint.HasUpvoted)
                        {
                            complaint.VoteScore--;
                            complaint.DisplayUpBtn = true;
                            complaint.DisplayUpFilledBtn = false;
                            complaint.HasUpvoted = false;
                        }
                    }
                    else
                    {
                        complaint.VoteScore++;
                        complaint.DisplayDownBtn = true;
                        complaint.DisplayDownFilledBtn = false;
                        complaint.HasDownvoted = false;
                    }

                });
            }
        }

        public ICommand FavoriteCommand
        {
            get
            {
                return new Command((c) =>
                {
                    var complaint = c as Complaint;
                    complaint.IsFavorite = !complaint.IsFavorite;

                });
            }
        }


        public HomeViewModel()
        {
            User = new User() { Username="IdontHAVEone", FirstName="Lexi", LastName="Hudgins"};

            Complaints = new ObservableCollection<Complaint>();

            //Complaints = await complaintsDataStore.GetItemsAsync();

            NewComplaint = new Complaint();

            LoadComplaintsCommand = new Command(async () => await LoadComplaints() );
            PostComplaintCommand = new Command(PostComplaint);

            //UpvoteCommand = new Command(async(c) => await UpvoteComplaint(c));

            LoadComplaintsCommand.Execute(null);

        }

        

        private void PostComplaint()
        {
            NewComplaint.Creator = User;
            NewComplaint.Timestamp = DateTime.Now;

            //Complaints.Add(NewComplaint);
            Complaints.Insert(0, NewComplaint);

            complaintsDataStore.AddItemAsync(newComplaint);

            NewComplaint = new Complaint();

        }

        private async Task LoadComplaints()
        {
            var results = await complaintsDataStore.GetItemsAsync();

            Complaints.Clear();

            foreach(var c in results)
            {
                Complaints.Add(c);
            }
        }
        //private void UpdateVoteScore(Complaint complaint)
        //{
        //    int value = 0;
        //    foreach (Vote v in complaint.Votes)
        //    {
        //        if (v.Type == VoteType.UP) value++;
        //        else value--;
        //    }
        //    complaint.VoteScore = value;
        //}
        /*private async Task UpvoteComplaint(object c)  
        {
            Console.WriteLine("in upvote");
            var complaint = c as Complaint;
            complaint.Upvotes++;

        }*/


    }
}
