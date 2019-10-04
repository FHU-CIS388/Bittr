using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
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

        public ICommand HashtagCommand { get; set; }

        public HomeViewModel()
        {
            User = new User() { Username="IdontHAVEone", FirstName="Lexi", LastName="Hudgins"};
            Complaints = new ObservableCollection<Complaint>
            {
                new Complaint
                {
                    Title = "Ice Cream machine is broken",
                    ImageName = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2.jpg",
                    Text = "Ice cream machine needs to be fixed now yo",
                    Progress = .2,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "Whiteboards in Hall",
                    ImageName = "https://images-na.ssl-images-amazon.com/images/I/61wMWtAf32L._SX425_.jpg",
                    Text = "We ought to get those whiteboards outta the hall",
                    Progress = .6,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "Gano's food is terrible again!",
                    ImageName = "https://dz0zjhi21dz2t.cloudfront.net/media/117807/photos/913270/280.jpg",
                    Text = "When will this be fixed?",
                    Progress = .4,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "I'm broke, I want money",
                    ImageName = "https://miro.medium.com/max/3396/1*wNIS_wpBKqWsdgop4IR4OA.jpeg",
                    Text = "Gimme a job",
                    Progress = .8,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "I hate everything!",
                    ImageName = "https://i0.wp.com/www.nerdycreator.com/wp-content/uploads/2015/11/1103-Anger-Feeling-Angry.jpg?fit=700%2C527&ssl=1",
                    Text = "Everything!",
                    Progress = .05,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "Loyd is freezing!",
                    ImageName = "https://cdn-image.travelandleisure.com/sites/default/files/styles/1600x1000/public/1515089784/frozen-house-pipes-winter-ICYPIPES0118.jpg?itok=NlmECm3W",
                    Text = "Free chapel blankets when?",
                    Progress = .7,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                },
                new Complaint
                {
                    Title = "NO PARKING...again",
                    ImageName = "https://images-na.ssl-images-amazon.com/images/I/61VzIpcKLiL._SY679_.jpg",
                    Text = "Make more parking spaces!",
                    Progress = .5,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 5
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 2
                        }

                    },
                    Favorites = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 1
                        },
                        new Interaction
                        {
                            Type = InteractionType.FAVORITE,
                            UserId = 2
                        }
                    },
                    Downvotes= new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 3
                        },
                        new Interaction
                        {
                            Type = InteractionType.DOWNVOTE,
                            UserId = 4
                        }
                    },
                    Timestamp = new DateTime(2019,09,24)
                }
            };

            NewComplaint = new Complaint();

            PostComplaintCommand = new Command(PostComplaint);
            HashtagCommand = new Command<string>(CreateHashtag);
        }


        private void PostComplaint()
        {
            Random rnd = new Random();
            var cId = rnd.Next(); // quick hax. later increment in DB

            const string Pattern = @"(?<=#)\w+";
            //const string Symbol = "#";
            MatchCollection tags = Regex.Matches(NewComplaint.Text, Pattern, RegexOptions.Singleline);
            List<Tag> tagsList = new List<Tag>();

            foreach (Match match in tags) // TODO: Make this cleaner using Linq
            {
                Tag t = new Tag
                {
                    Title = match.Value
                };
                tagsList.Add(t);
            }

            NewComplaint.Id = cId;
            NewComplaint.Creator = User;
            NewComplaint.Timestamp = DateTime.Now;
            NewComplaint.Title = "Title";
            NewComplaint.ImageName = "empty.jpg";
            NewComplaint.Progress = 0;
            NewComplaint.Upvotes = new List<Interaction>();
            NewComplaint.Downvotes = new List<Interaction>();
            NewComplaint.Favorites = new List<Interaction>();
            NewComplaint.Reports = new List<Interaction>();
            NewComplaint.Tags = tagsList;
            NewComplaint.Flagged = false;

            //Complaints.Add(NewComplaint);
            Complaints.Insert(0, NewComplaint);

            NewComplaint = new Complaint();
        }

        async void CreateHashtag(string tag)
        {
            //await UserDialogs.Instance.AlertAsync("Hashtag tapped", tag, "Ok");
        }
    }
}
