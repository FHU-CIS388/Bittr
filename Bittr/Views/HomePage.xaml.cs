using Bittr.ViewModels;
using Bittr.Models;
using Xamarin.Forms;

namespace Bittr.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }

        void Handle_ComplaintSelected(object sender, ItemTappedEventArgs e)
        {
            Complaint complaint = (Complaint)ComplaintFeed.SelectedItem;
            Navigation.PushAsync(new ComplaintPage(complaint));
        }
    }
}
