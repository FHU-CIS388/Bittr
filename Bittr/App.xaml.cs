using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bittr.Services;
using Bittr.Views;

/***
 * <div>Icons made by <a href="https://www.flaticon.com/authors/freepik"
 * title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/"
 * title="Flaticon">www.flaticon.com</a></div>
 *
 *
 *<div>Icons made by <a href="https://www.flaticon.com/authors/wanicon"
 * title="wanicon">wanicon</a> from <a href="https://www.flaticon.com/"
 * title="Flaticon">www.flaticon.com</a></div>
 * 
 */



namespace Bittr
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
