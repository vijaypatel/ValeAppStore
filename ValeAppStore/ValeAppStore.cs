using System;

using Xamarin.Forms;

namespace ValeAppStore
{
    public class App : Application
    {
        public App()
        {
            Properties.Add("IsLoggedIn", false);
            Properties.Add("UserInfo", new UserInfo());

            MainPage = new NavigationPage(new ApplicationList());
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

