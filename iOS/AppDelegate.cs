using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ValeAppStore.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static UIApplication AppContext { get; private set;}
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppDelegate.AppContext = app;
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

