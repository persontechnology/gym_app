using gym_app.Helpers;
using gym_app.vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gym_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.IsLoggedIn == true)
            {
                MainPage = new NavigationPage(new Inicio());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
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
