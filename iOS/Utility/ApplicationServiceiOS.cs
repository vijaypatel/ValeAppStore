using System;
using Xamarin.Forms;
using UIKit;
using ValeAppStore.iOS;

[assembly: Dependency(typeof(ApplicationServiceiOS))]

namespace ValeAppStore.iOS
{
    public class ApplicationServiceiOS:IApplicationService
    {
        public ApplicationServiceiOS()
        {
        }

        public bool IsInstalled(string packageName)
        {
            return  AppDelegate.AppContext.CanOpenUrl(new Foundation.NSUrl(packageName));
        }

        public void LaunchApp(string packageName)
        {
            AppDelegate.AppContext.OpenUrl(new Foundation.NSUrl(packageName));
        }
    }
}

