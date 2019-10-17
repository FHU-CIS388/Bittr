using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Bittr.Models;
using Xamarin.Forms;
using Bittr.Services;
using System.Threading.Tasks;

namespace Bittr.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Complaint> Complaints { get; set; }

        public User User { get; set; }

        public IDataStore<Complaint> complaintsDataStore = new MockDataStoreComplaint();

        private Complaint newComplaint;
        public Complaint NewComplaint
        {
            get
            {
                return newComplaint;
            }
            set
            {
                SetProperty(ref newComplaint, value);
            }
        }

        

        public ICommand LoadComplaintsCommand { get; set; }

        public ICommand UpvoteCommand
        {
            get
            {
                return new Command((c) =>
                {
                    var C = c as Complaint;
                    if (C.HasUpvoted) { C.HasUpvoted = false; C.Upvotes--; }
                    else if (C.HasDownvoted) { C.HasUpvoted = true; C.HasDownvoted = false; C.Upvotes++; C.Downvotes--; }
                    else { C.HasUpvoted = true; C.Upvotes++; }

                    if (C.HasUpvoted)
                    {
                        C.UpvoteImageName = "lemonupfilled.png";
                    }
                    else
                    {
                        C.UpvoteImageName = "lemonup.png";
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
                    var C = c as Complaint;
                    if (C.HasDownvoted) { C.HasDownvoted = false; C.Downvotes--; }
                    else if (C.HasUpvoted) { C.HasUpvoted = false; C.HasDownvoted = true; C.Upvotes--; C.Downvotes++; }
                    else { C.HasDownvoted = true; C.Downvotes++; }

                    if (C.HasDownvoted)
                    {
                        C.DownVoteImageName = "lemondownfilled.png";
                    }
                    else
                    {
                        C.DownVoteImageName = "lemondown.png";
                    }
                });
            }
        }

        

        public HomeViewModel()
        {
            

            Complaints = new ObservableCollection<Complaint>();

            //Complaints = await complaintsDataStore.GetItemsAsync();

            NewComplaint = new Complaint();

            LoadComplaintsCommand = new Command(async () => await LoadComplaints());

            
            //UpvoteCommand = new Command(async(c) => await UpvoteComplaint(c));

            LoadComplaintsCommand.Execute(null);

            MessagingCenter.Subscribe<ProfileViewModel, Complaint>(this, "PostComplaint", async (sender, args) => {
                await PostComplaint(args);
            });
        }
        private async Task PostComplaint(Complaint c)
        {
            await complaintsDataStore.AddItemAsync(c);
        }

        private async Task LoadComplaints()
        {
            var results = await complaintsDataStore.GetItemsAsync();

            Complaints.Clear();

            foreach (var c in results)
            {
                Complaints.Add(c);
            }
        }

        


    }
}
