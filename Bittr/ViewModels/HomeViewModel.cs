using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Bittr.Models;
using Xamarin.Forms;
using Bittr.Services;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public ICommand PostComplaintCommand { get; set; }

        public ICommand LoadComplaintsCommand { get; set; }

        public ICommand UpvoteCommand
        {
            get
            {
                return new Command((c) =>
                {
                    var complaint = c as Complaint;
                    if (complaint.HasDownvoted == false)
                    {
                        if (complaint.HasUpvoted != true)
                        {
                            complaint.Votes++;
                            complaint.HasUpvoted = true;
                        }
                        else
                        {
                            complaint.Votes--;
                            complaint.HasUpvoted = false;
                        }
                    }
                    else
                    {
                        complaint.Votes = complaint.Votes + 2;
                        complaint.HasDownvoted = false;
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
                    if (complaint.HasUpvoted == false)
                    {
                        if (complaint.HasDownvoted != true)
                        {
                            complaint.Votes--;
                            complaint.HasDownvoted = true;
                        }
                        else
                        {
                            complaint.Votes++;
                            complaint.HasDownvoted = false;
                        }
                    }
                    else
                    {
                        complaint.Votes = complaint.Votes - 2;
                        complaint.HasDownvoted = true;
                        complaint.HasUpvoted = false;
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
                    if (complaint.HasFavorited != true)
                    {
                        complaint.HasFavorited = true;
                    }
                    else
                    {
                        complaint.HasFavorited = false;
                    }
                });
            }
        }


        public HomeViewModel()
        {
            User = new User() { Username = "IdontHAVEone", FirstName = "Lexi", LastName = "Hudgins", Avatar = "profile.png" };

            Complaints = new ObservableCollection<Complaint>();

            //Complaints = await complaintsDataStore.GetItemsAsync();

            NewComplaint = new Complaint();

            LoadComplaintsCommand = new Command(async () => await LoadComplaints());
            PostComplaintCommand = new Command(PostComplaint);

            //UpvoteCommand = new Command(async(c) => await UpvoteComplaint(c));

            LoadComplaintsCommand.Execute(null);

        }

        private void ExtractTags()
        {

        }

        private void PostComplaint()
        {
            NewComplaint.Creator = User;
            NewComplaint.Timestamp = DateTime.Now;

            string text = newComplaint.Text;
            var regex = new Regex(@"(?<=#)\w+");
            var matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                Tag newTag = new Tag();
                string hashtag = "#";
                hashtag += m.Value;
                newTag.Text = hashtag;
                NewComplaint.Tags.Add(newTag);
            }
            Complaints.Insert(0, NewComplaint);

            complaintsDataStore.AddItemAsync(newComplaint);

            NewComplaint = new Complaint();

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

        /*private async Task UpvoteComplaint(object c)  
        {
            Console.WriteLine("in upvote");
            var complaint = c as Complaint;
            complaint.Upvotes++;
        }*/


    }
}