using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bittr.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bittr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostPage : ContentPage
    {

        HomePage home;
        Models.User user;
        public PostPage(HomePage h, Models.User u)
        {
            InitializeComponent();
            BindingContext = new PostViewModel();
            home = h;
            user = u;
        }

        public async void Done(object sender, EventArgs e)
        {
            
            Editor ed = sender as Editor;
            string text = ed.Text;
            PostViewModel pvm = BindingContext as PostViewModel;
            if(text.Length > 1) home.PushPost(new Complaint(text) { Creator = user, Tags = Complaint.ExtractTags(text) });


            await Navigation.PopModalAsync();
        }

      
    }
}