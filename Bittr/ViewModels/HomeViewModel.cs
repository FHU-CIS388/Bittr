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
                    if (complaint.HasUpvoted)
                    {
                        complaint.Upvotes--;
                        complaint.HasUpvoted = false;
                    }
                    else if (!complaint.HasDownvoted)
                    {
                        complaint.Upvotes++;
                        complaint.HasUpvoted = true;
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
                    if (complaint.HasDownvoted)
                    {
                        complaint.Downvotes--;
                        complaint.HasDownvoted = false;
                    }
                    else if (!complaint.HasUpvoted)
                    {

                        complaint.Downvotes++;
                        complaint.HasDownvoted = true;
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
                    if (complaint.IsFavorite)
                    {
                        complaint.IsFavorite = false;
                    }
                    else
                    {
                        complaint.IsFavorite = true;
                    }

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

            NewComplaint = new Complaint();
            string[] tokens = NewComplaint.Text.Split(' ');
            foreach (String token in tokens)
            {
                if (token.StartsWith("#"))
                {
                    Tag t = new Tag();
                    t.Id = NewComplaint.Id;
                    t.Text = token;

                    NewComplaint.Tags.Add(t);
                }
            }

            

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

        /*private async Task UpvoteComplaint(object c)  
        {
            Console.WriteLine("in upvote");
            var complaint = c as Complaint;
            complaint.Upvotes++;

        }*/


    }
}
