using System;
using Android.Content;
using System.Linq;
using Android.Content.PM;

namespace ValeAppStore.Droid
{
    public class ApplicationServiceAndroid : IApplicationService
    {
        private Context Context
        {
            get { return Android.App.Application.Context; }
        }

        public ApplicationServiceAndroid()
        {
        }

        public bool IsInstalled(string packageName)
        {
            var installedApps = Context.PackageManager.GetInstalledPackages(PackageInfoFlags.MetaData);

            return installedApps.Any(x => x.PackageName.Equals(packageName, StringComparison.InvariantCultureIgnoreCase));
        }

        public void LaunchApp(string packageName)
        {
            var installedApps = Context.PackageManager.GetInstalledPackages(PackageInfoFlags.MetaData);
            var intent = Context.PackageManager.GetLaunchIntentForPackage(packageName);
            Context.StartActivity(intent);
        }
    }
}

