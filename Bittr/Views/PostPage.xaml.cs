using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bittr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostPage : ContentPage
    {
      

        public PostPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.PostViewModel();
        }

        public async void Done(object sender, EventArgs e)
        {
            MessagingCenter.Send<PostPage>(this, "Post");
            await Navigation.PopModalAsync();
        }

      
    }
}