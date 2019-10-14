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
                    if(complaint.HasUpvoted != true)
                    {
                        if (complaint.HasDownvoted)
                        {
                            complaint.Upvotes++;
                            complaint.HasUpvoted = true;
                            complaint.HasDownvoted = false;
                        }
                        else
                        {
                            complaint.Upvotes++;
                            complaint.HasUpvoted = true;
                        }
                        
                    }
                    else
                    {
                        complaint.Upvotes--;
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
                    if(complaint.HasDownvoted != true)
                    {
                        if (complaint.HasUpvoted)
                        {
                            if(complaint.Upvotes == 0)
                            {
                                complaint.Upvotes = 0;
                                complaint.HasDownvoted = true;
                                complaint.HasUpvoted = false;
                            }
                            else
                            {
                                complaint.Upvotes--;
                                complaint.HasDownvoted = true;
                                complaint.HasUpvoted = false;
                            }
                        }
                        else
                        {
                            if (complaint.Upvotes == 0)
                            {
                                complaint.HasDownvoted = true;
                            }
                            else
                            {
                                complaint.Upvotes--;
                                complaint.HasDownvoted = true;
                            }
                        }
                    }
                    else
                    {
                        complaint.Upvotes++;
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
            User = new User() { Username = "IdontHAVEone", FirstName = "Lexi", LastName = "Hudgins" };

            Complaints = new ObservableCollection<Complaint>();

            //Complaints = await complaintsDataStore.GetItemsAsync();

            NewComplaint = new Complaint();

            LoadComplaintsCommand = new Command(async () => await LoadComplaints());
            PostComplaintCommand = new Command(PostComplaint);

            //UpvoteCommand = new Command(async(c) => await UpvoteComplaint(c));

            LoadComplaintsCommand.Execute(null);

        }



        private void PostComplaint()
        {
            NewComplaint.Creator = User;
            NewComplaint.Timestamp = DateTime.Now;

            //text
            string complain = newComplaint.Text;
            //regex
            var regex = new Regex(@"(?<=#)\w+");
            //matches
            var matches = regex.Matches(complain);
            //foreach in match
            foreach(Match i in matches)
            {
                //newtag
                Tag newTag = new Tag();
                //hashtag
                //text in tag
                newTag.Text = "#" + i.Value;
                //Complaint to add tag
                NewComplaint.Tags.Add(newTag);
            }

            //Complaints.Add(NewComplaint);
            Complaints.Insert(0, NewComplaint);

            complaintsDataStore.AddItemAsync(NewComplaint);

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
