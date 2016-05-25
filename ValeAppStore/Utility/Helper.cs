using System;
using Xamarin.Forms;

namespace ValeAppStore
{
    public static class Helper
    {
        public static bool IsLoggedIn
        {
            get { return (bool)Application.Current.Properties["IsLoggedIn"]; }
            set { Application.Current.Properties["IsLoggedIn"] = value; }
        }

        public static UserInfo UserInfo
        {
            get { return (UserInfo)Application.Current.Properties["UserInfo"]; }
            set { Application.Current.Properties["UserInfo"] = value; }
        }
    }
}

