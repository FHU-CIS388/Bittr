using System;
using System.Collections.Generic;
using Bittr.Models;

using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {
        public List<Complaint> Complaints { get; set; }

        public HomePage()
        {
            InitializeComponent();

            Complaints = new List<Complaint>
            {
                new Complaint
                {
                    Title = "Ice Cream machine is broken",
                    ImageURL = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2.jpg",
                    Description = "Ice cream machine needs to be fixed now yo",
                    Progress = .2,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://images-na.ssl-images-amazon.com/images/I/61wMWtAf32L._SX425_.jpg",
                    Description = "We ought to get those whiteboards outta the hall",
                    Progress = .6,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://dz0zjhi21dz2t.cloudfront.net/media/117807/photos/913270/280.jpg",
                    Description = "When will this be fixed?",
                    Progress = .4,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://miro.medium.com/max/3396/1*wNIS_wpBKqWsdgop4IR4OA.jpeg",
                    Description = "Gimme a job",
                    Progress = .8,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://i0.wp.com/www.nerdycreator.com/wp-content/uploads/2015/11/1103-Anger-Feeling-Angry.jpg?fit=700%2C527&ssl=1",
                    Description = "Everything!",
                    Progress = .05,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://cdn-image.travelandleisure.com/sites/default/files/styles/1600x1000/public/1515089784/frozen-house-pipes-winter-ICYPIPES0118.jpg?itok=NlmECm3W",
                    Description = "Free chapel blankets when?",
                    Progress = .7,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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
                    ImageURL = "https://images-na.ssl-images-amazon.com/images/I/61VzIpcKLiL._SY679_.jpg",
                    Description = "Make more parking spaces!",
                    Progress = .5,
                    Upvotes = new List<Interaction>
                    {
                        new Interaction
                        {
                            Type = InteractionType.UPVOTE,
                            UserId = 0
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

            ComplaintFeed.ItemsSource = Complaints;
        }

        void Handle_ComplaintSelected(object sender, ItemTappedEventArgs e)
        {
            Complaint complaint = (Complaint)ComplaintFeed.SelectedItem;
            Navigation.PushAsync(new ComplaintPage(complaint));
        }
    }
}
